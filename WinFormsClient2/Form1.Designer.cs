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
            this.listBoxViewAllInformation = new System.Windows.Forms.ListBox();
            this.buttonViewInformationSelect = new System.Windows.Forms.Button();
            this.comboBoxViewInformation = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxICA = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxICA)).BeginInit();
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
            this.tabPage1.Controls.Add(this.listBoxViewAllInformation);
            this.tabPage1.Controls.Add(this.buttonViewInformationSelect);
            this.tabPage1.Controls.Add(this.comboBoxViewInformation);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBoxICA);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxViewAllInformation
            // 
            this.listBoxViewAllInformation.FormattingEnabled = true;
            this.listBoxViewAllInformation.ItemHeight = 15;
            this.listBoxViewAllInformation.Location = new System.Drawing.Point(125, 104);
            this.listBoxViewAllInformation.Name = "listBoxViewAllInformation";
            this.listBoxViewAllInformation.Size = new System.Drawing.Size(492, 139);
            this.listBoxViewAllInformation.TabIndex = 7;
            // 
            // buttonViewInformationSelect
            // 
            this.buttonViewInformationSelect.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonViewInformationSelect.Location = new System.Drawing.Point(222, 327);
            this.buttonViewInformationSelect.Name = "buttonViewInformationSelect";
            this.buttonViewInformationSelect.Size = new System.Drawing.Size(293, 47);
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
            this.comboBoxViewInformation.Location = new System.Drawing.Point(125, 274);
            this.comboBoxViewInformation.Name = "comboBoxViewInformation";
            this.comboBoxViewInformation.Size = new System.Drawing.Size(492, 23);
            this.comboBoxViewInformation.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Location = new System.Drawing.Point(282, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 43);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Supermarket Web Service Manager";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBoxViewInformation;
        private TextBox textBox1;
        private PictureBox pictureBoxICA;
        private TabPage tabPage2;
        private Button buttonViewInformationSelect;
        private ListBox listBoxViewAllInformation;
    }
}