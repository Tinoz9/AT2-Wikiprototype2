namespace WikiPrototype
{
    partial class Form1
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
            this.cataBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.strucBox = new System.Windows.Forms.TextBox();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.statStrip.SuspendLayout();
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
            // cataBox
            // 
            this.cataBox.Location = new System.Drawing.Point(73, 134);
            this.cataBox.Name = "cataBox";
            this.cataBox.Size = new System.Drawing.Size(204, 23);
            this.cataBox.TabIndex = 11;
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
            // strucBox
            // 
            this.strucBox.Location = new System.Drawing.Point(73, 192);
            this.strucBox.Name = "strucBox";
            this.strucBox.Size = new System.Drawing.Size(204, 23);
            this.strucBox.TabIndex = 14;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(146, 105);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(153, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seaBox);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.defBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.strucBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cataBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.seaBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.ediBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
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
        private TextBox cataBox;
        private Label label2;
        private Label label3;
        private TextBox strucBox;
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
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}