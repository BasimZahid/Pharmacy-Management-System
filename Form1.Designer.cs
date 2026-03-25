namespace project3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsignin = new Guna.UI2.WinForms.Guna2Button();
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(1322, 18);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(46, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(823, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "SIGN IN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "USER NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "PASSWORD";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Silver;
            this.txtusername.BorderColor = System.Drawing.Color.Black;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Location = new System.Drawing.Point(692, 241);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "";
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(320, 40);
            this.txtusername.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Silver;
            this.txtpassword.BorderColor = System.Drawing.Color.Black;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(692, 452);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PlaceholderText = "";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(320, 41);
            this.txtpassword.TabIndex = 8;
            // 
            // btnsignin
            // 
            this.btnsignin.BorderRadius = 15;
            this.btnsignin.BorderThickness = 1;
            this.btnsignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsignin.FillColor = System.Drawing.Color.Navy;
            this.btnsignin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.White;
            this.btnsignin.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnsignin.HoverState.FillColor = System.Drawing.Color.White;
            this.btnsignin.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnsignin.Image = ((System.Drawing.Image)(resources.GetObject("btnsignin.Image")));
            this.btnsignin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsignin.Location = new System.Drawing.Point(730, 522);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(180, 45);
            this.btnsignin.TabIndex = 9;
            this.btnsignin.Text = "SIGN IN";
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // btnreset
            // 
            this.btnreset.BorderRadius = 15;
            this.btnreset.BorderThickness = 1;
            this.btnreset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreset.FillColor = System.Drawing.Color.Navy;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnreset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnreset.HoverState.ForeColor = System.Drawing.Color.Navy;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnreset.Location = new System.Drawing.Point(978, 522);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(180, 45);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "RESET";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 764);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(377, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 764);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 281);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(359, 373);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(3, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHARMACY \r\nMANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2Button btnsignin;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

