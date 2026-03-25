namespace project3
{
    partial class Administrator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnprofile = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewuser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdduser = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Profile1 = new project3.AdministratorUC.UC_Profile();
            this.uC_Viewuser1 = new project3.AdministratorUC.UC_Viewuser();
            this.uC_Adduser1 = new project3.AdministratorUC.UC_Adduser();
            this.uC_Dashboard1 = new project3.AdministratorUC.UC_Dashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnprofile);
            this.panel1.Controls.Add(this.btnViewuser);
            this.panel1.Controls.Add(this.btnAdduser);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.usernameLabel.Location = new System.Drawing.Point(3, 675);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(267, 31);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "PHARMACY";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnlogout
            // 
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnlogout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnlogout.Location = new System.Drawing.Point(65, 603);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(208, 45);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnprofile
            // 
            this.btnprofile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnprofile.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnprofile.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnprofile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprofile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprofile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprofile.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprofile.ForeColor = System.Drawing.Color.White;
            this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
            this.btnprofile.ImageSize = new System.Drawing.Size(60, 60);
            this.btnprofile.Location = new System.Drawing.Point(65, 516);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(208, 45);
            this.btnprofile.TabIndex = 5;
            this.btnprofile.Text = "PROFILE";
            this.btnprofile.Click += new System.EventHandler(this.btnprofile_Click);
            // 
            // btnViewuser
            // 
            this.btnViewuser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewuser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewuser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnViewuser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewuser.ForeColor = System.Drawing.Color.White;
            this.btnViewuser.Image = ((System.Drawing.Image)(resources.GetObject("btnViewuser.Image")));
            this.btnViewuser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnViewuser.Location = new System.Drawing.Point(65, 434);
            this.btnViewuser.Name = "btnViewuser";
            this.btnViewuser.Size = new System.Drawing.Size(208, 45);
            this.btnViewuser.TabIndex = 4;
            this.btnViewuser.Text = "VIEW USER";
            this.btnViewuser.Click += new System.EventHandler(this.btnViewuser_Click);
            // 
            // btnAdduser
            // 
            this.btnAdduser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdduser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAdduser.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAdduser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdduser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdduser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdduser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdduser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdduser.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdduser.ForeColor = System.Drawing.Color.White;
            this.btnAdduser.Image = ((System.Drawing.Image)(resources.GetObject("btnAdduser.Image")));
            this.btnAdduser.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdduser.Location = new System.Drawing.Point(64, 353);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(208, 45);
            this.btnAdduser.TabIndex = 3;
            this.btnAdduser.Text = "ADD USER";
            this.btnAdduser.Click += new System.EventHandler(this.btnAdduser_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Dashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Dashboard.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Dashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Dashboard.Location = new System.Drawing.Point(64, 281);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(208, 45);
            this.btn_Dashboard.TabIndex = 2;
            this.btn_Dashboard.Text = "DASHBOARD";
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Profile1);
            this.panel2.Controls.Add(this.uC_Viewuser1);
            this.panel2.Controls.Add(this.uC_Adduser1);
            this.panel2.Controls.Add(this.uC_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(279, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 767);
            this.panel2.TabIndex = 1;
            // 
            // uC_Profile1
            // 
            this.uC_Profile1.BackColor = System.Drawing.Color.White;
            this.uC_Profile1.Location = new System.Drawing.Point(-3, 0);
            this.uC_Profile1.Name = "uC_Profile1";
            this.uC_Profile1.Size = new System.Drawing.Size(1089, 767);
            this.uC_Profile1.TabIndex = 3;
            // 
            // uC_Viewuser1
            // 
            this.uC_Viewuser1.BackColor = System.Drawing.Color.White;
            this.uC_Viewuser1.Location = new System.Drawing.Point(-3, 0);
            this.uC_Viewuser1.Name = "uC_Viewuser1";
            this.uC_Viewuser1.Size = new System.Drawing.Size(1089, 767);
            this.uC_Viewuser1.TabIndex = 2;
            // 
            // uC_Adduser1
            // 
            this.uC_Adduser1.BackColor = System.Drawing.Color.White;
            this.uC_Adduser1.Location = new System.Drawing.Point(-3, -1);
            this.uC_Adduser1.Name = "uC_Adduser1";
            this.uC_Adduser1.Size = new System.Drawing.Size(1089, 767);
            this.uC_Adduser1.TabIndex = 1;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1089, 767);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Dashboard;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnprofile;
        private Guna.UI2.WinForms.Guna2Button btnViewuser;
        private Guna.UI2.WinForms.Guna2Button btnAdduser;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AdministratorUC.UC_Dashboard uC_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AdministratorUC.UC_Adduser uC_Adduser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AdministratorUC.UC_Viewuser uC_Viewuser1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AdministratorUC.UC_Profile uC_Profile1;
    }
}