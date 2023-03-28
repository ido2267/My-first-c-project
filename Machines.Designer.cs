namespace WindowsFormsApp1
{
    partial class Machines
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.lnCdBox = new System.Windows.Forms.TextBox();
            this.UserNumBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.MachinesBox = new System.Windows.Forms.ListBox();
            this.SearchMachinesButton = new System.Windows.Forms.Button();
            this.MachineNamelabel = new System.Windows.Forms.Label();
            this.MachineNames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsertParts
            // 
            this.InsertParts.Location = new System.Drawing.Point(219, 353);
            this.InsertParts.Name = "InsertParts";
            this.InsertParts.Size = new System.Drawing.Size(75, 23);
            this.InsertParts.TabIndex = 31;
            this.InsertParts.Text = "Insert";
            this.InsertParts.UseVisualStyleBackColor = true;
            this.InsertParts.Click += new System.EventHandler(this.InsertParts_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "language Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "User Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Id";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(219, 327);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(228, 20);
            this.NameBox.TabIndex = 24;
            // 
            // lnCdBox
            // 
            this.lnCdBox.Location = new System.Drawing.Point(219, 294);
            this.lnCdBox.Name = "lnCdBox";
            this.lnCdBox.Size = new System.Drawing.Size(55, 20);
            this.lnCdBox.TabIndex = 23;
            // 
            // UserNumBox
            // 
            this.UserNumBox.Location = new System.Drawing.Point(219, 264);
            this.UserNumBox.Name = "UserNumBox";
            this.UserNumBox.Size = new System.Drawing.Size(55, 20);
            this.UserNumBox.TabIndex = 22;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(219, 238);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(55, 20);
            this.IdBox.TabIndex = 20;
            // 
            // MachinesBox
            // 
            this.MachinesBox.FormattingEnabled = true;
            this.MachinesBox.Location = new System.Drawing.Point(219, 112);
            this.MachinesBox.Name = "MachinesBox";
            this.MachinesBox.Size = new System.Drawing.Size(395, 95);
            this.MachinesBox.TabIndex = 19;
            // 
            // SearchMachinesButton
            // 
            this.SearchMachinesButton.Location = new System.Drawing.Point(219, 72);
            this.SearchMachinesButton.Name = "SearchMachinesButton";
            this.SearchMachinesButton.Size = new System.Drawing.Size(75, 23);
            this.SearchMachinesButton.TabIndex = 18;
            this.SearchMachinesButton.Text = "Search";
            this.SearchMachinesButton.UseVisualStyleBackColor = true;
            this.SearchMachinesButton.Click += new System.EventHandler(this.SearchMachinesButton_Click);
            // 
            // MachineNamelabel
            // 
            this.MachineNamelabel.AutoSize = true;
            this.MachineNamelabel.Location = new System.Drawing.Point(109, 40);
            this.MachineNamelabel.Name = "MachineNamelabel";
            this.MachineNamelabel.Size = new System.Drawing.Size(79, 13);
            this.MachineNamelabel.TabIndex = 17;
            this.MachineNamelabel.Text = "Machine Name";
            // 
            // MachineNames
            // 
            this.MachineNames.Location = new System.Drawing.Point(219, 33);
            this.MachineNames.Name = "MachineNames";
            this.MachineNames.Size = new System.Drawing.Size(228, 20);
            this.MachineNames.TabIndex = 16;
            // 
            // Machines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.InsertParts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.lnCdBox);
            this.Controls.Add(this.UserNumBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.MachinesBox);
            this.Controls.Add(this.SearchMachinesButton);
            this.Controls.Add(this.MachineNamelabel);
            this.Controls.Add(this.MachineNames);
            this.Name = "Machines";
            this.Size = new System.Drawing.Size(722, 434);
            this.Load += new System.EventHandler(this.Machines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertParts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox lnCdBox;
        private System.Windows.Forms.TextBox UserNumBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.ListBox MachinesBox;
        private System.Windows.Forms.Button SearchMachinesButton;
        private System.Windows.Forms.Label MachineNamelabel;
        private System.Windows.Forms.TextBox MachineNames;
    }
}
