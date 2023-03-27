using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class HandleParts: Items
    {
        public int id { get; set; }
        public string description { get; set; }

        public string FullInfo
        {
            get
            {
                return $" {description} {id} {user_number} {lang_code} {creation_date} ";
            }
        }
    }
}
