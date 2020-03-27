namespace AirportDataLookup
{
    partial class Form1
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
            this.TxtBox_CodeType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_AirportCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBox_AirportCountry = new System.Windows.Forms.TextBox();
            this.TxtBox_Region = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBox_AirportName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAirportLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requiredAPIKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.icaointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googlecomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBox_CodeType
            // 
            this.TxtBox_CodeType.FormattingEnabled = true;
            this.TxtBox_CodeType.Items.AddRange(new object[] {
            "ICAO Code",
            "IATA Code (Disabled)",
            "TC LID (Disabled)",
            "FAA LID (Disabled)"});
            this.TxtBox_CodeType.Location = new System.Drawing.Point(58, 66);
            this.TxtBox_CodeType.Name = "TxtBox_CodeType";
            this.TxtBox_CodeType.Size = new System.Drawing.Size(113, 21);
            this.TxtBox_CodeType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code:";
            // 
            // TxtBox_AirportCode
            // 
            this.TxtBox_AirportCode.Location = new System.Drawing.Point(58, 28);
            this.TxtBox_AirportCode.MaxLength = 10;
            this.TxtBox_AirportCode.Name = "TxtBox_AirportCode";
            this.TxtBox_AirportCode.Size = new System.Drawing.Size(113, 20);
            this.TxtBox_AirportCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type:";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(209, 66);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 23);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "Search";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBox_AirportCountry);
            this.groupBox1.Controls.Add(this.TxtBox_Region);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBox_AirportName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Google Maps Image";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 135);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Country Code And Name:";
            // 
            // TxtBox_AirportCountry
            // 
            this.TxtBox_AirportCountry.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBox_AirportCountry.Location = new System.Drawing.Point(98, 120);
            this.TxtBox_AirportCountry.Name = "TxtBox_AirportCountry";
            this.TxtBox_AirportCountry.Size = new System.Drawing.Size(174, 20);
            this.TxtBox_AirportCountry.TabIndex = 5;
            this.TxtBox_AirportCountry.TabStop = false;
            // 
            // TxtBox_Region
            // 
            this.TxtBox_Region.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBox_Region.Location = new System.Drawing.Point(6, 120);
            this.TxtBox_Region.Name = "TxtBox_Region";
            this.TxtBox_Region.Size = new System.Drawing.Size(44, 20);
            this.TxtBox_Region.TabIndex = 4;
            this.TxtBox_Region.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location and Codes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Region:";
            // 
            // TxtBox_AirportName
            // 
            this.TxtBox_AirportName.BackColor = System.Drawing.SystemColors.Control;
            this.TxtBox_AirportName.Location = new System.Drawing.Point(98, 34);
            this.TxtBox_AirportName.Multiline = true;
            this.TxtBox_AirportName.Name = "TxtBox_AirportName";
            this.TxtBox_AirportName.Size = new System.Drawing.Size(174, 67);
            this.TxtBox_AirportName.TabIndex = 1;
            this.TxtBox_AirportName.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAirportLookupToolStripMenuItem,
            this.requiredAPIKeysToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutAirportLookupToolStripMenuItem
            // 
            this.aboutAirportLookupToolStripMenuItem.Name = "aboutAirportLookupToolStripMenuItem";
            this.aboutAirportLookupToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutAirportLookupToolStripMenuItem.Text = "About Airport Lookup";
            this.aboutAirportLookupToolStripMenuItem.Click += new System.EventHandler(this.aboutAirportLookupToolStripMenuItem_Click);
            // 
            // requiredAPIKeysToolStripMenuItem
            // 
            this.requiredAPIKeysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.icaointToolStripMenuItem,
            this.googlecomToolStripMenuItem});
            this.requiredAPIKeysToolStripMenuItem.Name = "requiredAPIKeysToolStripMenuItem";
            this.requiredAPIKeysToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.requiredAPIKeysToolStripMenuItem.Text = "Required API Keys";
            // 
            // icaointToolStripMenuItem
            // 
            this.icaointToolStripMenuItem.Name = "icaointToolStripMenuItem";
            this.icaointToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.icaointToolStripMenuItem.Text = "icao.int";
            // 
            // googlecomToolStripMenuItem
            // 
            this.googlecomToolStripMenuItem.Name = "googlecomToolStripMenuItem";
            this.googlecomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.googlecomToolStripMenuItem.Text = "Google Maps Static";
            // 
            // Form1
            // 
            this.AcceptButton = this.Btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBox_AirportCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBox_CodeType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Airport Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TxtBox_CodeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_AirportCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAirportLookupToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBox_AirportCountry;
        private System.Windows.Forms.TextBox TxtBox_Region;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBox_AirportName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem requiredAPIKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem icaointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googlecomToolStripMenuItem;
    }
}

