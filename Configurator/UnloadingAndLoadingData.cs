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
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using AccountingSoftware;
using System.IO;

namespace Configurator
{
    public partial class UnloadingAndLoadingData : Form
    {
        public UnloadingAndLoadingData()
        {
            InitializeComponent();
        }

        public Configuration Conf { get; set; }

        CancellationTokenSource CancellationTokenThread { get; set; }
        private Thread thread;

        public string AutoCommandExecute { get; set; }
        public string AutoCommandExecuteParam { get; set; }

        private void UnloadingAndLoadingData_Load(object sender, EventArgs e)
        {
            if (AutoCommandExecute == "unloadingdata")
            {
                string fileExport = "";

                if (!String.IsNullOrEmpty(AutoCommandExecuteParam))
                    fileExport = AutoCommandExecuteParam;
                else
                    fileExport = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                       Conf.Name + "_Export_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xml");

                buttonLoadingData.Enabled = buttonUnloadingData.Enabled = false;
                buttonStop.Enabled = true;

                richTextBoxInfo.Text = "";

                CancellationTokenThread = new CancellationTokenSource();
                thread = new Thread(new ParameterizedThreadStart(ExportData));
                thread.Start(fileExport);
            }

            if (AutoCommandExecute == "loadingdata")
            {
                string fileImport = "";

                if (!String.IsNullOrEmpty(AutoCommandExecuteParam))
                    fileImport = AutoCommandExecuteParam;
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    return;
                }

                buttonLoadingData.Enabled = buttonUnloadingData.Enabled = false;
                buttonStop.Enabled = true;

                richTextBoxInfo.Text = "";

