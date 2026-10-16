using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemWithDatabase1
{
    public partial class DashboardUC : UserControl
    {
        public DashboardUC()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            ApplyCircularProfilePicture();
        }

        private void SideBarPanel_Paint(object sender, PaintEventArgs e)
        {
            using (var gradient = new LinearGradientBrush(
                sideBarPanel.ClientRectangle,
                Color.FromArgb(30, 41, 59),
                Color.FromArgb(15, 23, 42),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradient, sideBarPanel.ClientRectangle);
            }
        }

        private void ProfilePictureBox_Resize(object sender, EventArgs e)
        {
            ApplyCircularProfilePicture();
        }

        private void ApplyCircularProfilePicture()
        {
            if (profilePictureBox.Width <= 0 || profilePictureBox.Height <= 0)
            {
                return;
            }

            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, profilePictureBox.Width, profilePictureBox.Height);
                var previousRegion = profilePictureBox.Region;
                profilePictureBox.Region = new Region(path);
                if (previousRegion != null)
                {
                    previousRegion.Dispose();
                }
            }
        }
    }
}
