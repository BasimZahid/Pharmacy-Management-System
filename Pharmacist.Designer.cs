namespace project3
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMachine = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedValidity = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMed = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_P_MedicineValidityCheck1 = new project3.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_ModifyMedicine1 = new project3.PharmacistUC.UC_P_ModifyMedicine();
            this.uC_P_ViewMedicine1 = new project3.PharmacistUC.UC_P_ViewMedicine();
            this.uC_P_AddMedicine1 = new project3.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashboard1 = new project3.PharmacistUC.UC_P_Dashboard();
            this.uC_P_SellMedicine1 = new project3.PharmacistUC.UC_P_SellMedicine();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnSellMachine);
            this.panel1.Controls.Add(this.btnMedValidity);
            this.panel1.Controls.Add(this.btnModifyMed);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 760);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.FillColor = System.Drawing.Color.Cyan;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnlogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnlogout.Location = new System.Drawing.Point(31, 659);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(241, 45);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnSellMachine
            // 
            this.btnSellMachine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMachine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMachine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMachine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellMachine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellMachine.FillColor = System.Drawing.Color.Cyan;
            this.btnSellMachine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMachine.ForeColor = System.Drawing.Color.White;
            this.btnSellMachine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSellMachine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMachine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMachine.Image")));
            this.btnSellMachine.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSellMachine.Location = new System.Drawing.Point(31, 591);
            this.btnSellMachine.Name = "btnSellMachine";
            this.btnSellMachine.Size = new System.Drawing.Size(241, 45);
            this.btnSellMachine.TabIndex = 7;
            this.btnSellMachine.Text = "SELL MEDICINE";
            this.btnSellMachine.Click += new System.EventHandler(this.btnSellMachine_Click);
            // 
            // btnMedValidity
            // 
            this.btnMedValidity.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedValidity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedValidity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedValidity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedValidity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedValidity.FillColor = System.Drawing.Color.Cyan;
            this.btnMedValidity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedValidity.ForeColor = System.Drawing.Color.White;
            this.btnMedValidity.HoverState.FillColor = System.Drawing.Color.White;
            this.btnMedValidity.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnMedValidity.Image = ((System.Drawing.Image)(resources.GetObject("btnMedValidity.Image")));
            this.btnMedValidity.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMedValidity.Location = new System.Drawing.Point(34, 527);
            this.btnMedValidity.Name = "btnMedValidity";
            this.btnMedValidity.Size = new System.Drawing.Size(241, 45);
            this.btnMedValidity.TabIndex = 6;
            this.btnMedValidity.Text = "MEDICINE VALIDITY CHECK";
            this.btnMedValidity.Click += new System.EventHandler(this.btnMedValidity_Click);
            // 
            // btnModifyMed
            // 
            this.btnModifyMed.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifyMed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifyMed.FillColor = System.Drawing.Color.Cyan;
            this.btnModifyMed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyMed.ForeColor = System.Drawing.Color.White;
            this.btnModifyMed.HoverState.FillColor = System.Drawing.Color.White;
            this.btnModifyMed.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMed.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMed.Image")));
            this.btnModifyMed.ImageSize = new System.Drawing.Size(30, 30);
            this.btnModifyMed.Location = new System.Drawing.Point(34, 466);
            this.btnModifyMed.Name = "btnModifyMed";
            this.btnModifyMed.Size = new System.Drawing.Size(241, 45);
            this.btnModifyMed.TabIndex = 5;
            this.btnModifyMed.Text = "MODIFY MEDICINE";
            this.btnModifyMed.Click += new System.EventHandler(this.btnModifyMed_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMedicine.FillColor = System.Drawing.Color.Cyan;
            this.btnViewMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicine.Location = new System.Drawing.Point(34, 415);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(241, 45);
            this.btnViewMedicine.TabIndex = 4;
            this.btnViewMedicine.Text = "VIEW MEDICINE";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.Cyan;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(40, 30);
            this.btnAddMedicine.Location = new System.Drawing.Point(31, 347);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(241, 45);
            this.btnAddMedicine.TabIndex = 3;
            this.btnAddMedicine.Text = "ADD MEDICINE";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.Cyan;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDashboard.Location = new System.Drawing.Point(31, 287);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(241, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHARMACIST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_P_SellMedicine1);
            this.panel2.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.uC_P_ModifyMedicine1);
            this.panel2.Controls.Add(this.uC_P_ViewMedicine1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uC_P_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(278, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 748);
            this.panel2.TabIndex = 1;
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
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(-1, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1089, 767);
            this.uC_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // uC_P_ModifyMedicine1
            // 
            this.uC_P_ModifyMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_ModifyMedicine1.Location = new System.Drawing.Point(-1, 0);
            this.uC_P_ModifyMedicine1.Name = "uC_P_ModifyMedicine1";
            this.uC_P_ModifyMedicine1.Size = new System.Drawing.Size(1089, 767);
            this.uC_P_ModifyMedicine1.TabIndex = 3;
            // 
            // uC_P_ViewMedicine1
            // 
            this.uC_P_ViewMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicine1.Location = new System.Drawing.Point(-1, 0);
            this.uC_P_ViewMedicine1.Name = "uC_P_ViewMedicine1";
            this.uC_P_ViewMedicine1.Size = new System.Drawing.Size(1089, 767);
            this.uC_P_ViewMedicine1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(-1, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1089, 767);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashboard1
            // 
            this.uC_P_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashboard1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Dashboard1.Name = "uC_P_Dashboard1";
            this.uC_P_Dashboard1.Size = new System.Drawing.Size(1089, 767);
            this.uC_P_Dashboard1.TabIndex = 0;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(-1, 0);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(1089, 767);
            this.uC_P_SellMedicine1.TabIndex = 5;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacistcs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnSellMachine;
        private Guna.UI2.WinForms.Guna2Button btnMedValidity;
        private Guna.UI2.WinForms.Guna2Button btnModifyMed;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashboard uC_P_Dashboard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicine uC_P_ViewMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_ModifyMedicine uC_P_ModifyMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
    }
}