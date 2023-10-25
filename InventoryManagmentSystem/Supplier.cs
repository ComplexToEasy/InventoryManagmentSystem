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
    public partial class Supplier : Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }
        private int SupplierId;
        private int edit;
        short stat;
        private Retrieval r = new Retrieval();
        public override void Addbtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            edit = 0;
        }

        public override void Editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);
        }

        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SupplierNameTxt.Text == "") nameerrorLbl.Visible = true; else nameerrorLbl.Visible = false;
            if (ContactNoTxt.Text == "") ContactErroLable.Visible = true; else ContactErroLable.Visible = false;
            if (PhoneTxt.Text == "") PhoneErrorlabel.Visible = true; else PhoneErrorlabel.Visible = false;
            if (AddrTxt.Text == "") AdderErrorlabel.Visible = true; else AdderErrorlabel.Visible = false;
            if (StatusCmbo.SelectedIndex == -1) StatusErrorLbl.Visible = true; else StatusErrorLbl.Visible = false;

            if (nameerrorLbl.Visible || ContactErroLable.Visible || ContactErroLable.Visible || PhoneErrorlabel.Visible || AdderErrorlabel.Visible || StatusErrorLbl.Visible)
            {
                MainClass.showMsg("Fields with '*' must be entered", "Stop", "Error");
            }
            else
            {

                if (StatusCmbo.SelectedIndex == 0)
                {
                    stat = 1;

                }
                else if (StatusCmbo.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0)
                {

                    Insertation i = new Insertation();
                    Selection s = new Selection();

                    i.InsertSupplier(SupplierNameTxt.Text, ContactNoTxt.Text, PhoneTxt.Text, AddrTxt.Text, stat, NTNTXT.Text);

                    s.ShowSupplier(dataGridView1, IdDGV, NameGV, ContactnoGV, PhoneGV, AddressGV, NTNGV, StatusGV);

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
                        if (StatusCmbo.SelectedIndex == 0)
                        {
                            stat = 1;

                        }
                        else if (StatusCmbo.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        u.UpdateSupplier(SupplierNameTxt.Text, ContactNoTxt.Text, PhoneTxt.Text, AddrTxt.Text, stat,SupplierId, NTNTXT.Text);

                        s.ShowSupplier(dataGridView1, IdDGV, NameGV, ContactnoGV, PhoneGV, AddressGV, NTNGV, StatusGV);
                        MainClass.disable_reset(LeftPanel);

                    }

                }
            }
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

                    d.Deleted(SupplierId, "st_DeleteSupplier", "@id");

                    s.ShowSupplier(dataGridView1, IdDGV, NameGV, ContactnoGV, PhoneGV, AddressGV, NTNGV, StatusGV);

                    MainClass.disable_reset(LeftPanel);


                }
            }
        }

        public override void ShowAllBtn_Click(object sender, EventArgs e)
        {
            Selection s = new Selection();
            s.ShowSupplier(dataGridView1, IdDGV, NameGV, ContactnoGV, PhoneGV, AddressGV, NTNGV, StatusGV);

        }
        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            Selection s = new Selection();

            if (SearchTxt.Text != "")
            {
                s.ShowSupplier(dataGridView1, IdDGV, NameGV, ContactnoGV, PhoneGV, AddressGV, NTNGV, StatusGV);

            }
            else
            {
                s.ShowSupplier(dataGridView1, IdDGV, NameGV, ContactnoGV, PhoneGV, AddressGV, NTNGV, StatusGV);

            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(LeftPanel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SupplierId = Convert.ToInt32(row.Cells["IdDGV"].Value.ToString());
                SupplierNameTxt.Text = row.Cells["NameGV"].Value.ToString();
                ContactNoTxt.Text = row.Cells["ContactnoGV"].Value.ToString();
                AddrTxt.Text = row.Cells["AddressGV"].Value.ToString();
                PhoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                NTNTXT.Text = row.Cells["NTNGV"].Value.ToString();
                StatusCmbo.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
