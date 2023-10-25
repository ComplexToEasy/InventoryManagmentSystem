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
    public partial class Users : Sample2
    {
        private int userId;
        private int edit;
        short stat;

        public Users()
        {
            InitializeComponent();
        }
        //update krny k liy 1 veriable bna dia agr edit k btn ko click kia jaye ga to veriable 
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
            if (UserNametxt.Text == "") UserNameErrorLb.Visible = true; else UserNameErrorLb.Visible = false;
            if (PasswordTxt.Text == "") PswdErrorLbl.Visible = true; else PswdErrorLbl.Visible = false;
            if (PhoneTxt.Text == "") PhoneErrorLbl.Visible = true; else PhoneErrorLbl.Visible = false;
            if (EmailTxt.Text == "") EmailErrorLbl.Visible = true; else EmailErrorLbl.Visible = false;
            if (StatusCombo.SelectedIndex == -1) StatusErrorLbl.Visible = true; else StatusErrorLbl.Visible = false;

            if (nameerrorLbl.Visible || UserNameErrorLb.Visible || PhoneErrorLbl.Visible || PswdErrorLbl.Visible || EmailErrorLbl.Visible || StatusErrorLbl.Visible)
            {
                MainClass.showMsg("Fields with '*' must be entred", "Stop", "Error");
            }
            else
            {

                if (StatusCombo.SelectedIndex == 0)
                {
                    stat = 1;

                }
                else if (StatusCombo.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0)
                {

                    Insertation i = new Insertation();
                    Selection s = new Selection();

                    i.insertUser(NameTxt.Text, UserNametxt.Text, PasswordTxt.Text, PhoneTxt.Text, EmailTxt.Text, stat);

                    s.ShowUser(dataGridView1, IdDGV, NameGV, UsernameGV, PwdGV, EmailGV, PhoneGV, StatusGV);

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

                        u.UpdateUser(userId, NameTxt.Text, UserNametxt.Text, PasswordTxt.Text, PhoneTxt.Text, EmailTxt.Text, stat);

                        s.ShowUser(dataGridView1, IdDGV, NameGV, UsernameGV, PwdGV, EmailGV, PhoneGV, StatusGV);

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

                    d.Deleted(userId, "st_DeleteUsers", "@id");

                    s.ShowUser(dataGridView1, IdDGV, NameGV, UsernameGV, PwdGV, EmailGV, PhoneGV, StatusGV);

                    MainClass.disable_reset(LeftPanel);


                }
            }
        }

        public override void ShowAllBtn_Click(object sender, EventArgs e)
        {
            Selection s = new Selection();
            s.ShowUser(dataGridView1, IdDGV, NameGV, UsernameGV, PwdGV, EmailGV, PhoneGV, StatusGV);

        }
        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            Selection s = new Selection();

            if (SearchTxt.Text != "")
            {
                s.ShowUser(dataGridView1, IdDGV, NameGV, UsernameGV, PwdGV, EmailGV, PhoneGV, StatusGV, SearchTxt.Text);
            }
            else
            {
                s.ShowUser(dataGridView1, IdDGV, NameGV, UsernameGV, PwdGV, EmailGV, PhoneGV, StatusGV);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userId = Convert.ToInt32(row.Cells["IdDGV"].Value.ToString());
                NameTxt.Text = row.Cells["NameGV"].Value.ToString();
                UserNametxt.Text = row.Cells["UsernameGV"].Value.ToString();
                PasswordTxt.Text = row.Cells["PwdGV"].Value.ToString();
                PhoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                EmailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                StatusCombo.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
