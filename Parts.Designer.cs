namespace WindowsFormsApp1
{
    partial class Parts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PartNames = new System.Windows.Forms.TextBox();
            this.PartNamesLabel = new System.Windows.Forms.Label();
            this.SearchPartsButton = new System.Windows.Forms.Button();
            this.PartsBox = new System.Windows.Forms.ListBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.UserNumBox = new System.Windows.Forms.TextBox();
            this.lnCdBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartNames
            // 
            this.PartNames.Location = new System.Drawing.Point(154, 29);
            this.PartNames.Name = "PartNames";
            this.PartNames.Size = new System.Drawing.Size(228, 20);
            this.PartNames.TabIndex = 0;
            // 
            // PartNamesLabel
            // 
            this.PartNamesLabel.AutoSize = true;
            this.PartNamesLabel.Location = new System.Drawing.Point(44, 36);
            this.PartNamesLabel.Name = "PartNamesLabel";
            this.PartNamesLabel.Size = new System.Drawing.Size(82, 13);
            this.PartNamesLabel.TabIndex = 1;
            this.PartNamesLabel.Text = "Part Description";
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Location = new System.Drawing.Point(154, 68);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(75, 23);
            this.SearchPartsButton.TabIndex = 2;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // PartsBox
            // 
            this.PartsBox.FormattingEnabled = true;
            this.PartsBox.Location = new System.Drawing.Point(154, 108);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(395, 95);
            this.PartsBox.TabIndex = 3;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(154, 234);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(55, 20);
            this.IdBox.TabIndex = 4;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(154, 260);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(106, 20);
            this.DateBox.TabIndex = 5;
            // 
            // UserNumBox
            // 
            this.UserNumBox.Location = new System.Drawing.Point(154, 286);
            this.UserNumBox.Name = "UserNumBox";
            this.UserNumBox.Size = new System.Drawing.Size(55, 20);
            this.UserNumBox.TabIndex = 6;
            // 
            // lnCdBox
            // 
            this.lnCdBox.Location = new System.Drawing.Point(154, 316);
            this.lnCdBox.Name = "lnCdBox";
            this.lnCdBox.Size = new System.Drawing.Size(55, 20);
            this.lnCdBox.TabIndex = 7;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(154, 349);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(228, 20);
            this.DescBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Creation Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Month/Day?year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "User Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "language Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Description";
            // 
            // InsertParts
            // 
            this.InsertParts.Location = new System.Drawing.Point(154, 375);
            this.InsertParts.Name = "InsertParts";
            this.InsertParts.Size = new System.Drawing.Size(75, 23);
            this.InsertParts.TabIndex = 15;
            this.InsertParts.Text = "Insert";
            this.InsertParts.UseVisualStyleBackColor = true;
            this.InsertParts.Click += new System.EventHandler(this.InsertParts_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.InsertParts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.lnCdBox);
            this.Controls.Add(this.UserNumBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.PartsBox);
            this.Controls.Add(this.SearchPartsButton);
            this.Controls.Add(this.PartNamesLabel);
            this.Controls.Add(this.PartNames);
            this.Name = "Parts";
            this.Size = new System.Drawing.Size(691, 411);
            this.Load += new System.EventHandler(this.Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PartNames;
        private System.Windows.Forms.Label PartNamesLabel;
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.ListBox PartsBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox UserNumBox;
        private System.Windows.Forms.TextBox lnCdBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertParts;
    }
}
