using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    public partial class Manage_Customers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Manage_Customers()
        {
            InitializeComponent();
            LoadCustomer();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadCustomer()
        {
            try {
                int i = 0;
                dgv_customer.Rows.Clear();
                cmd = new SqlCommand("SELECT * FROM Customer_tbl", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgv_customer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string colName = dgv_customer.Columns[e.ColumnIndex].Name;
                if (colName == "edit")
                {
                    Customer_Module customerModule = new Customer_Module();
                    
                    customerModule.txt_name.Text = dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                    customerModule.txt_address.Text = dgv_customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                    customerModule.txt_tp.Text = dgv_customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                    customerModule.lblCId.Text = dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString();

                    customerModule.btn_save.Enabled = false;
                    customerModule.btn_update.Enabled = true;

                    customerModule.ShowDialog();
                }
                else if (colName == "delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM Customer_tbl WHERE username LIKE '" + dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record has been successfully deleted!");
                    }
                }
                LoadCustomer();
                InitializeComponent();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            Customer_Module customerModule = new Customer_Module();
            customerModule.btn_save.Enabled = true;
            customerModule.btn_update.Enabled = false;
            customerModule.ShowDialog();
            LoadCustomer();
        }
    }
}
