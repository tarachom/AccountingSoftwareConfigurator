﻿namespace Configurator
{
	partial class DirectoryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryForm));
            this.listBoxFields = new System.Windows.Forms.ListBox();
            this.contextMenuStripField = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyFiled = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listBoxTabularParts = new System.Windows.Forms.ListBox();
            this.contextMenuStripTablePart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyTablePart = new System.Windows.Forms.ToolStripMenuItem();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonAddTablePart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTriggersBeforeDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxTriggersBeforeSave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTriggersAfterSave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxHierarchical = new System.Windows.Forms.CheckBox();
            this.comboBoxHierarchical = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStripField.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.contextMenuStripTablePart.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFields
            // 
            this.listBoxFields.ContextMenuStrip = this.contextMenuStripField;
            this.listBoxFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFields.FormattingEnabled = true;
            this.listBoxFields.Location = new System.Drawing.Point(0, 0);
            this.listBoxFields.Name = "listBoxFields";
            this.listBoxFields.Size = new System.Drawing.Size(266, 382);
            this.listBoxFields.TabIndex = 0;
            this.listBoxFields.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxFields_KeyDown);
            this.listBoxFields.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFields_MouseDoubleClick);
            // 
            // contextMenuStripField
            // 
            this.contextMenuStripField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyFiled});
            this.contextMenuStripField.Name = "contextMenuStripField";
            this.contextMenuStripField.Size = new System.Drawing.Size(133, 26);
            // 
            // copyFiled
            // 
            this.copyFiled.Name = "copyFiled";
            this.copyFiled.Size = new System.Drawing.Size(132, 22);
            this.copyFiled.Text = "Копіювати";
            this.copyFiled.Click += new System.EventHandler(this.copyFiled_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 573);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.Controls.Add(this.listBoxTabularParts);
            this.panel7.Location = new System.Drawing.Point(0, 447);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(266, 123);
            this.panel7.TabIndex = 1;
            // 
            // listBoxTabularParts
            // 
            this.listBoxTabularParts.ContextMenuStrip = this.contextMenuStripTablePart;
            this.listBoxTabularParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTabularParts.FormattingEnabled = true;
            this.listBoxTabularParts.Location = new System.Drawing.Point(0, 0);
            this.listBoxTabularParts.Name = "listBoxTabularParts";
            this.listBoxTabularParts.Size = new System.Drawing.Size(266, 123);
            this.listBoxTabularParts.TabIndex = 1;
            this.listBoxTabularParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxTabularParts_KeyDown);
            this.listBoxTabularParts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTabularParts_MouseDoubleClick);
            // 
            // contextMenuStripTablePart
            // 
            this.contextMenuStripTablePart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTablePart});
            this.contextMenuStripTablePart.Name = "contextMenuStripField";
            this.contextMenuStripTablePart.Size = new System.Drawing.Size(133, 26);
            // 
            // copyTablePart
            // 
            this.copyTablePart.Name = "copyTablePart";
            this.copyTablePart.Size = new System.Drawing.Size(132, 22);
            this.copyTablePart.Text = "Копіювати";
            this.copyTablePart.Click += new System.EventHandler(this.copyTablePart_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.buttonAddTablePart);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, 415);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 30);
            this.panel6.TabIndex = 4;
            // 
            // buttonAddTablePart
            // 
            this.buttonAddTablePart.Location = new System.Drawing.Point(105, 3);
            this.buttonAddTablePart.Name = "buttonAddTablePart";
            this.buttonAddTablePart.Size = new System.Drawing.Size(55, 23);
            this.buttonAddTablePart.TabIndex = 8;
            this.buttonAddTablePart.Text = "Додати";
            this.buttonAddTablePart.UseVisualStyleBackColor = true;
            this.buttonAddTablePart.Click += new System.EventHandler(this.buttonAddTablePart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Табличні частини";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.listBoxFields);
            this.panel5.Location = new System.Drawing.Point(0, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 382);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonDown);
            this.panel4.Controls.Add(this.buttonUp);
            this.panel4.Controls.Add(this.buttonAddField);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 30);
            this.panel4.TabIndex = 3;
            // 
            // buttonDown
            // 
            this.buttonDown.Image = global::Configurator.Properties.Resources.down;
            this.buttonDown.Location = new System.Drawing.Point(231, 4);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(32, 23);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Image = global::Configurator.Properties.Resources.up;
            this.buttonUp.Location = new System.Drawing.Point(193, 4);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(32, 23);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonAddField
            // 
            this.buttonAddField.Location = new System.Drawing.Point(44, 4);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(55, 23);
            this.buttonAddField.TabIndex = 7;
            this.buttonAddField.Text = "Додати";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поля";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.Location = new System.Drawing.Point(680, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(109, 32);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 583);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 38);
            this.panel2.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(795, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(109, 32);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxHierarchical);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxHierarchical);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDesc);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTable);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(907, 573);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxTriggersBeforeDelete);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxTriggersBeforeSave);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxTriggersAfterSave);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(15, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 109);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функції";
            // 
            // textBoxTriggersBeforeDelete
            // 
            this.textBoxTriggersBeforeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTriggersBeforeDelete.Location = new System.Drawing.Point(119, 71);
            this.textBoxTriggersBeforeDelete.Name = "textBoxTriggersBeforeDelete";
            this.textBoxTriggersBeforeDelete.Size = new System.Drawing.Size(494, 20);
            this.textBoxTriggersBeforeDelete.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Перед видаленням:";
            // 
            // textBoxTriggersBeforeSave
            // 
            this.textBoxTriggersBeforeSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTriggersBeforeSave.Location = new System.Drawing.Point(119, 19);
            this.textBoxTriggersBeforeSave.Name = "textBoxTriggersBeforeSave";
            this.textBoxTriggersBeforeSave.Size = new System.Drawing.Size(494, 20);
            this.textBoxTriggersBeforeSave.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Перед записом:";
            // 
            // textBoxTriggersAfterSave
            // 
            this.textBoxTriggersAfterSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTriggersAfterSave.Location = new System.Drawing.Point(119, 45);
            this.textBoxTriggersAfterSave.Name = "textBoxTriggersAfterSave";
            this.textBoxTriggersAfterSave.Size = new System.Drawing.Size(494, 20);
            this.textBoxTriggersAfterSave.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Після запису:";
            // 
            // checkBoxHierarchical
            // 
            this.checkBoxHierarchical.AutoSize = true;
            this.checkBoxHierarchical.Location = new System.Drawing.Point(85, 468);
            this.checkBoxHierarchical.Name = "checkBoxHierarchical";
            this.checkBoxHierarchical.Size = new System.Drawing.Size(130, 17);
            this.checkBoxHierarchical.TabIndex = 8;
            this.checkBoxHierarchical.Text = "Ієрархічний довідник";
            this.checkBoxHierarchical.UseVisualStyleBackColor = true;
            this.checkBoxHierarchical.Visible = false;
            this.checkBoxHierarchical.CheckedChanged += new System.EventHandler(this.checkBoxHierarchical_CheckedChanged);
            // 
            // comboBoxHierarchical
            // 
            this.comboBoxHierarchical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHierarchical.Enabled = false;
            this.comboBoxHierarchical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxHierarchical.FormattingEnabled = true;
            this.comboBoxHierarchical.Location = new System.Drawing.Point(85, 491);
            this.comboBoxHierarchical.Name = "comboBoxHierarchical";
            this.comboBoxHierarchical.Size = new System.Drawing.Size(459, 21);
            this.comboBoxHierarchical.TabIndex = 7;
            this.comboBoxHierarchical.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Довідник:";
            this.label7.Visible = false;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(85, 83);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(549, 62);
            this.textBoxDesc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Опис:";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTable.Location = new System.Drawing.Point(85, 57);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(549, 20);
            this.textBoxTable.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Назва в базі:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(85, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(549, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Назва:";
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 631);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DirectoryForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Довідник";
            this.Load += new System.EventHandler(this.DirectoryForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DirectoryForm_KeyDown);
            this.contextMenuStripField.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.contextMenuStripTablePart.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxFields;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ListBox listBoxTabularParts;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxDesc;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTable;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonAddField;
		private System.Windows.Forms.Button buttonAddTablePart;
		private System.Windows.Forms.ComboBox comboBoxHierarchical;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBoxHierarchical;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripField;
		private System.Windows.Forms.ToolStripMenuItem copyFiled;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripTablePart;
		private System.Windows.Forms.ToolStripMenuItem copyTablePart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTriggersAfterSave;
        private System.Windows.Forms.TextBox textBoxTriggersBeforeSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTriggersBeforeDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
    }
}