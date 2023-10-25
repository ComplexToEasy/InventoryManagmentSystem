using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagmentSystem
{
    internal class Updation
    {
        public void UpdateUser(int id, string name, string username, string pswd, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateUsers", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pswd);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();
                MainClass.showMsg("Successfully Updated", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }
        public void UpdateCategory(int id, string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateCategory", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isactive", status);

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();
                MainClass.showMsg("Successfully Updated", "Update Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }
        public void UpdateProducts(int id, string name, string barcode, int catId, DateTime? expDate = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateProducts", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                if (expDate == null)
                {
                    cmd.Parameters.AddWithValue("@expdate", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@expdate", expDate);

                }
                cmd.Parameters.AddWithValue("@catid", catId);

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();
                MainClass.showMsg("Successfully Inserted", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }
        public void UpdateSupplier(string name, string contactno, string phone, string addr, Int16 status, int id, string? ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateSupplier", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contactno", contactno);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@addr", addr);
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);

                }
                cmd.Parameters.AddWithValue("@status", status);

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();
                //MainClass.showMsg(name, "Update Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }
        public void UpdateStock(int productId, float qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateStock", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@product_id", productId);
                cmd.Parameters.AddWithValue("@qty", qty);

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }
        public void UpdateProductPrice(int productId, float? pPrice = null, float? sPrice = null, float? dis = null, float? profit = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateProductPrice", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@product_id", productId);
                if (pPrice == null)
                {
                    cmd.Parameters.AddWithValue("@pprice", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@pprice", pPrice);

                }
                if (sPrice == null)
                {
                    cmd.Parameters.AddWithValue("@sprice", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@sprice", sPrice);

                }
                if (dis == null)
                {
                    cmd.Parameters.AddWithValue("@dis", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@dis", dis);

                }

                if (profit == null)
                {
                    cmd.Parameters.AddWithValue("@profit", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@profit", profit);

                }

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();
                MainClass.conn.Close();

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }


    }
}
