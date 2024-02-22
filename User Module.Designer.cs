
namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class User_Module
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_uName = new System.Windows.Forms.Label();
            this.txt_uName = new System.Windows.Forms.TextBox();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.lbl_fName = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lpl_password = new System.Windows.Forms.Label();
            this.txt_tp = new System.Windows.Forms.TextBox();
            this.ibl_tp = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_repassword = new System.Windows.Forms.TextBox();
            this.lbl_repassword = new System.Windows.Forms.Label();
            this.btn_otp = new System.Windows.Forms.Button();
            this.txt_otp = new System.Windows.Forms.TextBox();
            this.lbl_otpName = new System.Windows.Forms.Label();
            this.lbl_otp = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_cls);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 77);
            this.panel1.TabIndex = 0;
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(594, 3);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(24, 23);
            this.btn_cls.TabIndex = 1;
            this.btn_cls.Text = "X";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Module";
            // 
            // lbl_uName
            // 
            this.lbl_uName.AutoSize = true;
            this.lbl_uName.Location = new System.Drawing.Point(66, 106);
            this.lbl_uName.Name = "lbl_uName";
            this.lbl_uName.Size = new System.Drawing.Size(79, 17);
            this.lbl_uName.TabIndex = 1;
            this.lbl_uName.Text = "User Name";
            // 
            // txt_uName
            // 
            this.txt_uName.Location = new System.Drawing.Point(180, 101);
            this.txt_uName.Name = "txt_uName";
            this.txt_uName.Size = new System.Drawing.Size(391, 22);
            this.txt_uName.TabIndex = 2;
            // 
            // txt_fName
            // 
            this.txt_fName.Location = new System.Drawing.Point(180, 139);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(391, 22);
            this.txt_fName.TabIndex = 4;
            // 
            // lbl_fName
            // 
            this.lbl_fName.AutoSize = true;
            this.lbl_fName.Location = new System.Drawing.Point(66, 145);
            this.lbl_fName.Name = "lbl_fName";
            this.lbl_fName.Size = new System.Drawing.Size(71, 17);
            this.lbl_fName.TabIndex = 3;
            this.lbl_fName.Text = "Full Name";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(180, 171);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(391, 22);
            this.txt_password.TabIndex = 6;
            // 
            // lpl_password
            // 
            this.lpl_password.AutoSize = true;
            this.lpl_password.Location = new System.Drawing.Point(66, 177);
            this.lpl_password.Name = "lpl_password";
            this.lpl_password.Size = new System.Drawing.Size(69, 17);
            this.lpl_password.TabIndex = 5;
            this.lpl_password.Text = "Password";
            // 
            // txt_tp
            // 
            this.txt_tp.Location = new System.Drawing.Point(180, 226);
            this.txt_tp.MaxLength = 10;
            this.txt_tp.Name = "txt_tp";
            this.txt_tp.Size = new System.Drawing.Size(391, 22);
            this.txt_tp.TabIndex = 8;
            // 
            // ibl_tp
            // 
            this.ibl_tp.AutoSize = true;
            this.ibl_tp.Location = new System.Drawing.Point(66, 232);
            this.ibl_tp.Name = "ibl_tp";
            this.ibl_tp.Size = new System.Drawing.Size(103, 17);
            this.ibl_tp.TabIndex = 7;
            this.ibl_tp.Text = "Mobile Number";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.Transparent;
            this.btn_save.Location = new System.Drawing.Point(257, 354);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 37);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Olive;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.Transparent;
            this.btn_update.Location = new System.Drawing.Point(365, 354);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 37);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_clear.Location = new System.Drawing.Point(471, 354);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 37);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_repassword
            // 
            this.txt_repassword.Location = new System.Drawing.Point(180, 198);
            this.txt_repassword.Name = "txt_repassword";
            this.txt_repassword.Size = new System.Drawing.Size(391, 22);
            this.txt_repassword.TabIndex = 13;
            // 
            // lbl_repassword
            // 
            this.lbl_repassword.AutoSize = true;
            this.lbl_repassword.Location = new System.Drawing.Point(66, 204);
            this.lbl_repassword.Name = "lbl_repassword";
            this.lbl_repassword.Size = new System.Drawing.Size(92, 17);
            this.lbl_repassword.TabIndex = 12;
            this.lbl_repassword.Text = "Re-Password";
            // 
            // btn_otp
            // 
            this.btn_otp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_otp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_otp.ForeColor = System.Drawing.Color.Transparent;
            this.btn_otp.Location = new System.Drawing.Point(147, 354);
            this.btn_otp.Name = "btn_otp";
            this.btn_otp.Size = new System.Drawing.Size(94, 37);
            this.btn_otp.TabIndex = 14;
            this.btn_otp.Text = "Get OTP";
            this.btn_otp.UseVisualStyleBackColor = false;
            this.btn_otp.Click += new System.EventHandler(this.btn_otp_Click);
            // 
            // txt_otp
            // 
            this.txt_otp.Location = new System.Drawing.Point(180, 307);
            this.txt_otp.MaxLength = 4;
            this.txt_otp.Name = "txt_otp";
            this.txt_otp.Size = new System.Drawing.Size(88, 22);
            this.txt_otp.TabIndex = 15;
            // 
            // lbl_otpName
            // 
            this.lbl_otpName.AutoSize = true;
            this.lbl_otpName.Location = new System.Drawing.Point(66, 310);
            this.lbl_otpName.Name = "lbl_otpName";
            this.lbl_otpName.Size = new System.Drawing.Size(74, 17);
            this.lbl_otpName.TabIndex = 16;
            this.lbl_otpName.Text = "OTP Code";
            // 
            // lbl_otp
            // 
            this.lbl_otp.AutoSize = true;
            this.lbl_otp.Location = new System.Drawing.Point(305, 310);
            this.lbl_otp.Name = "lbl_otp";
            this.lbl_otp.Size = new System.Drawing.Size(12, 17);
            this.lbl_otp.TabIndex = 17;
            this.lbl_otp.Text = ".";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(180, 268);
            this.txt_email.MaxLength = 200;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(391, 22);
            this.txt_email.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email";
            // 
            // User_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_otp);
            this.Controls.Add(this.lbl_otpName);
            this.Controls.Add(this.txt_otp);
            this.Controls.Add(this.btn_otp);
            this.Controls.Add(this.txt_repassword);
            this.Controls.Add(this.lbl_repassword);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_tp);
            this.Controls.Add(this.ibl_tp);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lpl_password);
            this.Controls.Add(this.txt_fName);
            this.Controls.Add(this.lbl_fName);
            this.Controls.Add(this.txt_uName);
            this.Controls.Add(this.lbl_uName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Module";
            this.Text = "User_Module";
            this.Load += new System.EventHandler(this.User_Module_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_uName;
        public System.Windows.Forms.TextBox txt_uName;
        public System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.Label lbl_fName;
        public System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lpl_password;
        public System.Windows.Forms.TextBox txt_tp;
        private System.Windows.Forms.Label ibl_tp;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.TextBox txt_repassword;
        private System.Windows.Forms.Label lbl_repassword;
        public System.Windows.Forms.Button btn_otp;
        public System.Windows.Forms.TextBox txt_otp;
        public System.Windows.Forms.Label lbl_otpName;
        public System.Windows.Forms.Label lbl_otp;
        public System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
    }
}