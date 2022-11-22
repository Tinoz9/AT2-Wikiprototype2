namespace WikiPrototype
{
    partial class WikiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.ediBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.seaBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.defBox = new System.Windows.Forms.TextBox();
            this.statBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.viewBox = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colCatagory = new System.Windows.Forms.ColumnHeader();
            this.seaBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.statStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LinBtn = new System.Windows.Forms.RadioButton();
            this.NLinBtn = new System.Windows.Forms.RadioButton();
            this.CataCCombo = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.statStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(318, 75);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ediBtn
            // 
            this.ediBtn.Location = new System.Drawing.Point(318, 105);
            this.ediBtn.Name = "ediBtn";
            this.ediBtn.Size = new System.Drawing.Size(75, 23);
            this.ediBtn.TabIndex = 2;
            this.ediBtn.Text = "Edit";
            this.ediBtn.UseVisualStyleBackColor = true;
            this.ediBtn.Click += new System.EventHandler(this.ediBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(318, 134);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 3;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // seaBtn
            // 
            this.seaBtn.Location = new System.Drawing.Point(318, 192);
            this.seaBtn.Name = "seaBtn";
            this.seaBtn.Size = new System.Drawing.Size(75, 23);
            this.seaBtn.TabIndex = 4;
            this.seaBtn.Text = "Search";
            this.seaBtn.UseVisualStyleBackColor = true;
            this.seaBtn.Click += new System.EventHandler(this.seaBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(318, 221);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(318, 250);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 8;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(73, 76);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(204, 23);
            this.nameBox.TabIndex = 9;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            this.nameBox.DoubleClick += new System.EventHandler(this.nameDClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Catagory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Structure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Definition";
            // 
            // defBox
            // 
            this.defBox.Location = new System.Drawing.Point(73, 250);
            this.defBox.Multiline = true;
            this.defBox.Name = "defBox";
            this.defBox.Size = new System.Drawing.Size(204, 87);
            this.defBox.TabIndex = 16;
            // 
            // statBox
            // 
            this.statBox.Location = new System.Drawing.Point(73, 392);
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(320, 23);
            this.statBox.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // viewBox
            // 
            this.viewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCatagory});
            this.viewBox.FullRowSelect = true;
            this.viewBox.GridLines = true;
            this.viewBox.Location = new System.Drawing.Point(487, 104);
            this.viewBox.MultiSelect = false;
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(204, 262);
            this.viewBox.TabIndex = 18;
            this.viewBox.UseCompatibleStateImageBehavior = false;
            this.viewBox.View = System.Windows.Forms.View.Details;
            this.viewBox.SelectedIndexChanged += new System.EventHandler(this.viewBox_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 100;
            // 
            // colCatagory
            // 
            this.colCatagory.Text = "Catagory";
            this.colCatagory.Width = 100;
            // 
            // seaBox
            // 
            this.seaBox.Location = new System.Drawing.Point(487, 75);
            this.seaBox.Name = "seaBox";
            this.seaBox.Size = new System.Drawing.Size(204, 23);
            this.seaBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Search Box";
            // 
            // statStrip
            // 
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statStripLabel});
            this.statStrip.Location = new System.Drawing.Point(0, 428);
            this.statStrip.Name = "statStrip";
            this.statStrip.Size = new System.Drawing.Size(800, 22);
            this.statStrip.TabIndex = 21;
            this.statStrip.Text = "statusStrip1";
            // 
            // statStripLabel
            // 
            this.statStripLabel.AutoToolTip = true;
            this.statStripLabel.Name = "statStripLabel";
            this.statStripLabel.Size = new System.Drawing.Size(785, 17);
            this.statStripLabel.Spring = true;
            this.statStripLabel.Text = "toolStripStatusLabel1";
            // 
            // LinBtn
            // 
            this.LinBtn.AutoSize = true;
            this.LinBtn.Location = new System.Drawing.Point(6, 14);
            this.LinBtn.Name = "LinBtn";
            this.LinBtn.Size = new System.Drawing.Size(57, 19);
            this.LinBtn.TabIndex = 23;
            this.LinBtn.TabStop = true;
            this.LinBtn.Text = "Linear";
            this.LinBtn.UseVisualStyleBackColor = true;
            this.LinBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NLinBtn
            // 
            this.NLinBtn.AutoSize = true;
            this.NLinBtn.Location = new System.Drawing.Point(111, 14);
            this.NLinBtn.Name = "NLinBtn";
            this.NLinBtn.Size = new System.Drawing.Size(83, 19);
            this.NLinBtn.TabIndex = 24;
            this.NLinBtn.TabStop = true;
            this.NLinBtn.Text = "Non Linear";
            this.NLinBtn.UseVisualStyleBackColor = true;
            this.NLinBtn.CheckedChanged += new System.EventHandler(this.NLinBtn_CheckedChanged);
            // 
            // CataCCombo
            // 
            this.CataCCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CataCCombo.FormattingEnabled = true;
            this.CataCCombo.Location = new System.Drawing.Point(73, 134);
            this.CataCCombo.Name = "CataCCombo";
            this.CataCCombo.Size = new System.Drawing.Size(204, 23);
            this.CataCCombo.TabIndex = 25;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.LinBtn);
            this.groupBox.Controls.Add(this.NLinBtn);
            this.groupBox.Location = new System.Drawing.Point(77, 183);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 39);
            this.groupBox.TabIndex = 26;
            this.groupBox.TabStop = false;
            // 
            // WikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.CataCCombo);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seaBox);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.defBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.seaBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.ediBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "WikiForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WikiForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addBtn;
        private Button ediBtn;
        private Button delBtn;
        private Button seaBtn;
        private Button saveBtn;
        private Button openBtn;
        private TextBox nameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox defBox;
        private TextBox statBox;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ListView viewBox;
        private ColumnHeader colName;
        private ColumnHeader colCatagory;
        private TextBox seaBox;
        private Label label5;
        private StatusStrip statStrip;
        private ToolStripStatusLabel statStripLabel;
        private RadioButton LinBtn;
        private RadioButton NLinBtn;
        private ComboBox CataCCombo;
        private GroupBox groupBox;
    }
}