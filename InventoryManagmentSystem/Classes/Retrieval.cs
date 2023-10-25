using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    class Retrieval
    {
        public void GetList(string proc, ComboBox cb, string displayMember, string valueMember, object param1 = null, object param2 = null)
        {
            try
            {
                cb.DataSource = null;
                cb.Items.Clear();
                cb.Items.Insert(0, "Select...");

                SqlCommand cmd = new SqlCommand(proc, MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow(); // Create a new row from the DataTable
                dr[displayMember] = "Select..."; // Assign the displayMember column
                dr[valueMember] = 0; // Assign the valueMember column

                dt.Rows.InsertAt(dr, 0); // Insert the new row at the beginning of the DataTable

                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void GetListWithTowParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
                cb.DataSource = null;
                cb.Items.Clear();
                cb.Items.Insert(0, "Select...");

                SqlCommand cmd = new SqlCommand(proc, MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow(); // Create a new row from the DataTable
                dr[displayMember] = "Select..."; // Assign the displayMember column
                dr[valueMember] = 0; // Assign the valueMember column

                dt.Rows.InsertAt(dr, 0); // Insert the new row at the beginning of the DataTable

                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void GetProductList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                cb.Items.Insert(0, "Select...");

                SqlCommand cmd = new SqlCommand(proc, MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow dr = dt.NewRow(); // Create a new row from the DataTable
                dr[displayMember] = "Select..."; // Assign the displayMember column
                dr[valueMember] = 0; // Assign the valueMember column

                dt.Rows.InsertAt(dr, 0); // Insert the new row at the beginning of the DataTable

                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static int UserId
        {
            get;
            private set;
        }
        public static string UserName
        {
            get;
            private set;
        }

        private static string user_name = null, pass = null;
        private static Boolean CheckLogin = false;
        public static bool GetUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_GetUserDetails", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pswd", password);

                MainClass.conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        UserId = Convert.ToInt32(sdr["ID"].ToString());
                        UserName = sdr["Username"].ToString();
                        user_name = sdr["Username"].ToString();
                        pass = sdr["Password"].ToString();
                        CheckLogin = true;
                    }
                }
                else
                {
                    if (user_name != null && pass != null)
                    {
                        if (user_name != username && pass == password)
                        {
                            MainClass.showMsg("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass != password)
                        {
                            MainClass.showMsg("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass != password)
                        {
                            MainClass.showMsg("Invalid Credential", "Error", "Error");
                        }

                        CheckLogin = false;
                    }
                }

                MainClass.conn.Close();
            }
            catch (Exception e)
            {
                CheckLogin = false;
                MainClass.conn.Close();
                MainClass.showMsg("Unable to connect...", "Error", "Error");
            }

            return CheckLogin;
        }

        private string[] productdata = new string[6];
        public string[] GetProductByBarcode(string barcode)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_GetProductByBarcode", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@barcode", barcode);

                MainClass.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productdata[0] = dr["ID"].ToString();
                        productdata[1] = dr["Product"].ToString();
                        productdata[2] = dr["Barcode"].ToString();
                        productdata[3] = dr["Selling Price"].ToString();
                        productdata[4] = dr["Discount"].ToString();
                        productdata[5] = dr["Final Price"].ToString();
                    }

                }
                else
                {
                    MainClass.conn.Close();
                }

                MainClass.conn.Close();
                return productdata;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private object productStockCount = 0;
        public object GetProductQty(int product_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_GetProductQty", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@product_id", product_id);


                MainClass.conn.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.conn.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return productStockCount;
        }

         bool CheckProductPriceExisting;
        public bool CheckProductPriceExist(int product_id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_CheckProductPriceExist", MainClass.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@product_id", product_id);

                MainClass.conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        CheckProductPriceExisting = true;
                    }
                }
                else
                {


                    CheckProductPriceExisting = false;
                }

                MainClass.conn.Close();
            }
            catch (Exception e)
            {
                CheckProductPriceExisting = false;
                MainClass.conn.Close();
                MainClass.showMsg("Unable to check...", "Error", "Error");
            }

            return CheckProductPriceExisting;
        }


    }
}