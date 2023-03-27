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
    internal class SearchParts
    {
        public List<HandleParts> GetParts(string Description)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
                //   var output =  connection.Query<HandleParts>($"select description,id,user_number,lang_code from Part where description = '{Description}' ").ToList();
                var output = connection.Query<HandleParts>("DBO.Part_GetByDescription @description", new { description = Description }).ToList();
                return output;
            }

        }

        internal void InsertParts(string Id, string Creation_date, string User_number, string LangCode, string Description)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
                HandleParts NewPart = new HandleParts();
                NewPart.id = Int32.Parse(Id);
                NewPart.creation_date = Convert.ToDateTime(Creation_date);
                NewPart.lang_code = Int32.Parse(LangCode);
                NewPart.user_number = Int32.Parse(User_number);
                NewPart.description = Description;
                List<HandleParts> parts = new List<HandleParts>();
                parts.Add(NewPart);
                connection.Execute("dbo.Parts_Insert @id,@creation_date,@user_number,@lang_code,@description", parts);

            }
        }
    }
}
