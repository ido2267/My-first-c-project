using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class HandleMachines: Items
    {
        public int id { get; set; }
        public string name { get; set; }

        public string FullInfo
        {
            get
            {
                return $" {name} {id} {user_number} {lang_code}  ";
            }
        }
    }
}
