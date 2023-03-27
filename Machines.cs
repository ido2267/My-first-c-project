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
    public partial class Machines : UserControl
    {
        List<HandleMachines> machines = new List<HandleMachines>();
        public Machines()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            MachinesBox.DataSource = machines;
            MachinesBox.DisplayMember = "FullInfo";
        }

        private void SearchMachinesButton_Click(object sender, EventArgs e)
        {
            SearchMachines db = new SearchMachines();

            machines = db.GetMachines(MachineNames.Text);
            UpdateBinding();
        }

        private void Machines_Load(object sender, EventArgs e)
        {

        }

        private void InsertParts_Click(object sender, EventArgs e)
        {
            SearchMachines db = new SearchMachines();

            db.InsertMachines(IdBox.Text, DateBox.Text, UserNumBox.Text, lnCdBox.Text, NameBox.Text);
            IdBox.Text = "";
            DateBox.Text = "";
            UserNumBox.Text = "";
            lnCdBox.Text = "";
            NameBox.Text = "";
        }
    }
}

