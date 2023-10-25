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
    public partial class Mdi : Form
    {
        public Mdi()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
           
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (File.Exists(path + "\\connect"))
                {

                    Login log = new Login();
                    MainClass.ShowWndow(log, this);
                }
                else //if (!File.Exists(path + "\\connect"))

                {
                    Settings set = new Settings();
                    MainClass.ShowWndow(set, this);
                }

            }
            catch (Exception exception)
            {
                Settings set = new Settings();
                MainClass.ShowWndow(set, this);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.ShowWndow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.ShowWndow(log, this);

            Mdi.logoutToolStripMenuItem.Enabled = false;

        }
    }
}
