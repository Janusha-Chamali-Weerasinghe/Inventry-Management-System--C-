
namespace INVENTORY_MANAGEMENT_SYSTEM
{
    partial class Product_Module
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.txt_pdecscrition = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_pPrice = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_pQty = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_pName = new System.Windows.Forms.TextBox();
            this.lbl_pName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cls = new System.Windows.Forms.Button();
            this.lblPid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product Module";
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(185, 261);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(396, 24);
            this.cmb_category.TabIndex = 43;
            // 
            // txt_pdecscrition
            // 
            this.txt_pdecscrition.Location = new System.Drawing.Point(185, 215);
            this.txt_pdecscrition.Name = "txt_pdecscrition";
            this.txt_pdecscrition.Size = new System.Drawing.Size(396, 22);
            this.txt_pdecscrition.TabIndex = 42;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(82, 218);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(91, 17);
            this.lbl_description.TabIndex = 41;
            this.lbl_description.Text = "Description : ";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(483, 309);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 37);
            this.btn_clear.TabIndex = 40;
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
            this.btn_update.Location = new System.Drawing.Point(383, 309);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 37);
            this.btn_update.TabIndex = 39;
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
            this.btn_save.Location = new System.Drawing.Point(283, 309);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 37);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(94, 261);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(77, 17);
            this.lbl_category.TabIndex = 37;
            this.lbl_category.Text = "Category : ";
            // 
            // txt_pPrice
            // 
            this.txt_pPrice.Location = new System.Drawing.Point(185, 172);
            this.txt_pPrice.Name = "txt_pPrice";
            this.txt_pPrice.Size = new System.Drawing.Size(396, 22);
            this.txt_pPrice.TabIndex = 36;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(120, 175);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(52, 17);
            this.lbl_price.TabIndex = 35;
            this.lbl_price.Text = "Price : ";
            // 
            // txt_pQty
            // 
            this.txt_pQty.Location = new System.Drawing.Point(185, 129);
            this.txt_pQty.Name = "txt_pQty";
            this.txt_pQty.Size = new System.Drawing.Size(396, 22);
            this.txt_pQty.TabIndex = 34;
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(99, 132);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(73, 17);
            this.lbl_qty.TabIndex = 33;
            this.lbl_qty.Text = "Quantity : ";
            // 
            // txt_pName
            // 
            this.txt_pName.Location = new System.Drawing.Point(185, 86);
            this.txt_pName.Name = "txt_pName";
            this.txt_pName.Size = new System.Drawing.Size(396, 22);
            this.txt_pName.TabIndex = 32;
            // 
            // lbl_pName
            // 
            this.lbl_pName.AutoSize = true;
            this.lbl_pName.Location = new System.Drawing.Point(64, 88);
            this.lbl_pName.Name = "lbl_pName";
            this.lbl_pName.Size = new System.Drawing.Size(110, 17);
            this.lbl_pName.TabIndex = 31;
            this.lbl_pName.Text = "Product Name : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_cls);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 45;
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(773, 3);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(24, 23);
            this.btn_cls.TabIndex = 31;
            this.btn_cls.Text = "X";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(94, 319);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(77, 17);
            this.lblPid.TabIndex = 46;
            this.lblPid.Text = "Category : ";
            this.lblPid.Visible = false;
            // 
            // Product_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.txt_pdecscrition);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.txt_pPrice);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_pQty);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.txt_pName);
            this.Controls.Add(this.lbl_pName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Module";
            this.Text = "Product_Module";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmb_category;
        public System.Windows.Forms.TextBox txt_pdecscrition;
        private System.Windows.Forms.Label lbl_description;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_category;
        public System.Windows.Forms.TextBox txt_pPrice;
        private System.Windows.Forms.Label lbl_price;
        public System.Windows.Forms.TextBox txt_pQty;
        private System.Windows.Forms.Label lbl_qty;
        public System.Windows.Forms.TextBox txt_pName;
        private System.Windows.Forms.Label lbl_pName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cls;
        public System.Windows.Forms.Label lblPid;
    }
}