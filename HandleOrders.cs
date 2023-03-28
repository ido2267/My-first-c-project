using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class HandleOrders: Items
    {
        public int order_id { get; set; }
        public int part_id  { get; set; }
        public int machine_id { get; set; }
        public int amount { get; set; }

        public string FullInfo
        {
            get
            {
                return $" {order_id}  {user_number} {lang_code} {part_id} {machine_id} {amount}";
            }
        }
    }
}
