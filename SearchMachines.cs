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
        public List<DisplayMachines> GetMachines(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
                 //  var output = connection.Query<HandleMachines>("DBO.Machine_GetByDescription2 @machine_name", new { machine_name = Name }).ToList();
                var output = connection.Query<DisplayMachines>("DBO.Machine_GetByDescription2 @machine_name", new { machine_name = Name }).ToList();
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
                NewMachine.machine_name = Name;
                List<InsertMachines> machines = new List<InsertMachines>();
                machines.Add(NewMachine);
                connection.Execute("dbo.Machines_Insert @user_number,@lang_code,@machine_name", machines);

            }
        }
    }

}
