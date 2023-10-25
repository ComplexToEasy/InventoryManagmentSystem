using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }

        private Retrieval r = new Retrieval();
        private int productId;
        float gross;
        float total;
        private int q;
        private bool checkProduct;
        private string[] product = new string[6];
        private Insertation i = new Insertation();
        private Updation u = new Updation();
        private Selection s = new Selection();
        private void BarCodeTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BarCodeTxt.Text != "")
                {
                    //productdata[0] = dr["ID"].ToString();
                    //productdata[1] = dr["Product"].ToString();
                    //productdata[2] = dr["Barcode"].ToString();
                    //productdata[3] = dr["Selling Price"].ToString();
                    //productdata[4] = dr["Discount"].ToString();
                    //productdata[5] = dr["Final Price"].ToString();

                    product = r.GetProductByBarcode(BarCodeTxt.Text);
                    productId = Convert.ToInt32(product[0]);
                    string barcodedb = product[2];
                    if (BarCodeTxt.Text == barcodedb)
                    {
                        if (dataGridView1.Rows.Count == 0)
                        {
                            dataGridView1.Rows.Add(productId.ToString(), product[1].ToString(), 1, Convert.ToSingle(product[3].ToString()),
                                Convert.ToSingle(product[4].ToString()), Convert.ToSingle(product[5].ToString()));
                            //dataGridView1.Rows.Add(1, 1, 1, 1, 1, 1, 1);
                            //Convert.ToSingle(product[4].ToString()), Convert.ToSingle(product[5].ToString()));

                        }
                        else
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {

                                if (row.Cells["ProductIdDGV"].Value.ToString() == product[0])
                                {
                                    checkProduct = true;
                                    break;

                                }
                                else
                                {
                                    checkProduct = false;
                                }
                            }

                            if (checkProduct == true)
                            {
                                foreach (DataGridViewRow row in dataGridView1.Rows)
                                {
                                    if (row.Cells["ProductIdDGV"].Value.ToString() == product[0])
                                    {
                                        row.Cells["QuantityGV"].Value = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()) + 1;
                                        float qt = Convert.ToSingle(row.Cells["QuantityGV"].Value.ToString());
                                        float pr = Convert.ToSingle(row.Cells["PriceGV"].Value.ToString());
                                        float amt = qt * pr;
                                        float dis = Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString());
                                        row.Cells["TotalAmtGV"].Value = (amt - dis).ToString();
                                    }

                                }
                            }
                            else
                            {
                                dataGridView1.Rows.Add(productId, product[1], 1, Convert.ToSingle(product[3]),
                                    Convert.ToSingle(product[4]), Convert.ToSingle(product[5]));
                            }
                        }

                        if (dataGridView1.Rows.Count > 0)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                total = Convert.ToSingle(row.Cells["TotalAmtGV"].Value.ToString());
                                total += total;
                                gross += Convert.ToSingle(product[5]);
                                GrossTotLable.Text = total.ToString();

                            }
                        }
                        total = 0;
                        q = 0;
                        BarCodeTxt.Text = "";
                        TestLable.Text = "";

                        BarCodeTxt.Focus();

                    }
                }
                else
                {
                    productId = 0;
                }
            }
            catch (Exception exception)
            {
                MainClass.showMsg(exception.Message + " unable to get data", "Error", "Error");
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                float gt;
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                    if (q == 1)
                    {
                        gt = Convert.ToSingle(GrossTotLable.Text);
                        GrossTotLable.Text = (gt - Convert.ToSingle(row.Cells["TotalAmtGV"].Value.ToString())).ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {
                        q--;
                        gt = Convert.ToSingle(GrossTotLable.Text);
                        GrossTotLable.Text = (gt - Convert.ToSingle(row.Cells["PriceGV"].Value.ToString())).ToString();
                        row.Cells["QuantityGV"].Value = q;

                    }
                }
            }
        }

        private float totgross;
        private float totdis;
        private void ChqOutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                totdis = 0;
                totgross = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    totgross = totgross + Convert.ToSingle(GrossTotLable.Text);
                    GrossTotalTxt.Text = totgross.ToString();
                    totdis = totdis + Convert.ToSingle(row.Cells["DiscountGV"].Value);
                    TotDisTxt.Text = totdis.ToString();

                }
            }
        }

        private float floatgiven;
        private void GivenAmtTxt_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(GivenAmtTxt.Text, out floatgiven) && Convert.ToSingle(GrossTotalTxt.Text) <= Convert.ToSingle(GivenAmtTxt.Text))
            {
                ChangeTxt.Text = (Convert.ToSingle(GivenAmtTxt.Text) - (Convert.ToSingle(GrossTotalTxt.Text) + Convert.ToSingle(TotDisTxt.Text))).ToString();
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private int co;
        private void PayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Int64 SaleInvoiceId = 0;
                    Insertation i = new Insertation();
                    using (TransactionScope sc = new TransactionScope())
                    {
                        SaleInvoiceId = i.InsertSaleInvoice(DateTime.Now, Retrieval.UserId, Convert.ToSingle(GrossTotalTxt.Text), Convert.ToSingle(TotDisTxt.Text), PaymentTypeCmbo.Text, Convert.ToSingle(ChangeTxt.Text), Convert.ToSingle(ChangeTxt.Text));

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            co += i.InsertSaleInvoiceDetails(SaleInvoiceId, Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()),
                                Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["PriceGV"].Value.ToString()));

                            //totProductCount = Convert.ToInt32(@"select product_id from ProductPrice where product_id =" + Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()));
                            //if (totProductCount > 0)
                            //{
                            //    MainClass.showMsg("Already Exist product", "Error", "Error");
                            //    return;
                            //}
                            //if (r.CheckProductPriceExist(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString())))
                            //{
                            //    u.UpdateProductPrice(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()),null, Convert.ToSingle(row.Cells["PriceGV"].Value.ToString()));
                            //}
                            //else
                            //{
                            //    i.InsertProductPrice(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()),null,
                            //        Convert.ToSingle(row.Cells["PriceGV"].Value.ToString()));


                            //}


                            int q;
                            object obj = r.GetProductQty(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()));
                            if (obj != null)
                            {
                                q = Convert.ToInt32(obj);
                                q -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                                u.UpdateStock(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()), q);

                            }
                            else
                            {
                                i.InsertStock(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()), -Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString()));

                            }

                            if (co == dataGridView1.Rows.Count)
                            {
                                break;
                            }

                        }

                        if (co > 0)
                        {
                            MainClass.showMsg("Sale Invoice Created successfully", "Successfully Saved", "Success");
                        }
                        //else
                        //{
                        //    MainClass.showMsg("Sale Invoice failed to insert", "Saving has error", "Error");

                        //}
                        sc.Complete();
                    }

                }
            }
            catch (Exception exception)
            {
                MainClass.showMsg(exception.Message + " Sale Invoice failed to insert", "Saving has error", "Error");

            }


        }
    }
}
