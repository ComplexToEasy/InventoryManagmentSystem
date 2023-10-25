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
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "") nameerrorLbl.Visible = true;
            else nameerrorLbl.Visible = false;

            if (PasswordTxt.Text == "") PassErrorlabel.Visible = true;
            else PassErrorlabel.Visible = false;

            if (nameerrorLbl.Visible == true || PassErrorlabel.Visible == true)
            {
                return;
            }

            if (Retrieval.GetUserDetails(UserNameTxt.Text, PasswordTxt.Text))
            {
                HomeScreen obj = new HomeScreen();
                MainClass.ShowWndow(obj, this, Mdi.ActiveForm);
            }
        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (UserNameTxt.Text == "") nameerrorLbl.Visible = true;
            else nameerrorLbl.Visible = false;

        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "") PassErrorlabel.Visible = true;
            else PassErrorlabel.Visible = false;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            UserNameTxt.Text = "a";
            PasswordTxt.Text = "a";
        }
    }
}
