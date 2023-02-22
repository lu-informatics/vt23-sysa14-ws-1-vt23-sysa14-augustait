namespace WinFormsClient2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxViewAllInformation = new System.Windows.Forms.ListBox();
            this.buttonViewInformationSelect = new System.Windows.Forms.Button();
            this.comboBoxViewInformation = new System.Windows.Forms.ComboBox();
            this.pictureBoxICA = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSelectFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxICA)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-7, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 457);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBoxViewAllInformation);
            this.tabPage1.Controls.Add(this.buttonViewInformationSelect);
            this.tabPage1.Controls.Add(this.comboBoxViewInformation);
            this.tabPage1.Controls.Add(this.pictureBoxICA);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(276, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select a web service to call";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Supermarket Web Service Manager";
            // 
            // listBoxViewAllInformation
            // 
            this.listBoxViewAllInformation.FormattingEnabled = true;
            this.listBoxViewAllInformation.ItemHeight = 15;
            this.listBoxViewAllInformation.Location = new System.Drawing.Point(15, 104);
            this.listBoxViewAllInformation.Name = "listBoxViewAllInformation";
            this.listBoxViewAllInformation.Size = new System.Drawing.Size(776, 139);
            this.listBoxViewAllInformation.TabIndex = 7;
            // 
            // buttonViewInformationSelect
            // 
            this.buttonViewInformationSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonViewInformationSelect.Location = new System.Drawing.Point(222, 345);
            this.buttonViewInformationSelect.Name = "buttonViewInformationSelect";
            this.buttonViewInformationSelect.Size = new System.Drawing.Size(293, 29);
            this.buttonViewInformationSelect.TabIndex = 5;
            this.buttonViewInformationSelect.Text = "SELECT";
            this.buttonViewInformationSelect.UseVisualStyleBackColor = true;
            this.buttonViewInformationSelect.Click += new System.EventHandler(this.buttonViewInformationSelect_Click);
            // 
            // comboBoxViewInformation
            // 
            this.comboBoxViewInformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewInformation.FormattingEnabled = true;
            this.comboBoxViewInformation.Items.AddRange(new object[] {
            "Product Category",
            "Products",
            "Customers",
            "Stores",
            "Orders"});
            this.comboBoxViewInformation.Location = new System.Drawing.Point(125, 304);
            this.comboBoxViewInformation.Name = "comboBoxViewInformation";
            this.comboBoxViewInformation.Size = new System.Drawing.Size(492, 23);
            this.comboBoxViewInformation.TabIndex = 4;
            // 
            // pictureBoxICA
            // 
            this.pictureBoxICA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxICA.Image")));
            this.pictureBoxICA.Location = new System.Drawing.Point(113, 3);
            this.pictureBoxICA.Name = "pictureBoxICA";
            this.pictureBoxICA.Size = new System.Drawing.Size(163, 81);
            this.pictureBoxICA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxICA.TabIndex = 2;
            this.pictureBoxICA.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.buttonSelectFind);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 111);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 155);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // buttonSelectFind
            // 
            this.buttonSelectFind.Location = new System.Drawing.Point(342, 383);
            this.buttonSelectFind.Name = "buttonSelectFind";
            this.buttonSelectFind.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFind.TabIndex = 15;
            this.buttonSelectFind.Text = "SELECT";
            this.buttonSelectFind.UseVisualStyleBackColor = true;
            this.buttonSelectFind.Click += new System.EventHandler(this.buttonSelectFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(219, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter an ID for Order, Customer or Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(284, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select a web service to call";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(271, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Supermarket Web Service Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Get orders for customer id",
            "Get orderlines from order id",
            "Get products from category id"});
            this.comboBox1.Location = new System.Drawing.Point(249, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 23);
            this.comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 23);
            this.textBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxICA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBoxViewInformation;
        private PictureBox pictureBoxICA;
        private TabPage tabPage2;
        private Button buttonViewInformationSelect;
        private ListBox listBoxViewAllInformation;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button buttonSelectFind;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}