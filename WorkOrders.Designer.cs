namespace WindowsFormsApp1
{
    partial class WorkOrders
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
            this.InsertParts = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnCdBox = new System.Windows.Forms.TextBox();
            this.UserNumBox = new System.Windows.Forms.TextBox();
            this.OrdersBox = new System.Windows.Forms.ListBox();
            this.SearcOrderButton = new System.Windows.Forms.Button();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.OrderNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MachineIdBox = new System.Windows.Forms.TextBox();
            this.PartIdBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsertParts
            // 
            this.InsertParts.Location = new System.Drawing.Point(221, 392);
            this.InsertParts.Name = "InsertParts";
            this.InsertParts.Size = new System.Drawing.Size(75, 23);
            this.InsertParts.TabIndex = 47;
            this.InsertParts.Text = "Insert";
            this.InsertParts.UseVisualStyleBackColor = true;
            this.InsertParts.Click += new System.EventHandler(this.InsertParts_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "language Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "User Number";
            // 
            // lnCdBox
            // 
            this.lnCdBox.Location = new System.Drawing.Point(222, 306);
            this.lnCdBox.Name = "lnCdBox";
            this.lnCdBox.Size = new System.Drawing.Size(55, 20);
            this.lnCdBox.TabIndex = 39;
            // 
            // UserNumBox
            // 
            this.UserNumBox.Location = new System.Drawing.Point(222, 276);
            this.UserNumBox.Name = "UserNumBox";
            this.UserNumBox.Size = new System.Drawing.Size(55, 20);
            this.UserNumBox.TabIndex = 38;
            // 
            // OrdersBox
            // 
            this.OrdersBox.FormattingEnabled = true;
            this.OrdersBox.Location = new System.Drawing.Point(221, 125);
            this.OrdersBox.Name = "OrdersBox";
            this.OrdersBox.Size = new System.Drawing.Size(395, 95);
            this.OrdersBox.TabIndex = 35;
            // 
            // SearcOrderButton
            // 
            this.SearcOrderButton.Location = new System.Drawing.Point(221, 85);
            this.SearcOrderButton.Name = "SearcOrderButton";
            this.SearcOrderButton.Size = new System.Drawing.Size(75, 23);
            this.SearcOrderButton.TabIndex = 34;
            this.SearcOrderButton.Text = "Search";
            this.SearcOrderButton.UseVisualStyleBackColor = true;
            this.SearcOrderButton.Click += new System.EventHandler(this.SearcOrderButton_Click);
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(111, 53);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(44, 13);
            this.OrderLabel.TabIndex = 33;
            this.OrderLabel.Text = "Order id";
            // 
            // OrderNames
            // 
            this.OrderNames.Location = new System.Drawing.Point(221, 46);
            this.OrderNames.Name = "OrderNames";
            this.OrderNames.Size = new System.Drawing.Size(228, 20);
            this.OrderNames.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Machine Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Part Id";
            // 
            // MachineIdBox
            // 
            this.MachineIdBox.Location = new System.Drawing.Point(424, 306);
            this.MachineIdBox.Name = "MachineIdBox";
            this.MachineIdBox.Size = new System.Drawing.Size(55, 20);
            this.MachineIdBox.TabIndex = 49;
            // 
            // PartIdBox
            // 
            this.PartIdBox.Location = new System.Drawing.Point(424, 276);
            this.PartIdBox.Name = "PartIdBox";
            this.PartIdBox.Size = new System.Drawing.Size(55, 20);
            this.PartIdBox.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Amount";
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(222, 332);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(55, 20);
            this.AmountBox.TabIndex = 52;
            // 
            // WorkOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MachineIdBox);
            this.Controls.Add(this.PartIdBox);
            this.Controls.Add(this.InsertParts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lnCdBox);
            this.Controls.Add(this.UserNumBox);
            this.Controls.Add(this.OrdersBox);
            this.Controls.Add(this.SearcOrderButton);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.OrderNames);
            this.Name = "WorkOrders";
            this.Size = new System.Drawing.Size(727, 460);
            this.Load += new System.EventHandler(this.WorkOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertParts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lnCdBox;
        private System.Windows.Forms.TextBox UserNumBox;
        private System.Windows.Forms.ListBox OrdersBox;
        private System.Windows.Forms.Button SearcOrderButton;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.TextBox OrderNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MachineIdBox;
        private System.Windows.Forms.TextBox PartIdBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountBox;
    }
}
