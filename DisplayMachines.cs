using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DisplayMachines: DisplayItems
    {
        public string machine_name { get; set; }
        public string language { get; set; }
        public string user_name { get; set; }
        public int id { get; set; }
        

        public string FullInfo
        {
            get
            {
                return $" {machine_name} {creation_date} {language} {user_name} {id}  ";
            }
        }
    }
}
