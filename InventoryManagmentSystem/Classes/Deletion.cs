using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem
{
    internal class Deletion
    {
        public void Deleted(object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(param, id);
                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();
              //  MainClass.showMsg("Successfully Delete", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }
     public void DeleteCategory(object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_DeleteCategory", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(param, id);
                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();
                MainClass.showMsg("Successfully Delete", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }
    }
}
