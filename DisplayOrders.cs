using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DisplayOrders: DisplayItems
    {
        public int order_id { get; set; }
       
        public int amount { get; set; }
        public string machine_name { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public string user_name { get; set; }

        public string FullInfo
        {
            get
            {
                return $" {order_id} {creation_date} {language} {user_name}  {description} {machine_name} {amount}";
            }
        }
    }
}
