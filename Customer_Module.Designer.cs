
namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class Customer_Module
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_tp = new System.Windows.Forms.TextBox();
            this.lbl_tp = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cls = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(128, 113);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(357, 110);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(408, 22);
            this.txt_name.TabIndex = 1;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(357, 164);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(408, 22);
            this.txt_address.TabIndex = 3;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(128, 167);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 17);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Address";
            // 
            // txt_tp
            // 
            this.txt_tp.Location = new System.Drawing.Point(357, 211);
            this.txt_tp.MaxLength = 10;
            this.txt_tp.Name = "txt_tp";
            this.txt_tp.Size = new System.Drawing.Size(131, 22);
            this.txt_tp.TabIndex = 5;
            // 
            // lbl_tp
            // 
            this.lbl_tp.AutoSize = true;
            this.lbl_tp.Location = new System.Drawing.Point(128, 214);
            this.lbl_tp.Name = "lbl_tp";
            this.lbl_tp.Size = new System.Drawing.Size(103, 17);
            this.lbl_tp.TabIndex = 4;
            this.lbl_tp.Text = "Mobile Number";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_save.Location = new System.Drawing.Point(209, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 37);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Olive;
            this.btn_update.Location = new System.Drawing.Point(357, 328);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 37);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.Color.Red;
            this.btn_clr.Location = new System.Drawing.Point(489, 328);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(94, 37);
            this.btn_clr.TabIndex = 8;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_cls);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 9;
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(773, 0);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(24, 23);
            this.btn_cls.TabIndex = 10;
            this.btn_cls.Text = "X";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Customer Module";
            // 
            // lblCId
            // 
            this.lblCId.AutoSize = true;
            this.lblCId.Location = new System.Drawing.Point(134, 285);
            this.lblCId.Name = "lblCId";
            this.lblCId.Size = new System.Drawing.Size(16, 17);
            this.lblCId.TabIndex = 10;
            this.lblCId.Text = "0";
            this.lblCId.Visible = false;
            // 
            // Customer_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_tp);
            this.Controls.Add(this.lbl_tp);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Module";
            this.Text = "Customer_Module";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        public System.Windows.Forms.TextBox txt_tp;
        private System.Windows.Forms.Label lbl_tp;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_cls;
        public System.Windows.Forms.Label lblCId;
    }
}