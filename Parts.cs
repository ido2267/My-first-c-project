using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magma3
{
    internal class HandleParts
    {
        public int id { get; set; }
        public DateTime creation_date { get; set; }
        public int user_number { get; set; }
        public int lang_code { get; set; }
        public string description { get; set; }

        public string  FullInfo { 
          get
            {
               return  $" {description} { id} { user_number} { lang_code} ";
            }
        }
    }
}
