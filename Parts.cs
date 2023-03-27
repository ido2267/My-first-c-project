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
    public partial class Parts : UserControl
    {
        List<HandleParts> parts = new List<HandleParts>();
        public Parts()
        {
            InitializeComponent();
            UpdateBinding();
        }
        private void UpdateBinding()
        {
            PartsBox.DataSource = parts;
            PartsBox.DisplayMember = "FullInfo";
        }

        private void SearchPartsButton_Click(object sender, EventArgs e)
        {
            SearchParts db = new SearchParts();

            parts = db.GetParts(PartNames.Text);
            UpdateBinding();
        }

        private void InsertParts_Click(object sender, EventArgs e)
        {
            SearchParts db = new SearchParts();

            db.InsertParts(IdBox.Text, DateBox.Text, UserNumBox.Text, lnCdBox.Text, DescBox.Text);
            IdBox.Text = "";
            DateBox.Text = "";
            UserNumBox.Text = "";
            lnCdBox.Text = "";
            DescBox.Text = "";

        }
    }
}
