using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

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

        internal void InsertParts( string User_number, string LangCode, string Description)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
               InsertParts NewPart = new InsertParts();
               
                 //NewPart.creation_date =  DateTime.Now;
                NewPart.lang_code = Int32.Parse(LangCode);
                NewPart.user_number = Int32.Parse(User_number);
                NewPart.description = Description;
                List<InsertParts> parts = new List<InsertParts>();
                parts.Add(NewPart);
                connection.Execute("dbo.Parts_Insert @user_number,@lang_code,@description", parts);

            }
        }
    }

}
