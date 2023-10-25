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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            Userlabel.Text = Retrieval.UserName;
            
            Mdi.logoutToolStripMenuItem.Enabled = true;
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.ShowWndow(u,this, Mdi.ActiveForm);
        }

        private void CategoryOpnBtn_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            MainClass.ShowWndow(cat, this, Mdi.ActiveForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products P = new Products();
            MainClass.ShowWndow(P, Mdi.ActiveForm);
        }

        private void SupplierOpnBtn_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            MainClass.ShowWndow(s,this,Mdi.ActiveForm);
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pi = new PurchaseInvoice();
            MainClass.ShowWndow(pi, this, Mdi.ActiveForm);
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            Stocks st = new Stocks();
            MainClass.ShowWndow(st, this, Mdi.ActiveForm);
        }

        private void SalesOpnBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.ShowWndow(s, this, Mdi.ActiveForm);
        }

        private void ProductPricingBtn_Click(object sender, EventArgs e)
        {
            ProductPricing pp = new ProductPricing();
            MainClass.ShowWndow(pp, this, Mdi.ActiveForm);


        }

        private void SaleReportRptBtn_Click(object sender, EventArgs e)
        {
            SaleReceiptRpt sr = new SaleReceiptRpt();
            sr.Show();
           // MainClass.ShowWndow(sr, this, Mdi.ActiveForm);

        }
    }
}
