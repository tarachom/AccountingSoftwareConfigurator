namespace Configurator
{
	partial class ConstantsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstantsForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listBoxTabularParts = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonAddTablePart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameInTable = new System.Windows.Forms.TextBox();
            this.comboBoxBlock = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEnums = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPointer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFieldType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(739, 3);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(127, 37);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.Location = new System.Drawing.Point(605, 3);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 37);
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
            this.panel2.Location = new System.Drawing.Point(12, 463);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 44);
            this.panel2.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNameInTable);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxBlock);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxEnums);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxPointer);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxFieldType);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDesc);
            this.splitContainer1.Size = new System.Drawing.Size(872, 451);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listBoxTabularParts);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 35);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(246, 416);
            this.panel7.TabIndex = 6;
            // 
            // listBoxTabularParts
            // 
            this.listBoxTabularParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTabularParts.FormattingEnabled = true;
            this.listBoxTabularParts.ItemHeight = 15;
            this.listBoxTabularParts.Location = new System.Drawing.Point(0, 0);
            this.listBoxTabularParts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTabularParts.Name = "listBoxTabularParts";
            this.listBoxTabularParts.Size = new System.Drawing.Size(246, 416);
            this.listBoxTabularParts.TabIndex = 1;
            this.listBoxTabularParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxTabularParts_KeyDown);
            this.listBoxTabularParts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTabularParts_MouseDoubleClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonAddTablePart);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 35);
            this.panel6.TabIndex = 5;
            // 
            // buttonAddTablePart
            // 
            this.buttonAddTablePart.Location = new System.Drawing.Point(122, 3);
            this.buttonAddTablePart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddTablePart.Name = "buttonAddTablePart";
            this.buttonAddTablePart.Size = new System.Drawing.Size(64, 27);
            this.buttonAddTablePart.TabIndex = 8;
            this.buttonAddTablePart.Text = "Додати";
            this.buttonAddTablePart.UseVisualStyleBackColor = true;
            this.buttonAddTablePart.Click += new System.EventHandler(this.buttonAddTablePart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Табличні частини";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Назва в базі:";
            // 
            // textBoxNameInTable
            // 
            this.textBoxNameInTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameInTable.Location = new System.Drawing.Point(102, 65);
            this.textBoxNameInTable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNameInTable.Name = "textBoxNameInTable";
            this.textBoxNameInTable.Size = new System.Drawing.Size(513, 23);
            this.textBoxNameInTable.TabIndex = 30;
            // 
            // comboBoxBlock
            // 
            this.comboBoxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBlock.FormattingEnabled = true;
            this.comboBoxBlock.Location = new System.Drawing.Point(102, 95);
            this.comboBoxBlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxBlock.Name = "comboBoxBlock";
            this.comboBoxBlock.Size = new System.Drawing.Size(514, 23);
            this.comboBoxBlock.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Блок:";
            // 
            // comboBoxEnums
            // 
            this.comboBoxEnums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEnums.FormattingEnabled = true;
            this.comboBoxEnums.Location = new System.Drawing.Point(102, 269);
            this.comboBoxEnums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxEnums.Name = "comboBoxEnums";
            this.comboBoxEnums.Size = new System.Drawing.Size(514, 23);
            this.comboBoxEnums.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Перелічення:";
            // 
            // comboBoxPointer
            // 
            this.comboBoxPointer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPointer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPointer.FormattingEnabled = true;
            this.comboBoxPointer.Location = new System.Drawing.Point(102, 238);
            this.comboBoxPointer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxPointer.Name = "comboBoxPointer";
            this.comboBoxPointer.Size = new System.Drawing.Size(514, 23);
            this.comboBoxPointer.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Вказівник:";
            // 
            // comboBoxFieldType
            // 
            this.comboBoxFieldType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFieldType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFieldType.FormattingEnabled = true;
            this.comboBoxFieldType.Location = new System.Drawing.Point(102, 205);
            this.comboBoxFieldType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxFieldType.Name = "comboBoxFieldType";
            this.comboBoxFieldType.Size = new System.Drawing.Size(514, 23);
            this.comboBoxFieldType.TabIndex = 33;
            this.comboBoxFieldType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFieldType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Назва:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(102, 35);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(513, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Опис:";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDesc.Location = new System.Drawing.Point(102, 126);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(513, 72);
            this.textBoxDesc.TabIndex = 32;
            // 
            // ConstantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConstantsForm";
            this.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Константа";
            this.Load += new System.EventHandler(this.FieldForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnumFieldForm_KeyDown);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button buttonAddTablePart;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ListBox listBoxTabularParts;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxNameInTable;
		private System.Windows.Forms.ComboBox comboBoxBlock;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxEnums;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxPointer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxFieldType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxDesc;
	}
}