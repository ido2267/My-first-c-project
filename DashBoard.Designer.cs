namespace Magma3
{
    partial class DashBoard
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
            this.PartsBox = new System.Windows.Forms.ListBox();
            this.PartNames = new System.Windows.Forms.TextBox();
            this.PartNamesLabel = new System.Windows.Forms.Label();
            this.SearchPartsButton = new System.Windows.Forms.Button();
            this.IdNumLabel = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.UserNumLabel = new System.Windows.Forms.Label();
            this.UserNumBox = new System.Windows.Forms.TextBox();
            this.LangCodeLabel = new System.Windows.Forms.Label();
            this.lnCdBox = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.InsertParts = new System.Windows.Forms.Button();
            this.DateExplanlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PartsBox
            // 
            this.PartsBox.FormattingEnabled = true;
            this.PartsBox.ItemHeight = 20;
            this.PartsBox.Location = new System.Drawing.Point(63, 82);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(581, 84);
            this.PartsBox.TabIndex = 0;
            // 
            // PartNames
            // 
            this.PartNames.Location = new System.Drawing.Point(158, 10);
            this.PartNames.Name = "PartNames";
            this.PartNames.Size = new System.Drawing.Size(232, 26);
            this.PartNames.TabIndex = 1;
            // 
            // PartNamesLabel
            // 
            this.PartNamesLabel.AutoSize = true;
            this.PartNamesLabel.Location = new System.Drawing.Point(59, 10);
            this.PartNamesLabel.Name = "PartNamesLabel";
            this.PartNamesLabel.Size = new System.Drawing.Size(92, 20);
            this.PartNamesLabel.TabIndex = 2;
            this.PartNamesLabel.Text = "Part Names";
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Location = new System.Drawing.Point(63, 42);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(119, 30);
            this.SearchPartsButton.TabIndex = 3;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // IdNumLabel
            // 
            this.IdNumLabel.AutoSize = true;
            this.IdNumLabel.Location = new System.Drawing.Point(43, 206);
            this.IdNumLabel.Name = "IdNumLabel";
            this.IdNumLabel.Size = new System.Drawing.Size(23, 20);
            this.IdNumLabel.TabIndex = 5;
            this.IdNumLabel.Text = "Id";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(205, 209);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(239, 26);
            this.IdBox.TabIndex = 4;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(43, 238);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(108, 20);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "Creation Date";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(205, 241);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(239, 26);
            this.DateBox.TabIndex = 6;
            // 
            // UserNumLabel
            // 
            this.UserNumLabel.AutoSize = true;
            this.UserNumLabel.Location = new System.Drawing.Point(43, 270);
            this.UserNumLabel.Name = "UserNumLabel";
            this.UserNumLabel.Size = new System.Drawing.Size(103, 20);
            this.UserNumLabel.TabIndex = 9;
            this.UserNumLabel.Text = "User Number";
            // 
            // UserNumBox
            // 
            this.UserNumBox.Location = new System.Drawing.Point(205, 273);
            this.UserNumBox.Name = "UserNumBox";
            this.UserNumBox.Size = new System.Drawing.Size(239, 26);
            this.UserNumBox.TabIndex = 8;
            // 
            // LangCodeLabel
            // 
            this.LangCodeLabel.AutoSize = true;
            this.LangCodeLabel.Location = new System.Drawing.Point(43, 308);
            this.LangCodeLabel.Name = "LangCodeLabel";
            this.LangCodeLabel.Size = new System.Drawing.Size(123, 20);
            this.LangCodeLabel.TabIndex = 11;
            this.LangCodeLabel.Text = "Language Code";
            // 
            // lnCdBox
            // 
            this.lnCdBox.Location = new System.Drawing.Point(205, 305);
            this.lnCdBox.Name = "lnCdBox";
            this.lnCdBox.Size = new System.Drawing.Size(239, 26);
            this.lnCdBox.TabIndex = 10;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(43, 347);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(89, 20);
            this.DescLabel.TabIndex = 13;
            this.DescLabel.Text = "Description";
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(205, 350);
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(239, 26);
            this.DescBox.TabIndex = 12;
            // 
            // InsertParts
            // 
            this.InsertParts.Location = new System.Drawing.Point(205, 394);
            this.InsertParts.Name = "InsertParts";
            this.InsertParts.Size = new System.Drawing.Size(119, 30);
            this.InsertParts.TabIndex = 14;
            this.InsertParts.Text = "Insert";
            this.InsertParts.UseVisualStyleBackColor = true;
            this.InsertParts.Click += new System.EventHandler(this.InsertParts_Click);
            // 
            // DateExplanlabel
            // 
            this.DateExplanlabel.AutoSize = true;
            this.DateExplanlabel.Location = new System.Drawing.Point(472, 241);
            this.DateExplanlabel.Name = "DateExplanlabel";
            this.DateExplanlabel.Size = new System.Drawing.Size(124, 20);
            this.DateExplanlabel.TabIndex = 15;
            this.DateExplanlabel.Text = "Month/Day/Year";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.DateExplanlabel);
            this.Controls.Add(this.InsertParts);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.DescBox);
            this.Controls.Add(this.LangCodeLabel);
            this.Controls.Add(this.lnCdBox);
            this.Controls.Add(this.UserNumLabel);
            this.Controls.Add(this.UserNumBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.IdNumLabel);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.SearchPartsButton);
            this.Controls.Add(this.PartNamesLabel);
            this.Controls.Add(this.PartNames);
            this.Controls.Add(this.PartsBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoard";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PartsBox;
        private System.Windows.Forms.TextBox PartNames;
        private System.Windows.Forms.Label PartNamesLabel;
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.Label IdNumLabel;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label UserNumLabel;
        private System.Windows.Forms.TextBox UserNumBox;
        private System.Windows.Forms.Label LangCodeLabel;
        private System.Windows.Forms.TextBox lnCdBox;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.Button InsertParts;
        private System.Windows.Forms.Label DateExplanlabel;
    }
}

