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
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            Addbtn.Visible = false;
            Editbtn.Visible = false;
            SaveBtn.Visible = false;
            DeleteBtn.Visible = false;
            
        }
        public override void ShowAllBtn_Click(object sender, EventArgs e)
        {
            Selection s = new Selection();
            s.ShowStock(dataGridView1,ProductIdDGV, ProductNameGV, CetagoryGV, BarcodeGV, ExpiryGV, QuantityGV, PriceGV,AmountGV, StatusGV);
        }

    }
}
