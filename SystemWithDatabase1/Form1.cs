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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void OpenPage(UserControl uc)
        {
            mainPanel.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(uc);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            OpenPage(new LoginUC());

            // https://www.facebook.com/tagaminsukami/posts/official-logo-of-mindoro-state-university-%EF%B8%8Fas-per-board-of-regents-bor-resolutio/4313139068769761/
            }        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DASHBORAD formUnknown = new DASHBORAD();
            //formUnknown.Show();
            //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
