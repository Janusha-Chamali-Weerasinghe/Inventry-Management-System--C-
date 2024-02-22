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
    
    public partial class Manage_Products : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Manage_Products()
        {
            InitializeComponent();
            LoadProduct();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadProduct()
        {
            try {
                int i = 0;
                dgv_product.Rows.Clear();
                cmd = new SqlCommand("SELECT * FROM Product_tbl WHERE CONCAT(Name,Qty,Price,Description,Category) LIKE '%" + txt_search.Text + "%'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgv_product.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
                dr.Close();
                con.Close();
            } 
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           Product_Module formModule = new Product_Module();
            formModule.btn_save.Enabled = true;
            formModule.btn_update.Enabled = false;
            formModule.ShowDialog();
            LoadProduct();

        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgv_product.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                Product_Module productModule = new Product_Module();
                productModule.lblPid.Text = dgv_product.Rows[e.RowIndex].Cells[1].Value.ToString();
                productModule.txt_pName.Text = dgv_product.Rows[e.RowIndex].Cells[2].Value.ToString();
                productModule.txt_pQty.Text = dgv_product.Rows[e.RowIndex].Cells[3].Value.ToString();
                productModule.txt_pPrice.Text = dgv_product.Rows[e.RowIndex].Cells[4].Value.ToString();
                productModule.txt_pdecscrition.Text = dgv_product.Rows[e.RowIndex].Cells[5].Value.ToString();
                productModule.cmb_category.Text = dgv_product.Rows[e.RowIndex].Cells[6].Value.ToString();

                productModule.btn_save.Enabled = false;
                productModule.btn_update.Enabled = true;
                productModule.ShowDialog();
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Product_tbl WHERE Product_Id LIKE '" + dgv_product.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
                LoadProduct();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }
    }

   
    }
