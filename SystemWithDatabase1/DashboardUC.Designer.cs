namespace SystemWithDatabase1
{
    partial class DashboardUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.profileDividerPanel = new System.Windows.Forms.Panel();
            this.menu5Button = new System.Windows.Forms.Button();
            this.menu4Button = new System.Windows.Forms.Button();
            this.menu3Button = new System.Windows.Forms.Button();
            this.menu2Button = new System.Windows.Forms.Button();
            this.menu1Button = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.systemNameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.sideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.sideBarPanel.Controls.Add(this.logoutButton);
            this.sideBarPanel.Controls.Add(this.userRoleLabel);
            this.sideBarPanel.Controls.Add(this.userNameLabel);
            this.sideBarPanel.Controls.Add(this.profilePictureBox);
            this.sideBarPanel.Controls.Add(this.profileDividerPanel);
            this.sideBarPanel.Controls.Add(this.menu5Button);
            this.sideBarPanel.Controls.Add(this.menu4Button);
            this.sideBarPanel.Controls.Add(this.menu3Button);
            this.sideBarPanel.Controls.Add(this.menu2Button);
            this.sideBarPanel.Controls.Add(this.menu1Button);
            this.sideBarPanel.Controls.Add(this.dashboardButton);
            this.sideBarPanel.Controls.Add(this.systemNameLabel);
            this.sideBarPanel.Controls.Add(this.logoPictureBox);
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(258, 894);
            this.sideBarPanel.TabIndex = 0;
            this.sideBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBarPanel_Paint);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(20, 826);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(218, 48);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.BackColor = System.Drawing.Color.Transparent;
            this.userRoleLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRoleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.userRoleLabel.Location = new System.Drawing.Point(68, 785);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(77, 13);
            this.userRoleLabel.TabIndex = 12;
            this.userRoleLabel.Text = "Administrator";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(68, 765);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(69, 15);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "User Name";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profilePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.profilePictureBox.Location = new System.Drawing.Point(20, 765);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(38, 38);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 10;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Resize += new System.EventHandler(this.ProfilePictureBox_Resize);
            // 
            // profileDividerPanel
            // 
            this.profileDividerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileDividerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.profileDividerPanel.Location = new System.Drawing.Point(20, 744);
            this.profileDividerPanel.Name = "profileDividerPanel";
            this.profileDividerPanel.Size = new System.Drawing.Size(218, 1);
            this.profileDividerPanel.TabIndex = 9;
            // 
            // menu5Button
            // 
            this.menu5Button.BackColor = System.Drawing.Color.Transparent;
            this.menu5Button.FlatAppearance.BorderSize = 0;
            this.menu5Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu5Button.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu5Button.ForeColor = System.Drawing.Color.White;
            this.menu5Button.Location = new System.Drawing.Point(20, 515);
            this.menu5Button.Name = "menu5Button";
            this.menu5Button.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.menu5Button.Size = new System.Drawing.Size(218, 48);
            this.menu5Button.TabIndex = 8;
            this.menu5Button.Text = "Menu 5";
            this.menu5Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu5Button.UseVisualStyleBackColor = false;
            // 
            // menu4Button
            // 
            this.menu4Button.BackColor = System.Drawing.Color.Transparent;
            this.menu4Button.FlatAppearance.BorderSize = 0;
            this.menu4Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu4Button.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu4Button.ForeColor = System.Drawing.Color.White;
            this.menu4Button.Location = new System.Drawing.Point(20, 455);
            this.menu4Button.Name = "menu4Button";
            this.menu4Button.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.menu4Button.Size = new System.Drawing.Size(218, 48);
            this.menu4Button.TabIndex = 7;
            this.menu4Button.Text = "Menu 4";
            this.menu4Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu4Button.UseVisualStyleBackColor = false;
            // 
            // menu3Button
            // 
            this.menu3Button.BackColor = System.Drawing.Color.Transparent;
            this.menu3Button.FlatAppearance.BorderSize = 0;
            this.menu3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu3Button.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3Button.ForeColor = System.Drawing.Color.White;
            this.menu3Button.Location = new System.Drawing.Point(20, 395);
            this.menu3Button.Name = "menu3Button";
            this.menu3Button.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.menu3Button.Size = new System.Drawing.Size(218, 48);
            this.menu3Button.TabIndex = 6;
            this.menu3Button.Text = "Menu 3";
            this.menu3Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu3Button.UseVisualStyleBackColor = false;
            // 
            // menu2Button
            // 
            this.menu2Button.BackColor = System.Drawing.Color.Transparent;
            this.menu2Button.FlatAppearance.BorderSize = 0;
            this.menu2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu2Button.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2Button.ForeColor = System.Drawing.Color.White;
            this.menu2Button.Location = new System.Drawing.Point(20, 335);
            this.menu2Button.Name = "menu2Button";
            this.menu2Button.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.menu2Button.Size = new System.Drawing.Size(218, 48);
            this.menu2Button.TabIndex = 5;
            this.menu2Button.Text = "Menu 2";
            this.menu2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu2Button.UseVisualStyleBackColor = false;
            // 
            // menu1Button
            // 
            this.menu1Button.BackColor = System.Drawing.Color.Transparent;
            this.menu1Button.FlatAppearance.BorderSize = 0;
            this.menu1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.menu1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu1Button.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1Button.ForeColor = System.Drawing.Color.White;
            this.menu1Button.Location = new System.Drawing.Point(20, 275);
            this.menu1Button.Name = "menu1Button";
            this.menu1Button.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.menu1Button.Size = new System.Drawing.Size(218, 48);
            this.menu1Button.TabIndex = 4;
            this.menu1Button.Text = "Menu 1";
            this.menu1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu1Button.UseVisualStyleBackColor = false;
            this.menu1Button.Click += new System.EventHandler(this.menu1Button_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Location = new System.Drawing.Point(20, 215);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(218, 48);
            this.dashboardButton.TabIndex = 3;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.UseVisualStyleBackColor = false;
            // 
            // systemNameLabel
            // 
            this.systemNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemNameLabel.ForeColor = System.Drawing.Color.White;
            this.systemNameLabel.Location = new System.Drawing.Point(20, 105);
            this.systemNameLabel.Name = "systemNameLabel";
            this.systemNameLabel.Size = new System.Drawing.Size(218, 48);
            this.systemNameLabel.TabIndex = 2;
            this.systemNameLabel.Text = "CINEMA MANAGEMENT";
            this.systemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.logoPictureBox.Location = new System.Drawing.Point(101, 34);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(56, 56);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 1;
            this.logoPictureBox.TabStop = false;
            // 
            // DashboardUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.sideBarPanel);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(1207, 894);
            this.Load += new System.EventHandler(this.DashboardUC_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label systemNameLabel;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button menu1Button;
        private System.Windows.Forms.Button menu2Button;
        private System.Windows.Forms.Button menu3Button;
        private System.Windows.Forms.Button menu4Button;
        private System.Windows.Forms.Button menu5Button;
        private System.Windows.Forms.Panel profileDividerPanel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Button logoutButton;
    }
}
