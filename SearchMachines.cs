using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class SearchMachines
    {
        public List<HandleMachines> GetMachines(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
                //   var output =  connection.Query<HandleMachines>($"select description,id,user_number,lang_code from Machine where description = '{Description}' ").ToList();
                var output = connection.Query<HandleMachines>("DBO.Machine_GetByDescription @name", new { name = Name }).ToList();
                return output;
            }

        }

        internal void InsertMachines(  string User_number, string LangCode, string Name)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
                InsertMachines NewMachine = new InsertMachines();
               
                NewMachine.lang_code = Int32.Parse(LangCode);
                NewMachine.user_number = Int32.Parse(User_number);
                NewMachine.name = Name;
                List<InsertMachines> machines = new List<InsertMachines>();
                machines.Add(NewMachine);
                connection.Execute("dbo.Machines_Insert @user_number,@lang_code,@name", machines);

            }
        }
    }

}
