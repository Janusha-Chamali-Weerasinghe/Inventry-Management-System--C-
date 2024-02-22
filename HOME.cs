using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btn_user_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Users());
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Products());
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_categories());
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Customers());
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_Orders());
        }
    }
}
