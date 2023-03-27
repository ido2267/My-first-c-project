using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Magma : Form
    {
        public Magma()
        {
            InitializeComponent();
        }

        private void PartsButton_Click(object sender, EventArgs e)
        {
            workOrders1.Hide();
            machines1.Hide();
            parts1.Show();
            parts1.BringToFront();
        }

        private void Machines_Click(object sender, EventArgs e)
        {
            workOrders1.Hide();
            parts1.Hide();
            machines1.Show();
            machines1.BringToFront();
        }

        private void WorkOrders_Click(object sender, EventArgs e)
        {
            
            parts1.Hide();
            machines1.Hide();
            workOrders1.Show();
            workOrders1.BringToFront();
        }
    }
}
