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
using System.Windows.Forms;
using AccountingSoftware;

namespace Configurator
{
    public partial class ConfigurationInfoForm : Form
    {
        public Configuration Conf { get; set; }

        public FormConfiguration OwnerForm { get; set; }

        public ConfigurationInfoForm()
        {
            InitializeComponent();
        }

        private void ConfigurationInfoForm_Load(object sender, EventArgs e)
        {
            textBox_Назва.Text = Conf.Name;
            textBox_ПростірІмен.Text = Conf.NameSpace;
            textBox_Автор.Text = Conf.Author;
            textBox_Desc.Text = Conf.Desc;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBox_ПростірІмен.Text;
            string errorList = Configuration.ValidateConfigurationObjectName(Program.Kernel, ref name);
            textBox_ПростірІмен.Text = name;

            if (errorList.Length > 0)
            {
                MessageBox.Show(errorList, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Conf.Name = textBox_Назва.Text;
            Conf.NameSpace = textBox_ПростірІмен.Text;
            Conf.Author = textBox_Автор.Text;
            Conf.Desc = textBox_Desc.Text;

            if (OwnerForm != null)
                OwnerForm.LoadConfInfo();

            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
