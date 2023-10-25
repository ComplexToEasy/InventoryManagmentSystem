using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class PurchaseInvoice : Sample2
    {
        private int edit;
        private int productId;
        private float gv;
        private Updation u = new Updation();
        private Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        float tqty;
        float tprice;
        float tamt = 0;
        int totProductCount = 0;

        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private Retrieval r = new Retrieval();
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(LeftPanel);
            r.GetList("st_GetSuplierList", SupplierCmbo, "Company", "ID");

        }
        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            r.GetList("st_GetSuplierList", SupplierCmbo, "Company", "ID");

            edit = 0;
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);

        }

        private string[] product = new string[3];
        private void BarCodeTxt_TextChanged(object sender, EventArgs e)
        {
            Array.Clear(product, 0, product.Length);

            if (BarCodeTxt.Text != "")
            {
                product = r.GetProductByBarcode(BarCodeTxt.Text);
                productId = Convert.ToInt32(product[0]);
                ProductNameTxt.Text = product[1];
                string barcodedb = product[2];
                ProductNameTxt.Enabled = false;
                if (Price.Text == "")
                {
                    TotalAmtTxt.Text = "0.00";

                }

                if (BarCodeTxt.Text == barcodedb) Price.Focus();


            }
            else
            {
                productId = 0;
                ProductNameTxt.Text = "";
                Price.Text = "";
                Array.Clear(product, 0, product.Length);
                if (Price.Text == "")
                {
                    TotalAmtTxt.Text = "0.00";

                }
            }

        }

        private void BarCodeTxt_Validated(object sender, EventArgs e)
        {

        }

        private void Qty_TextChanged(object sender, EventArgs e)
        {
            if (Price.Text == string.Empty)
            {
                Price.Text = "0";
            }
            if (Qty.Text == string.Empty)
            {
                Qty.Text = "0";
            }
            if (float.TryParse(Qty.Text, out tqty))
            {
                tqty = Convert.ToSingle(Qty.Text);
                tamt = 0;

            }
            else
            {
                tqty = 0;
            }
            if (float.TryParse(Price.Text, out tprice))
            {
                tprice = Convert.ToSingle(Price.Text);
                tamt = 0;

            }
            else
            {
                tprice = 0;
            }
            if (Price.Text != null)
            {
                if (!rg.Match(Price.Text).Success)
                {
                    tprice = 0;
                    Price.Text = "";
                    Price.Focus();
                    return;
                }
            }
            if (Qty.Text != null)
            {
                if (!rg.Match(Qty.Text).Success)
                {
                    tqty = 0;
                    Qty.Text = "0";
                    Qty.Focus();
                    return;
                }
            }
            if (Convert.ToSingle(Qty.Text) > 0 && Convert.ToSingle(Price.Text) > 0)
            {
                if (float.TryParse(Qty.Text, out float qtyfloat))
                {
                    // if (qtyfloat > 0 && Convert.ToSingle(Price.Text) > 0)
                    {
                        tamt = tqty * tprice;
                        TotalAmtTxt.Text = tamt.ToString("#######.##");

                    }
                    //else
                    //{
                    //    TotalAmtTxt.Text = "0.00";
                    //}
                }
                else
                {
                    TotalAmtTxt.Text = "0.00";
                }
            }
            else
            {
                TotalAmtTxt.Text = "0.00";
            }
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (SupplierCmbo.SelectedIndex == -1) SuppliererrorLbl.Visible = true;
            else SuppliererrorLbl.Visible = false;
            if (ProductNameTxt.Text == "") ProductErrorLbl.Visible = true;
            else ProductErrorLbl.Visible = false;
            if (Qty.Text == "" || Convert.ToInt32(Qty.Text) == 0) QtyErrorLable.Visible = true;
            else QtyErrorLable.Visible = false;
            if (SuppliererrorLbl.Visible == true || ProductErrorLbl.Visible == true || QtyErrorLable.Visible == true)
            {
                MainClass.showMsg("All Text with * must be filled", "Validation Error", "Error");
            }
            else
            {
                dataGridView1.Rows.Add(productId, ProductNameTxt.Text, Qty.Text, Price.Text, TotalAmtTxt.Text);
                gv += Convert.ToSingle(TotalAmtTxt.Text);
                GrossTotLable.Text = gv.ToString("############.##");
                productId = 0;
                ProductNameTxt.Text = "";
                BarCodeTxt.Text = "";
                Qty.Text = "";
                Price.Text = "";
                Array.Clear(product, 0, product.Length);
                if (Price.Text == "")
                {
                    TotalAmtTxt.Text = "0.00";

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gv -= Convert.ToSingle(row.Cells["TotalAmtGV"].Value.ToString());
                    GrossTotLable.Text = gv.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            int co = 0;

            if (dataGridView1.Rows.Count > 0)
            {
                Int64 PurchaseInvoiceId;
                Insertation i = new Insertation();
                using (TransactionScope sc = new TransactionScope())
                {
                    PurchaseInvoiceId = i.InsertPurchaseInvoice(DateTime.Now, Retrieval.UserId, Convert.ToInt32(SupplierCmbo.SelectedValue));

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        co += i.InsertPurchaseInvoiceDetails(PurchaseInvoiceId, Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()),
                            Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["PriceGV"].Value.ToString()));

                        //totProductCount = Convert.ToInt32(@"select product_id from ProductPrice where product_id =" + Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()));
                        //if (totProductCount > 0)
                        //{
                        //    MainClass.showMsg("Already Exist product", "Error", "Error");
                        //    return;
                        //}
                        if (r.CheckProductPriceExist(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString())))
                        {
                            u.UpdateProductPrice(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()), Convert.ToSingle(row.Cells["PriceGV"].Value.ToString()));
                        }
                        else
                        {
                            i.InsertProductPrice(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()),
                                Convert.ToSingle(row.Cells["PriceGV"].Value.ToString()));


                        }


                        int q;
                        object obj = r.GetProductQty(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()));
                        if (obj != null)
                        {
                            q = Convert.ToInt32(obj);
                            q += Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                            u.UpdateStock(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()), q);

                        }
                        else
                        {
                            i.InsertStock(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()), Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()));

                        }

                    }

                    if (co > 0)
                    {
                        MainClass.showMsg("Purchase Invoice Created successfully", "Successfully Saved", "Success");
                    }
                    else
                    {
                        MainClass.showMsg("Purchase Invoice failed to insert", "Saving has error", "Error");

                    }
                    sc.Complete();
                }

            }
        }
        public override void ShowAllBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pd = new PurchaseInvoiceDetails();
            MainClass.ShowWndow(pd, Mdi.ActiveForm);
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            if (Price.Text != string.Empty)
            {
                if (!rg.Match(Price.Text).Success)
                {
                    tprice = 0;
                    Price.Text = "";
                    Price.Focus();
                    return;
                }
            }
            if (Qty.Text != string.Empty)
            {
                if (!rg.Match(Qty.Text).Success)
                {
                    tqty = 0;
                    Qty.Text = "0";
                    Qty.Focus();
                    return;
                }
            }

            if (Price.Text == string.Empty)
            {
                Price.Text = "0";
            }
            if (Qty.Text == string.Empty)
            {
                Qty.Text = "0";
            }
            if (float.TryParse(Qty.Text, out tqty))
            {
                tqty = Convert.ToSingle(Qty.Text);
                tamt = 0;

            }
            else
            {
                tqty = 0;
            }
            if (float.TryParse(Price.Text, out tprice))
            {
                tprice = Convert.ToSingle(Price.Text);
                tamt = 0;

            }
            else
            {
                tprice = 0;
            }
            if (Convert.ToSingle(Qty.Text) > 0 && Convert.ToSingle(Price.Text) > 0)
            {
                if (float.TryParse(Qty.Text, out float qtyfloat))
                {
                    // if (qtyfloat > 0 && Convert.ToSingle(Price.Text) > 0)
                    {
                        tamt = tqty * tprice;
                        TotalAmtTxt.Text = tamt.ToString("#######.##");

                    }
                    //else
                    //{
                    //    TotalAmtTxt.Text = "0.00";
                    //}
                }
                else
                {
                    TotalAmtTxt.Text = "0.00";
                }
            }
            else
            {
                TotalAmtTxt.Text = "0.00";
            }
        }
    }
}
