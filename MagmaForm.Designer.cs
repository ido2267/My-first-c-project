namespace WindowsFormsApp1
{
    partial class Magma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Machines = new System.Windows.Forms.Button();
            this.WorkOrders = new System.Windows.Forms.Button();
            this.PartsButton = new System.Windows.Forms.Button();
            this.machines1 = new WindowsFormsApp1.Machines();
            this.parts1 = new WindowsFormsApp1.Parts();
            this.workOrders1 = new WindowsFormsApp1.WorkOrders();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Machines);
            this.panel1.Controls.Add(this.WorkOrders);
            this.panel1.Controls.Add(this.PartsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 450);
            this.panel1.TabIndex = 0;
            // 
            // Machines
            // 
            this.Machines.Location = new System.Drawing.Point(23, 138);
            this.Machines.Name = "Machines";
            this.Machines.Size = new System.Drawing.Size(75, 23);
            this.Machines.TabIndex = 2;
            this.Machines.Text = "Machines";
            this.Machines.UseVisualStyleBackColor = true;
            this.Machines.Click += new System.EventHandler(this.Machines_Click);
            // 
            // WorkOrders
            // 
            this.WorkOrders.Location = new System.Drawing.Point(23, 214);
            this.WorkOrders.Name = "WorkOrders";
            this.WorkOrders.Size = new System.Drawing.Size(75, 23);
            this.WorkOrders.TabIndex = 1;
            this.WorkOrders.Text = "Work Orders";
            this.WorkOrders.UseVisualStyleBackColor = true;
            this.WorkOrders.Click += new System.EventHandler(this.WorkOrders_Click);
            // 
            // PartsButton
            // 
            this.PartsButton.Location = new System.Drawing.Point(23, 79);
            this.PartsButton.Name = "PartsButton";
            this.PartsButton.Size = new System.Drawing.Size(75, 23);
            this.PartsButton.TabIndex = 0;
            this.PartsButton.Text = "Parts";
            this.PartsButton.UseVisualStyleBackColor = true;
            this.PartsButton.Click += new System.EventHandler(this.PartsButton_Click);
            // 
            // machines1
            // 
            this.machines1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.machines1.Location = new System.Drawing.Point(154, 0);
            this.machines1.Name = "machines1";
            this.machines1.Size = new System.Drawing.Size(917, 446);
            this.machines1.TabIndex = 1;
            // 
            // parts1
            // 
            this.parts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.parts1.Location = new System.Drawing.Point(154, 0);
            this.parts1.Name = "parts1";
            this.parts1.Size = new System.Drawing.Size(917, 446);
            this.parts1.TabIndex = 2;
            // 
            // workOrders1
            // 
            this.workOrders1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workOrders1.Location = new System.Drawing.Point(154, 0);
            this.workOrders1.Name = "workOrders1";
            this.workOrders1.Size = new System.Drawing.Size(917, 446);
            this.workOrders1.TabIndex = 3;
            // 
            // Magma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.workOrders1);
            this.Controls.Add(this.parts1);
            this.Controls.Add(this.machines1);
            this.Controls.Add(this.panel1);
            this.Name = "Magma";
            this.Text = "Magma";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Machines;
        private System.Windows.Forms.Button WorkOrders;
        private System.Windows.Forms.Button PartsButton;
        private Machines machines1;
        private Parts parts1;
        private WorkOrders workOrders1;
    }
}

