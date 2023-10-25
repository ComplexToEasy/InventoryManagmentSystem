using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (IntegratedSecurityChk.Checked)
            {


                if (ServerText.Text != "" && DataBaseText.Text != "")
                {
                    s = "Data Source=" + ServerText.Text + ";Initial Catalog=" + DataBaseText.Text +
                        ";Integrated Security=True;MultipleActiveResultSets=true;";
                    File.WriteAllText(path+"\\connect", s);

                    //Data Source=CTE;Initial Catalog=IMS;Integrated Security=True


                    DialogResult dr = MessageBox.Show("Setting Saved Successfully", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWndow(log, this, Mdi.ActiveForm);
                    }

                }
                else
                {
                    MessageBox.Show("Please give complete data to continue");
                }
            }
            else
            {
                if (ServerText.Text != "" && DataBaseText.Text != "" && UserTxt.Text != "" && PasswordTxt.Text != "")
                {
                    s = "Data Source=" + ServerText.Text + ";Initial Catalog=" + DataBaseText.Text +
                        ";User ID=" + UserTxt.Text + ";Password=" + PasswordTxt.Text + ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path + "\\connect", s);

                    DialogResult dr = MessageBox.Show("Setting Saved Successfully", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.ShowWndow(log, this, Mdi.ActiveForm);
                    }


                }
                else
                {
                    MessageBox.Show("Please give complete data to continue");
                }

            }

        }

        private void IntegratedSecurityChk_CheckedChanged(object sender, EventArgs e)
        {
            if (IntegratedSecurityChk.Checked)
            {
                UserTxt.Enabled = false;
                PasswordTxt.Enabled = false;
                UserTxt.Clear();
                PasswordTxt.Clear();
            }
            else
            {
                UserTxt.Enabled = true;
                PasswordTxt.Enabled = true;
            }
        }
    }
}
