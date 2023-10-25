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
    internal class Selection
    {
        public void ShowUser(DataGridView dv, DataGridViewColumn IdGV, DataGridViewColumn NameGV,
            DataGridViewColumn UsernameGV, DataGridViewColumn PswdGV, DataGridViewColumn EmailGV,
            DataGridViewColumn PhoneGV, DataGridViewColumn StatusGv, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_GetUsersData", MainClass.conn);

                }
                else
                {
                    cmd = new SqlCommand("st_GetUsersDataLike", MainClass.conn);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                IdGV.DataPropertyName = dt.Columns["Id"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UsernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                PswdGV.DataPropertyName = dt.Columns["Password"].ToString();
                EmailGV.DataPropertyName = dt.Columns["Email"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                StatusGv.DataPropertyName = dt.Columns["Status"].ToString();

                dv.DataSource = dt;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void ShowCategory(DataGridView dv, DataGridViewColumn IdGV, DataGridViewColumn NameGV, DataGridViewColumn StatusGv)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_GetCategoryData", MainClass.conn);


                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                IdGV.DataPropertyName = dt.Columns["Id"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                StatusGv.DataPropertyName = dt.Columns["Status"].ToString();

                dv.DataSource = dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void ShowProducts(DataGridView dv, DataGridViewColumn IdGV, DataGridViewColumn pnameGV, DataGridViewColumn barcodeGv, DataGridViewColumn expDateGv, DataGridViewColumn catNameGv, DataGridViewColumn catIdGv)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_GetProductsData", MainClass.conn);


                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                IdGV.DataPropertyName = dt.Columns["ID"].ToString();
                pnameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGv.DataPropertyName = dt.Columns["Barcode"].ToString();
                expDateGv.DataPropertyName = dt.Columns["Expiry"].ToString();
                catIdGv.DataPropertyName = dt.Columns["Category Id"].ToString();
                catNameGv.DataPropertyName = dt.Columns["Category"].ToString();


                dv.DataSource = dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void ShowSupplier(DataGridView dv, DataGridViewColumn IdGV, DataGridViewColumn nameGV, DataGridViewColumn contactnoGV, DataGridViewColumn phoneGV, DataGridViewColumn addrGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_GetSupplierData", MainClass.conn);


                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                IdGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                contactnoGV.DataPropertyName = dt.Columns["Contact No"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                addrGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();


                dv.DataSource = dt;

            }
            catch (Exception e)
            {
                MainClass.showMsg("Unable to load supplier data", "Error in Loading Supplier Data", "Error");
            }
        }
        public void ShowPurchaseInvoiceDetails(DataGridView dv, DataGridViewColumn IdGV, Int64 PurchaseIdGV, DataGridViewColumn productIDGV, DataGridViewColumn pnameGV, DataGridViewColumn priceGv, DataGridViewColumn QtyGv, DataGridViewColumn totalAmtGv)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_GetPurchaseInvoiceDetails", MainClass.conn);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", PurchaseIdGV);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                IdGV.DataPropertyName = dt.Columns["ID"].ToString();
                productIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pnameGV.DataPropertyName = dt.Columns["Product"].ToString();
                QtyGv.DataPropertyName = dt.Columns["Quantity"].ToString();
                priceGv.DataPropertyName = dt.Columns["Price"].ToString();
                totalAmtGv.DataPropertyName = dt.Columns["Total Price"].ToString();


                dv.DataSource = dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void ShowStock(DataGridView dv, DataGridViewColumn productIDGV, DataGridViewColumn pnameGV, DataGridViewColumn categoryGV, DataGridViewColumn barCodeGV, DataGridViewColumn ExpiryGV, DataGridViewColumn QtyGv, DataGridViewColumn priceGv, DataGridViewColumn AmountGv, DataGridViewColumn StatusGv)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_GetAllStock", MainClass.conn);


                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                categoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                productIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pnameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barCodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                ExpiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                QtyGv.DataPropertyName = dt.Columns["Available Stock"].ToString();
                priceGv.DataPropertyName = dt.Columns["Price"].ToString();
                AmountGv.DataPropertyName = dt.Columns["Amount"].ToString();
                StatusGv.DataPropertyName = dt.Columns["Status"].ToString();


                dv.DataSource = dt;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void ShowProductByCategory(DataGridView dv, int CatId, DataGridViewColumn productIDGV, DataGridViewColumn pnameGV, DataGridViewColumn PurchasePriceGV, DataGridViewColumn SalePriceGV, DataGridViewColumn DiscountGV, DataGridViewColumn ProfitGV)
        {
            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("st_GetProductByCategory", MainClass.conn);
                cmd.Parameters.AddWithValue("@id", CatId);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                productIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pnameGV.DataPropertyName = dt.Columns["Product"].ToString();
                PurchasePriceGV.DataPropertyName = dt.Columns["Purchase Price"].ToString();
                SalePriceGV.DataPropertyName = dt.Columns["Sale Price"].ToString();
                DiscountGV.DataPropertyName = dt.Columns["Discount"].ToString();
                ProfitGV.DataPropertyName = dt.Columns["Profit"].ToString();


                dv.DataSource = dt;

            }
            catch (Exception e)
            {
                MainClass.conn.Close();
                MainClass.showMsg("Unable to fetch data", "Error", "Error");
            }
        }


    }
}
