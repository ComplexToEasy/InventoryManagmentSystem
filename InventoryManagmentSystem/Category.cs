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
    public partial class Category : Sample2
    {
        private int CategoryId;
        private int edit;
        short stat;

        public Category()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);


        }
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
            if (NameTxt.Text == "") nameerrorLbl.Visible = true; else nameerrorLbl.Visible = false;
            if (IsActiveCombo.Text == "") IsActiveErrorLbl.Visible = true; else IsActiveErrorLbl.Visible = false;

            if (nameerrorLbl.Visible || IsActiveErrorLbl.Visible)
            {
                MainClass.showMsg("Fields with '*' must be entred", "Stop", "Error");
            }
            else
            {

                if (IsActiveCombo.SelectedIndex == 0)
                {
                    stat = 1;

                }
                else if (IsActiveCombo.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0)
                {

                    Insertation i = new Insertation();
                    Selection s = new Selection();

                    i.InsertCategory(NameTxt.Text, stat);

                    s.ShowCategory(dataGridView1, IdDGV, NameGV, StatusGV);

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
                        u.UpdateCategory(CategoryId, NameTxt.Text, stat);
           
                        if (IsActiveCombo.SelectedIndex == 0)
                        {
                            stat = 1;

                        }
                        else if (IsActiveCombo.SelectedIndex == 1)
                        {
                            stat = 0;
                        }


                        s.ShowCategory(dataGridView1, IdDGV, NameGV, StatusGV);

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
                    "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    Selection s = new Selection();

                    d.DeleteCategory(CategoryId, "st_DeleteCategory", "@id");


                    s.ShowCategory(dataGridView1, IdDGV, NameGV, StatusGV);

                    MainClass.disable_reset(LeftPanel);
                }
            }
        }

        public override void ShowAllBtn_Click(object sender, EventArgs e)
        {
            Selection s = new Selection();

            s.ShowCategory(dataGridView1, IdDGV, NameGV, StatusGV);

            MainClass.disable_reset(LeftPanel);


        }

        private void Category_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(LeftPanel);
            Selection s = new Selection();

            s.ShowCategory(dataGridView1, IdDGV, NameGV, StatusGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CategoryId = Convert.ToInt32(row.Cells["IdDGV"].Value.ToString());
                NameTxt.Text = row.Cells["NameGV"].Value.ToString();
                IsActiveCombo.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
