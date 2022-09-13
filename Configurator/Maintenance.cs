/*
Copyright (C) 2019-2022 TARAKHOMYN YURIY IVANOVYCH
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

/*
Автор:    Тарахомин Юрій Іванович
Адреса:   Україна, м. Львів
Сайт:     accounting.org.ua
*/

using System;
using System.Threading;
using System.Windows.Forms;

using AccountingSoftware;

namespace Configurator
{
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        public Configuration Conf { get; set; }
        CancellationTokenSource CancellationTokenThread { get; set; }
        private Thread thread;

        public string AutoCommandExecute { get; set; }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            Conf = Program.Kernel.Conf;

            buttonStop.Enabled = false;

            if (AutoCommandExecute == "maintenance")
            {
                buttonStart_Click(this, null);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            richTextBoxInfo.Text = "";

            CancellationTokenThread = new CancellationTokenSource();
            thread = new Thread(new ThreadStart(MaintenanceTable));
            thread.Start();
        }

        void MaintenanceTable()
        {
            ApendLine("Структура бази даних");
            ConfigurationInformationSchema informationSchema = Program.Kernel.DataBase.SelectInformationSchema();

            ApendLine("Таблиць: " + informationSchema.Tables.Count);
            ApendLine("");

            ApendLine("Обробка таблиць:");

            foreach (ConfigurationInformationSchema_Table table in informationSchema.Tables.Values)
            {
                if (CancellationTokenThread.IsCancellationRequested)
                    break;

                ApendLine($" --> {table.TableName}");

                string query = $@"VACUUM FULL {table.TableName};";

                Program.Kernel.DataBase.ExecuteSQL(query);
            }

            buttonStart.Invoke(new Action(() => buttonStart.Enabled = true));
            buttonStop.Invoke(new Action(() => buttonStop.Enabled = false));

            ApendLine("");
            ApendLine("Готово!");

            if (!String.IsNullOrEmpty(AutoCommandExecute))
                this.Invoke(new Action(() => this.DialogResult = DialogResult.OK));
        }

        private void ApendLine(string text)
        {
            if (richTextBoxInfo.InvokeRequired)
            {
                richTextBoxInfo.Invoke(new Action<string>(ApendLine), text);
            }
            else
            {
                richTextBoxInfo.AppendText("\n" + text);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;

            CancellationTokenThread.Cancel();
        }
    }
}
