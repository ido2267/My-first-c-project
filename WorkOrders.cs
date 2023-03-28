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
    public partial class WorkOrders : UserControl
    {
        List<HandleOrders> Orders = new List<HandleOrders>();
        public WorkOrders()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            OrdersBox.DataSource = Orders;
            OrdersBox.DisplayMember = "FullInfo";
        }


        private void WorkOrders_Load(object sender, EventArgs e)
        {

        }

        private void SearcOrderButton_Click(object sender, EventArgs e)
        {
            SearchOrders db = new SearchOrders();

            Orders = db.GetOrders(OrderNames.Text);
            UpdateBinding();
        }

        private void InsertParts_Click(object sender, EventArgs e)
        {
            SearchOrders db = new SearchOrders();

            db.InsertOrders( UserNumBox.Text, lnCdBox.Text, PartIdBox.Text, MachineIdBox.Text, AmountBox.Text);
           
            PartIdBox.Text = "";
            UserNumBox.Text = "";
            lnCdBox.Text = "";
            AmountBox.Text = "";
            MachineIdBox.Text = "";
        }
    }
}
