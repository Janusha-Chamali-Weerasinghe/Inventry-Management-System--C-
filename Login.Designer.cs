
namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.chb_passCheck = new System.Windows.Forms.CheckBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cls = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_clr);
            this.panel1.Controls.Add(this.chb_passCheck);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_userName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_userName);
            this.panel1.Location = new System.Drawing.Point(55, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 311);
            this.panel1.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(367, 196);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(112, 42);
            this.btn_login.TabIndex = 17;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(339, 274);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(59, 23);
            this.btn_clr.TabIndex = 15;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // chb_passCheck
            // 
            this.chb_passCheck.AutoSize = true;
            this.chb_passCheck.ForeColor = System.Drawing.Color.Aqua;
            this.chb_passCheck.Location = new System.Drawing.Point(430, 274);
            this.chb_passCheck.Name = "chb_passCheck";
            this.chb_passCheck.Size = new System.Drawing.Size(129, 21);
            this.chb_passCheck.TabIndex = 14;
            this.chb_passCheck.Text = "Show Password";
            this.chb_passCheck.UseVisualStyleBackColor = true;
            this.chb_passCheck.CheckedChanged += new System.EventHandler(this.chb_passCheck_CheckedChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(372, 151);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(102, 22);
            this.txt_password.TabIndex = 13;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(372, 80);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(102, 22);
            this.txt_userName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(145)))), ((int)(((byte)(205)))));
            this.label3.Location = new System.Drawing.Point(382, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login First";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_password.Location = new System.Drawing.Point(389, 122);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(69, 17);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Password";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_userName.Location = new System.Drawing.Point(384, 51);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(79, 17);
            this.lbl_userName.TabIndex = 9;
            this.lbl_userName.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(687, 1);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(24, 23);
            this.btn_cls.TabIndex = 7;
            this.btn_cls.Text = "X";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::INVENTORY_MANAGEMENT_SYSTEM.Properties.Resources.inventry_systemjpeg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 311);
            this.panel2.TabIndex = 18;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 484);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.CheckBox chb_passCheck;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Panel panel2;
    }
}

