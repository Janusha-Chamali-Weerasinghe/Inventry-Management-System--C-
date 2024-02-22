
namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class Category_Module
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_categoryName = new System.Windows.Forms.TextBox();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.lblCatId = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_cls);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 80);
            this.panel1.TabIndex = 52;
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(589, 3);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(24, 23);
            this.btn_cls.TabIndex = 53;
            this.btn_cls.Text = "X";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Category Module";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(464, 207);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 37);
            this.btn_clear.TabIndex = 50;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Olive;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(364, 207);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 37);
            this.btn_update.TabIndex = 49;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(264, 207);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 37);
            this.btn_save.TabIndex = 48;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_categoryName
            // 
            this.txt_categoryName.Location = new System.Drawing.Point(188, 124);
            this.txt_categoryName.Name = "txt_categoryName";
            this.txt_categoryName.Size = new System.Drawing.Size(396, 22);
            this.txt_categoryName.TabIndex = 47;
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Location = new System.Drawing.Point(67, 126);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(118, 17);
            this.lbl_categoryName.TabIndex = 46;
            this.lbl_categoryName.Text = "Category Name : ";
            // 
            // lblCatId
            // 
            this.lblCatId.AutoSize = true;
            this.lblCatId.Location = new System.Drawing.Point(67, 179);
            this.lblCatId.Name = "lblCatId";
            this.lblCatId.Size = new System.Drawing.Size(82, 17);
            this.lblCatId.TabIndex = 53;
            this.lblCatId.Text = "Category ID";
            this.lblCatId.Visible = false;
            // 
            // Category_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.lblCatId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_categoryName);
            this.Controls.Add(this.lbl_categoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category_Module";
            this.Text = "Category_Module";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.Button btn_cls;
        public System.Windows.Forms.Label lblCatId;
    }
}