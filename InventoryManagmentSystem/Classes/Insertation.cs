using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    class Insertation
    {
        public void insertUser(string name, string username, string pswd, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pswd);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);

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
        public void InsertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertCategory", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isactive", status);

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
        public void InsertProducts(string name, string barcode, int catId, DateTime? expDate = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertProducts", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

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
        public void InsertSupplier(string name, string contactno, string phone, string addr, Int16 status, string? ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertSupplier", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

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
                MainClass.showMsg(name + " Successfully Saved", "Success", "Success");

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

        }

        private Int64 PurchaseId;
        public Int64 InsertPurchaseInvoice(DateTime vdate, int doneby, int supplierId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertPurchaseInvoice", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@vdate", vdate);
                cmd.Parameters.AddWithValue("@doneby", doneby);
                cmd.Parameters.AddWithValue("@supplierId", supplierId);

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "st_GetLastPurchaseId";
                cmd.Parameters.Clear();
                PurchaseId = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.conn.Close();

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

            return PurchaseId;
        }

        private int pidCount;
        public int InsertPurchaseInvoiceDetails(Int64 PurchaseInvoiceId, int productId, int qty, float totPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertPurchaseInvoiceDetails", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@purchase_id", PurchaseId);
                cmd.Parameters.AddWithValue("@product_id", productId);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@totprice", totPrice);

                MainClass.conn.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.conn.Close();

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

            return pidCount;
        }
        public void InsertStock(int productId, int qty)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertStock", MainClass.conn);
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
        public void InsertProductPrice(int productId, float? pPrice = null, float? sPrice = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertProductPrice", MainClass.conn);
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
        private Int64 SaleId;
        public Int64 InsertSaleInvoice(DateTime vdate, int doneby, float totamt, float totdiscount, string? cashType, float? givenamt = null, float? changeamt = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertSaleInvoice", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@vdate", vdate);
                cmd.Parameters.AddWithValue("@doneby", doneby);
                cmd.Parameters.AddWithValue("@totamt", totamt);
                cmd.Parameters.AddWithValue("@totdiscount", totdiscount);
                cmd.Parameters.AddWithValue("@givenamt", givenamt);
                cmd.Parameters.AddWithValue("@cashtype", cashType);
                cmd.Parameters.AddWithValue("@changeamt", changeamt);

                MainClass.conn.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText="st_GetLastSaleId";
                cmd.Parameters.Clear();
                SaleId = Convert.ToInt64(cmd.ExecuteScalar());
                MainClass.conn.Close();

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

            return SaleId;
        }
  
        int sidCount;

        public int InsertSaleInvoiceDetails(Int64 SaleInvoiceId, int productId, int qty, float totPrice)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("st_InsertSaleInvoiceDetails", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@sale_id", SaleId);
                cmd.Parameters.AddWithValue("@product_id", productId);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@totprice", totPrice);

                MainClass.conn.Open();
                sidCount = cmd.ExecuteNonQuery();
                MainClass.conn.Close();

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg(e.Message, "Error", "Error");
            }

            return sidCount;
        }

    }
}
