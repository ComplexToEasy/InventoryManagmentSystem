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
    public partial class Products : Sample2
    {
        private int userId;
        private int edit;

        public Products()
        {
            InitializeComponent();
        }

        private Retrieval r = new Retrieval();
        private void Products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(LeftPanel);
            r.GetList("st_GetCategoryList", CategoryCombo, "Category", "ID");

        }
        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            r.GetList("st_GetCategoryList", CategoryCombo, "Category", "ID");
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);

        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "") nameerrorLbl.Visible = true; else nameerrorLbl.Visible = false;
            if (BarcodeTxt.Text == "") BarcodeErrorLbl.Visible = true; else BarcodeErrorLbl.Visible = false;

            if (ExpDateDate.Value.Date < DateTime.Now.Date) { ExpiryErrorLable.Visible = true; ExpiryErrorLable.Text = "Invalid date"; } else ExpiryErrorLable.Visible = false;

            if (CategoryCombo.SelectedIndex == -1 || CategoryCombo.SelectedIndex == 0) CategoryErrorLable.Visible = true; else CategoryErrorLable.Visible = false;

            if (nameerrorLbl.Visible || BarcodeErrorLbl.Visible || ExpiryErrorLable.Visible || CategoryErrorLable.Visible)
            {
                MainClass.showMsg("Fields with '*' must be entred", "Stop", "Error");
            }
            else
            {

                if (edit == 0)
                {

                    Insertation i = new Insertation();
                    Selection s = new Selection();

                    if (ExpDateDate.Value.Date == DateTime.Now.Date)
                    {
                        i.InsertProducts(NameTxt.Text, BarcodeTxt.Text,  (int)CategoryCombo.SelectedValue, null);

                    }
                    else
                    {
                        i.InsertProducts(NameTxt.Text, BarcodeTxt.Text,  (int)CategoryCombo.SelectedValue, ExpDateDate.Value);

                    }

                    s.ShowProducts(dataGridView1, IdDGV, NameGV, BarcodeGV,  ExpiryGV, CatNameGV, CatIdGV);

                    MainClass.disable_reset(LeftPanel);

                }
                else if (edit == 1) // code for update opration
                {
                    DialogResult dr = MessageBox.Show("this record will be update, Are you sure?",
                        "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        Selection s = new Selection();

                        if (ExpDateDate.Value.Date == DateTime.Now.Date)
                        {
                            u.UpdateProducts(userId, NameTxt.Text, BarcodeTxt.Text,  (int)CategoryCombo.SelectedValue, null);

                        }
                        else
                        {
                            u.UpdateProducts(userId, NameTxt.Text, BarcodeTxt.Text,  (int)CategoryCombo.SelectedValue, ExpDateDate.Value);

                        }

                        s.ShowProducts(dataGridView1, IdDGV, NameGV, BarcodeGV,  ExpiryGV, CatNameGV, CatIdGV);

                        MainClass.disable_reset(LeftPanel);

                    }

                }
            }
        }


        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("this record will be delete, Are you sure?",
                    "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    Selection s = new Selection();

                    d.Deleted(userId, "st_DeleteProducts", "@id");

                    s.ShowProducts(dataGridView1, IdDGV, NameGV, BarcodeGV, ExpiryGV, CatNameGV, CatIdGV);

                    MainClass.disable_reset(LeftPanel);


                }
            }
        }

        public override void ShowAllBtn_Click(object sender, EventArgs e)
        {
            Selection s = new Selection();

            s.ShowProducts(dataGridView1, IdDGV, NameGV, BarcodeGV,  ExpiryGV, CatNameGV, CatIdGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                userId = Convert.ToInt32(row.Cells["IdDGV"].Value.ToString());
                NameTxt.Text = row.Cells["NameGV"].Value.ToString();
                BarcodeTxt.Text = row.Cells["BarcodeGV"].Value.ToString();
                if (row.Cells["ExpiryGV"].FormattedValue.ToString() == "")
                {
                    ExpDateDate.Value = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));
                }
                else
                {
                    ExpDateDate.Value = Convert.ToDateTime(row.Cells["ExpiryGV"].Value.ToString());

                }
                CategoryCombo.SelectedValue = row.Cells["CatIdGV"].Value.ToString();

                MainClass.disable(LeftPanel);
            }
        }
    }
}
