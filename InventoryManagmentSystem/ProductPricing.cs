using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class ProductPricing : Sample2
    {
        public ProductPricing()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        private Retrieval r = new Retrieval();
        private Selection s = new Selection();
        private Updation u = new Updation();
        private void ProductPricing_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.GetList("st_GetCategoryList", CategoryCombo, "Category", "ID");

        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryCombo.SelectedIndex != -1 && CategoryCombo.SelectedIndex != 0)
            {
                s.ShowProductByCategory(dataGridView1, Convert.ToInt32(CategoryCombo.SelectedValue.ToString()), IdDGV, NameGV, PurPriceGV, FinalSalePriceGV, DiscountGV, ProfitMarginGV);
            }
        }

        private float profitMargintest;
        private float profitMargin;
        private float amountToIncrease;
        private float discountPer;
        private float finalSellingPrice;



        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                float purchasePrice = Convert.ToSingle(row.Cells["PurPriceGV"].Value.ToString());
                if (row.Cells["ProfitMarginGV"].Value != null &&
                    rg.Match(row.Cells["ProfitMarginGV"].Value.ToString()).Success)
                {
                    profitMargin = (Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString()) / 100);

                    amountToIncrease = profitMargin * purchasePrice;
                    finalSellingPrice = purchasePrice + amountToIncrease;

                    row.Cells["FinalSalePriceGV"].Value = finalSellingPrice;

                    if (row.Cells["DiscountGV"].Value != null &&
                        rg.Match(row.Cells["DiscountGV"].Value.ToString()).Success)
                    {
                        discountPer = finalSellingPrice * Convert.ToSingle(row.Cells["DiscountGV"].Value) / 100;
                    }
                    else
                    {
                        discountPer = 0;
                    }
                    finalSellingPrice = purchasePrice + amountToIncrease;
                    row.Cells["FinalSalePriceGV"].Value = finalSellingPrice - discountPer;

                }
                else
                {
                    //row.Cells["DiscountGV"].Value = null;
                    row.Cells["DiscountGV"].Value = null;
                    row.Cells["ProfitMarginGV"].Value = null;
                    row.Cells["FinalSalePriceGV"].Value = null;

                }

            }

        }
        public override void Addbtn_Click(object sender, EventArgs e)
        {

        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {

        }

        private int che;
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CategoryCombo.SelectedIndex != -1 && CategoryCombo.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["SelectItem"].FormattedValue == true)
                    {
                        che++;
                        u.UpdateProductPrice(Convert.ToInt32(row.Cells["IdDGV"].Value.ToString()), Convert.ToSingle(row.Cells["PurPriceGV"].Value.ToString()), Convert.ToSingle(row.Cells["FinalSalePriceGV"].Value.ToString()), Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()), Convert.ToSingle(row.Cells["ProfitMarginGV"].Value.ToString()));

                    }
                }

                if (che > 0)
                {
                    MainClass.showMsg("Update Successfully", "Updation Info", "Success");

                }
            }
        }


        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void ShowAllBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