                CancellationTokenThread = new CancellationTokenSource();
                thread = new Thread(new ParameterizedThreadStart(ImportData));
                thread.Start(fileImport);
            }
        }

        private void buttonUnloadingData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = Conf.Name + "_Export_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xml";
            saveFileDialog.Filter = "XML|*.xml";
            saveFileDialog.Title = "Файл для вигрузки даних";
            saveFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();

            if (!(saveFileDialog.ShowDialog() == DialogResult.OK))
                return;
            else
            {
                string fileExport = saveFileDialog.FileName;

                buttonLoadingData.Enabled = buttonUnloadingData.Enabled = false;
                buttonStop.Enabled = true;

                richTextBoxInfo.Text = "";

                CancellationTokenThread = new CancellationTokenSource();
                thread = new Thread(new ParameterizedThreadStart(ExportData));
                thread.Start(fileExport); 
            }
        }

        private void buttonLoadingData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML|*.xml";
            openFileDialog.Title = "Файл для загрузки даних";
            openFileDialog.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();

            if (!(openFileDialog.ShowDialog() == DialogResult.OK))
                return;
            else
            {
                string fileImport = openFileDialog.FileName;

                buttonLoadingData.Enabled = buttonUnloadingData.Enabled = false;
                buttonStop.Enabled = true;

                richTextBoxInfo.Text = "";

                CancellationTokenThread = new CancellationTokenSource();
                thread = new Thread(new ParameterizedThreadStart(ImportData));
                thread.Start(fileImport); 
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonLoadingData.Enabled = buttonUnloadingData.Enabled = true;

            buttonStop.Enabled = false;

            CancellationTokenThread.Cancel();
        }

        #region Export

        /// <summary>
        /// Вигрузка даних
        /// </summary>
        /// <param name="fileExport">Файл вигрузки</param>
        void ExportData(object fileExport)
        {
            ApendLine("Файл вигрузки: " + fileExport.ToString() + "\n\n");

            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, Encoding = Encoding.UTF8 };

            XmlWriter xmlWriter = XmlWriter.Create(fileExport.ToString(), settings);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("root");

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine("КОНСТАНТИ");

                xmlWriter.WriteStartElement("Constants");
                foreach (ConfigurationConstantsBlock configurationConstantsBlock in Conf.ConstantsBlock.Values)
                {
                    if (CancellationTokenThread.IsCancellationRequested)
                        break;

                    ApendLine(configurationConstantsBlock.BlockName);

                    foreach (ConfigurationConstants configurationConstants in configurationConstantsBlock.Constants.Values)
                    {
                        if (CancellationTokenThread.IsCancellationRequested)
                            break;

                        ApendLine(" --> Константа: " + configurationConstants.Name);

                        xmlWriter.WriteStartElement("Constant");
                        xmlWriter.WriteAttributeString("name", configurationConstants.Name);
                        xmlWriter.WriteAttributeString("col", configurationConstants.NameInTable);

                        foreach (ConfigurationObjectTablePart tablePart in configurationConstants.TabularParts.Values)
                        {
                            if (CancellationTokenThread.IsCancellationRequested)
                                break;

                            xmlWriter.WriteStartElement("TablePart");
                            xmlWriter.WriteAttributeString("name", tablePart.Name);
                            xmlWriter.WriteAttributeString("tab", tablePart.Table);

                            WriteQuerySelect(xmlWriter, $@"SELECT uid{GetAllFields(tablePart.Fields)} FROM {tablePart.Table}");

                            xmlWriter.WriteEndElement();
                        }

                        WriteQuerySelect(xmlWriter, $@"SELECT {configurationConstants.NameInTable} FROM tab_constants");

                        xmlWriter.WriteEndElement(); //Constant
                    }
                }
                xmlWriter.WriteEndElement(); //Constants
            }

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine("ДОВІДНИКИ");

                xmlWriter.WriteStartElement("Directories");
                foreach (ConfigurationDirectories configurationDirectories in Conf.Directories.Values)
                {
                    if (CancellationTokenThread.IsCancellationRequested)
                        break;

                    ApendLine(" --> Довідник: " + configurationDirectories.Name);

                    xmlWriter.WriteStartElement("Directory");
                    xmlWriter.WriteAttributeString("name", configurationDirectories.Name);
                    xmlWriter.WriteAttributeString("tab", configurationDirectories.Table);

                    WriteQuerySelect(xmlWriter, $@"SELECT uid{GetAllFields(configurationDirectories.Fields)} FROM {configurationDirectories.Table}");

                    foreach (ConfigurationObjectTablePart tablePart in configurationDirectories.TabularParts.Values)
                    {
                        if (CancellationTokenThread.IsCancellationRequested)
                            break;

                        xmlWriter.WriteStartElement("TablePart");
                        xmlWriter.WriteAttributeString("name", tablePart.Name);
                        xmlWriter.WriteAttributeString("tab", tablePart.Table);

                        WriteQuerySelect(xmlWriter, $@"SELECT uid, owner{GetAllFields(tablePart.Fields)} FROM {tablePart.Table}");

                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement(); //Directory
                }
                xmlWriter.WriteEndElement(); //Directories
            }

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine("ДОКУМЕНТИ");

                xmlWriter.WriteStartElement("Documents");
                foreach (ConfigurationDocuments configurationDocuments in Conf.Documents.Values)
                {
                    if (CancellationTokenThread.IsCancellationRequested)
                        break;

                    ApendLine(" --> Документ: " + configurationDocuments.Name);

                    xmlWriter.WriteStartElement("Document");
                    xmlWriter.WriteAttributeString("name", configurationDocuments.Name);
                    xmlWriter.WriteAttributeString("tab", configurationDocuments.Table);

                    WriteQuerySelect(xmlWriter, $@"SELECT uid, spend, spend_date{GetAllFields(configurationDocuments.Fields)} FROM {configurationDocuments.Table}");

                    foreach (ConfigurationObjectTablePart tablePart in configurationDocuments.TabularParts.Values)
                    {
                        if (CancellationTokenThread.IsCancellationRequested)
                            break;

                        xmlWriter.WriteStartElement("TablePart");
                        xmlWriter.WriteAttributeString("name", tablePart.Name);
                        xmlWriter.WriteAttributeString("tab", tablePart.Table);

                        WriteQuerySelect(xmlWriter, $@"SELECT uid, owner{GetAllFields(tablePart.Fields)} FROM {tablePart.Table}");

                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement(); //Document
                }
                xmlWriter.WriteEndElement(); //Documents
            }

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine("РЕГІСТРИ ІНФОРМАЦІЇ");

                xmlWriter.WriteStartElement("RegistersInformation");
                foreach (ConfigurationRegistersInformation configurationRegistersInformation in Conf.RegistersInformation.Values)
                {
                    if (CancellationTokenThread.IsCancellationRequested)
                        break;

                    ApendLine(" --> Регістр: " + configurationRegistersInformation.Name);

                    xmlWriter.WriteStartElement("Register");
                    xmlWriter.WriteAttributeString("name", configurationRegistersInformation.Name);
                    xmlWriter.WriteAttributeString("tab", configurationRegistersInformation.Table);

                    string query_fields = GetAllFields(configurationRegistersInformation.DimensionFields) +
                        GetAllFields(configurationRegistersInformation.ResourcesFields) +
                        GetAllFields(configurationRegistersInformation.PropertyFields);

                    WriteQuerySelect(xmlWriter, $@"SELECT uid, period, owner{query_fields} FROM {configurationRegistersInformation.Table}");

                    xmlWriter.WriteEndElement(); //Register
                }
                xmlWriter.WriteEndElement(); //RegistersInformation
            }

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine("РЕГІСТРИ НАКОПИЧЕННЯ");

                xmlWriter.WriteStartElement("RegistersAccumulation");
                foreach (ConfigurationRegistersAccumulation configurationRegistersAccumulation in Conf.RegistersAccumulation.Values)
                {
                    if (CancellationTokenThread.IsCancellationRequested)
                        break;

                    ApendLine(" --> Регістр: " + configurationRegistersAccumulation.Name);

                    xmlWriter.WriteStartElement("Register");
                    xmlWriter.WriteAttributeString("name", configurationRegistersAccumulation.Name);
                    xmlWriter.WriteAttributeString("tab", configurationRegistersAccumulation.Table);

                    string query_fields = GetAllFields(configurationRegistersAccumulation.DimensionFields) +
                        GetAllFields(configurationRegistersAccumulation.ResourcesFields) +
                        GetAllFields(configurationRegistersAccumulation.PropertyFields);

                    WriteQuerySelect(xmlWriter, $@"SELECT uid, period, income, owner{query_fields} FROM {configurationRegistersAccumulation.Table}");

                    xmlWriter.WriteEndElement(); //Register
                }
                xmlWriter.WriteEndElement(); //RegistersAccumulation
            }

            xmlWriter.WriteEndElement(); //root
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();

            buttonUnloadingData.Invoke(new Action(() => buttonUnloadingData.Enabled = true));
            buttonLoadingData.Invoke(new Action(() => buttonLoadingData.Enabled = true));
            buttonStop.Invoke(new Action(() => buttonStop.Enabled = false));

            ApendLine("");
            ApendLine("Готово!");

            if (!String.IsNullOrEmpty(AutoCommandExecute))
                this.Invoke(new Action(() => this.DialogResult = DialogResult.OK));
        }

        /// <summary>
        /// Стрічка для SQL запиту із списком полів
        /// </summary>
        /// <param name="fields">Колекція полів</param>
        /// <returns>Список полів</returns>
        string GetAllFields(Dictionary<string, ConfigurationObjectField> fields)
        {
            string guery_fields = "";

            foreach (ConfigurationObjectField field in fields.Values)
                guery_fields += $", {field.NameInTable}";

            return guery_fields;
        }

        #region Info (додаткові відомості у файл вигрузки)

        void WriteFieldsInfo(XmlWriter xmlWriter, Dictionary<string, ConfigurationObjectField> fields)
        {
            xmlWriter.WriteStartElement("FieldInfo");
            foreach (ConfigurationObjectField field in fields.Values)
            {
                xmlWriter.WriteStartElement("Field");
                xmlWriter.WriteAttributeString("name", field.Name);
                xmlWriter.WriteAttributeString("col", field.NameInTable);
                xmlWriter.WriteAttributeString("type", field.Type);
                if (field.Type == "pointer" || field.Type == "enum")
                    xmlWriter.WriteAttributeString("pointer", field.Pointer);
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }

        void WriteTablePartInfo(XmlWriter xmlWriter, ConfigurationObjectTablePart tablePart)
        {
            xmlWriter.WriteStartElement("TablePart");
            xmlWriter.WriteAttributeString("name", tablePart.Name);
            xmlWriter.WriteAttributeString("tab", tablePart.Table);

            WriteFieldsInfo(xmlWriter, tablePart.Fields);

            xmlWriter.WriteEndElement();
        }

        void WriteTabularPartsInfo(XmlWriter xmlWriter, Dictionary<string, ConfigurationObjectTablePart> tabularParts)
        {
            if (tabularParts.Count > 0)
            {
                xmlWriter.WriteStartElement("TabularPartsInfo");
                foreach (ConfigurationObjectTablePart tablePart in tabularParts.Values)
                    WriteTablePartInfo(xmlWriter, tablePart);
                xmlWriter.WriteEndElement(); //TabularPartsInfo
            }
        }

        #endregion

        /// <summary>
        /// Виконання запиту та запис даних
        /// </summary>
        /// <param name="xmlWriter">ХМЛ</param>
        /// <param name="query">Запит</param>
        void WriteQuerySelect(XmlWriter xmlWriter, string query)
        {
            string[] columnsName;
            List<object[]> listRow;

            Program.Kernel.DataBase.SelectRequest(query, null, out columnsName, out listRow);

            foreach (object[] row in listRow)
            {
                if (CancellationTokenThread.IsCancellationRequested)
                    break;

                int counter = 0;

                xmlWriter.WriteStartElement("row");
                foreach (string column in columnsName)
                {
                    string typeName = row[counter].GetType().Name;

                    if (typeName != "DBNull")
                    {
                        xmlWriter.WriteStartElement(column);
                        xmlWriter.WriteAttributeString("type", typeName);

                        switch (typeName)
                        {
                            case "String[]":
                                {
                                    xmlWriter.WriteRaw(ArrayToXml<string>.Convert((string[])row[counter]));
                                    break;
                                }
                            case "Int32[]":
                                {
                                    xmlWriter.WriteRaw(ArrayToXml<int>.Convert((int[])row[counter]));
                                    break;
                                }
                            case "Decimal[]":
                                {
                                    xmlWriter.WriteRaw(ArrayToXml<decimal>.Convert((decimal[])row[counter]));
                                    break;
                                }
                            case "UuidAndText":
                                {
                                    xmlWriter.WriteRaw(((UuidAndText)row[counter]).ToXml());
                                    break;
                                }
                            default:
                                {
                                    xmlWriter.WriteString(row[counter].ToString());
                                    break;
                                }
                        }

                        xmlWriter.WriteEndElement();
                    }

                    counter++;
                }
                xmlWriter.WriteEndElement();
            }

            xmlWriter.Flush();
        }

        #endregion

        #region Import

        /// <summary>
        /// Загрузка даних
        /// </summary>
        /// <param name="fileImport">Файл загрузки</param>
        void ImportData(object fileImport)
        {
            ApendLine("Файл загрузки: " + fileImport.ToString() + "\n\n");

            ApendLine("Аналіз: ");

            string pathToXmlResultStepOne = "";

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine(" --> Крок 1");
                pathToXmlResultStepOne = TransformXmlDataStepOne(fileImport.ToString());
            }

            string pathToXmlResultStepSQL = "";

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine(" --> Крок 2");
                pathToXmlResultStepSQL = TransformStepOneToStepSQL(fileImport.ToString(), pathToXmlResultStepOne);
            }

            if (!CancellationTokenThread.IsCancellationRequested)
            {
                ApendLine("Виконання команд: ");

                try
                {
                    Program.Kernel.DataBase.BeginTransaction();

                    bool resultat = ExecuteSqlList(pathToXmlResultStepSQL);

                    if (resultat)
                        Program.Kernel.DataBase.CommitTransaction();
                    else
                        Program.Kernel.DataBase.RollbackTransaction();
                }
                catch (Exception ex)
                {
                    ApendLine("Помилка: " + ex.Message);

                    Program.Kernel.DataBase.RollbackTransaction();
                    return;
                }
            }

            //Видалення тимчасових файлів
            File.Delete(pathToXmlResultStepOne);
            File.Delete(pathToXmlResultStepSQL);

            ApendLine(" --> Готово!");

            buttonUnloadingData.Invoke(new Action(() => buttonUnloadingData.Enabled = true));
            buttonLoadingData.Invoke(new Action(() => buttonLoadingData.Enabled = true));
            buttonStop.Invoke(new Action(() => buttonStop.Enabled = false));

            if (!String.IsNullOrEmpty(AutoCommandExecute))
                this.Invoke(new Action(() => this.DialogResult = DialogResult.OK));
        }

        /// <summary>
        /// Трансформація даних Крок 1
        /// </summary>
        /// <param name="fileImport">Файл загрузки</param>
        /// <returns>Файл трансформації</returns>
        string TransformXmlDataStepOne(string fileImport)
        {
            string pathToTemplate = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "UnloadingAndLoadingDataXML.xslt");
            string pathToDirFileImport = Path.GetDirectoryName(fileImport);
            string pathToXmlResult = Path.Combine(pathToDirFileImport, "stepone_" + Guid.NewGuid().ToString().Replace("-", "") + ".xml");

            XslCompiledTransform xsltCodeGnerator = new XslCompiledTransform();
            xsltCodeGnerator.Load(pathToTemplate, new XsltSettings(false, false), null);

            XsltArgumentList xsltArgumentList = new XsltArgumentList();

            FileStream fileStream = new FileStream(pathToXmlResult, FileMode.Create);

            xsltCodeGnerator.Transform(fileImport, xsltArgumentList, fileStream);

            fileStream.Close();

            return pathToXmlResult;
        }

        /// <summary>
        /// Трансформація даних Крок 2
        /// </summary>
        /// <param name="fileImport">Файл загрузки</param>
        /// <param name="fileStepOne">Файл першої трансформації (Крок 1)</param>
        /// <returns>Файл трансформації</returns>
        string TransformStepOneToStepSQL(string fileImport, string fileStepOne)
        {
            string pathToTemplate = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "UnloadingAndLoadingDataSQL.xslt");
            string pathToDirFileImport = Path.GetDirectoryName(fileImport);
            string pathToXmlResult = Path.Combine(pathToDirFileImport, "stepsql_" + Guid.NewGuid().ToString().Replace("-", "") + ".xml");

            XslCompiledTransform xsltCodeGnerator = new XslCompiledTransform();
            xsltCodeGnerator.Load(pathToTemplate, new XsltSettings(false, false), null);

            XsltArgumentList xsltArgumentList = new XsltArgumentList();

            FileStream fileStream = new FileStream(pathToXmlResult, FileMode.Create);

            xsltCodeGnerator.Transform(fileStepOne, xsltArgumentList, fileStream);

            fileStream.Close();

            return pathToXmlResult;
        }

        /// <summary>
        /// Виконання SQL запитів
        /// </summary>
        /// <param name="fileStepSQL">Файл з запитами</param>
        public bool ExecuteSqlList(string fileStepSQL)
        {
            XPathDocument xPathDoc = new XPathDocument(fileStepSQL);
            XPathNavigator xPathDocNavigator = xPathDoc.CreateNavigator();

            XPathNodeIterator rowNodes = xPathDocNavigator.Select("/root/row");
            while (rowNodes.MoveNext())
            {
                if (CancellationTokenThread.IsCancellationRequested)
                    return false;

                XPathNavigator sqlNode = rowNodes.Current.SelectSingleNode("sql");
                string sqlText = sqlNode.Value;

                Dictionary<string, object> param = new Dictionary<string, object>();

                XPathNodeIterator paramNodes = rowNodes.Current.Select("p");
                while (paramNodes.MoveNext())
                {
                    string paramName = paramNodes.Current.GetAttribute("name", "");
                    string paramType = paramNodes.Current.GetAttribute("type", "");

                    string paramValue = paramNodes.Current.Value;
                    object paramObj;

                    switch (paramType)
                    {
                        case "Guid":
                            {
                                paramObj = Guid.Parse(paramValue);
                                break;
                            }
                        case "Int32":
                            {
                                paramObj = int.Parse(paramValue);
                                break;
                            }
                        case "DateTime":
                            {
                                paramObj = DateTime.Parse(paramValue);
                                break;
                            }
                        case "TimeSpan":
                            {
                                paramObj = TimeSpan.Parse(paramValue);
                                break;
                            }
                        case "Boolean":
                            {
                                paramObj = Boolean.Parse(paramValue);
                                break;
                            }
                        case "Decimal":
                            {
                                paramObj = Decimal.Parse(paramValue);
                                break;
                            }
                        case "String":
                            {
                                paramObj = paramValue;
                                break;
                            }
                        case "String[]":
                            {
                                paramObj = ArrayToXml.Convert(paramNodes.Current.InnerXml);
                                break;
                            }
                        case "Int32[]":
                            {
                                string[] tmpValue = ArrayToXml.Convert(paramNodes.Current.InnerXml);
                                int[] tmpIntValue = new int[tmpValue.Length];

                                for (int i=0; i< tmpValue.Length; i++)
                                    tmpIntValue[i] = int.Parse(tmpValue[i]);

                                paramObj = tmpIntValue;
                                break;
                            }
                        case "Decimal[]":
                            {
                                string[] tmpValue = ArrayToXml.Convert(paramNodes.Current.InnerXml);
                                decimal[] tmpDecimalValue = new decimal[tmpValue.Length];

                                for (int i = 0; i < tmpValue.Length; i++)
                                    tmpDecimalValue[i] = decimal.Parse(tmpValue[i]);

                                paramObj = tmpDecimalValue;
                                break;
                            }
                        case "UuidAndText":
                            {
                                paramObj = ArrayToXml.ConvertUuidAndText(paramNodes.Current.InnerXml);
                                break;
                            }
                        default:
                            {
                                ApendLine("Не оприділений тип: " + paramType);
                                paramObj = paramValue;
                                break;
                            }
                    }

                    param.Add(paramName, paramObj);
                }

                int result = Program.Kernel.DataBase.ExecuteSQL(sqlText, param);
                ApendInfo(".");
            }

            return true;
        }

        #endregion

        private void ApendLine(string text)
        {
            if (richTextBoxInfo.InvokeRequired)
            {
                richTextBoxInfo.Invoke(new Action<string>(ApendLine), text);
            }
            else
            {
                richTextBoxInfo.AppendText("\n" + text);
                //richTextBoxInfo.ScrollToCaret();
            }
        }

        private void ApendInfo(string text)
        {
            if (richTextBoxInfo.InvokeRequired)
            {
                richTextBoxInfo.Invoke(new Action<string>(ApendInfo), text);
            }
            else
            {
                richTextBoxInfo.AppendText(text);
            }
        }
    }
}
