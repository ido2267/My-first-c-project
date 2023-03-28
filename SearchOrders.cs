using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace WindowsFormsApp1
{
    internal class SearchOrders
    {
        /*  public List<HandleOrders> GetOrders(string Order_id)
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
             {
                 var output = connection.Query<HandleOrders>("DBO.Get_orderById @order_id", new { order_id = Order_id }).ToList();
                 return output;
             }

         } */
        public List<DisplayOrders> GetOrders(string Order_id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
                var output = connection.Query<DisplayOrders>("DBO.Get_orderById2 @order_id", new { order_id = Order_id }).ToList();
                return output;
            }

        }
        internal void InsertOrders( string User_number, string LangCode,  string  Part_id, string Machine_id, string Amount )
        {
          

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("magma")))
            {
                InsertOrders NewOrder = new InsertOrders();

                 //NewOrder.creation_date =  DateTime.Now;
                NewOrder.lang_code = Int32.Parse(LangCode);
                NewOrder.user_number = Int32.Parse(User_number);
                NewOrder.part_id = Int32.Parse(Part_id);
                NewOrder.machine_id = Int32.Parse(Machine_id);
                NewOrder.amount = Int32.Parse(Amount);
                List<InsertOrders> Orders = new List<InsertOrders>();
                Orders.Add(NewOrder);
                connection.Execute("dbo.Order_Insert @user_number,@lang_code,@part_id,@machine_id,@amount", Orders);

            }
        }
    }

}
