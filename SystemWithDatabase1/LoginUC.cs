using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemWithDatabase1
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
            pnlLogin.BringToFront();
        }

        private void lblGoToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.BringToFront();
        }

        private void lblGoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = this.FindForm() as Form1;
            if (main != null)
            {
                main.OpenPage(new DashboardUC());
            }
        }
    }
}
