using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }

        private Retrieval r = new Retrieval();
        private Selection s = new Selection();
        private void InvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            r.GetListWithTowParameters("st_GetPurchaseInvoiceList", InvoiceIDCombo, "Company", "ID", "@month",InvoiceDate.Value.Month, "@year",InvoiceDate.Value.Year);
        }
        public override void BackBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice  obj = new PurchaseInvoice();
            MainClass.ShowWndow(obj, this, Mdi.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            r.GetListWithTowParameters("st_GetPurchaseInvoiceList", InvoiceIDCombo, "Company", "ID", "@month", InvoiceDate.Value.Month, "@year", InvoiceDate.Value.Year);

        }

        private void InvoiceIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InvoiceIDCombo.SelectedIndex != -1 && InvoiceIDCombo.SelectedIndex != 0)
            {
                float gt = 0;
                s.ShowPurchaseInvoiceDetails(dataGridView1,PDId, Convert.ToInt64(InvoiceIDCombo.SelectedValue),ProductIdDGV,  ProductNameGV, PriceGV, QuantityGV, TotalAmtGV);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["TotalAmtGV"].Value.ToString());
                    GrossTotLable.Text = gt.ToString();
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
                    DialogResult dr =
                        MessageBox.Show("Are you sure to delete this" + row.Cells["ProductNameGV"].Value.ToString(), "Deletion Confirmation", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        Deletion d = new Deletion();
                        Updation u = new Updation();
                        int q;
                    //    d.Deleted(row.Cells());
                        object obj = r.GetProductQty(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()));
                        if (obj != null)
                        {
                            q = Convert.ToInt32(obj);
                            q -= Convert.ToInt32(row.Cells["QuantityGV"].Value.ToString());
                            u.UpdateStock(Convert.ToInt32(row.Cells["ProductIdDGV"].Value.ToString()), q);
                            float grandtot = Convert.ToSingle((GrossTotLable.Text));
                            float gridTot = Convert.ToSingle(row.Cells["TotalAmtGV"].Value);
                            float tot = grandtot - gridTot;
                            GrossTotLable.Text = tot.ToString();

                            d.Deleted(Convert.ToInt64(row.Cells["PDId"].Value.ToString()), "st_DeletePurchaseInvoiceDetails", "@id");
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
            }
        }
    }
}
