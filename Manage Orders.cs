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
    public partial class Manage_Orders : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Manage_Orders()
        {
            InitializeComponent();
            LoadOrder();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void LoadOrder()
        {
            try
            {
                double total = 0;
                int i = 0;
                dgv_orders.Rows.Clear();
                cmd = new SqlCommand("SELECT OId,Date,Ord.PID,prd.Name,Ord.CID,Cus.CName,Ord.Qty,Ord.Price,Ord.Total_Amount FROM Order_tbl AS Ord JOIN Customer_tbl AS Cus ON Ord.CID=Cus.Cid JOIN Product_tbl AS Prd ON Ord.PID=Prd.Product_ID WHERE CONCAT(OId,Date,Ord.PID,Prd.Name,Ord.CID,Cus.CName,Ord.Qty,Ord.Price,Ord.Total_Amount) LIKE '%" + txt_search.Text + "%'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgv_orders.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                    total += Convert.ToInt32(dr[8].ToString());
                }
                dr.Close();
                con.Close();

                lblQty.Text = i.ToString();
                lbltotal.Text = total.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order_Module moduleForm = new Order_Module();
            moduleForm.ShowDialog();
            LoadOrder();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgv_orders.Columns[e.ColumnIndex].Name;

                if (colName == "delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this order?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM Order_tbl WHERE OId LIKE '" + dgv_orders.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record has been successfully deleted!");

                        cmd = new SqlCommand("UPDATE Product_tbl SET Qty=(Qty+@Qty) WHERE PID LIKE '" + dgv_orders.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", con);
                        cmd.Parameters.AddWithValue("@Qty", Convert.ToInt16(dgv_orders.Rows[e.RowIndex].Cells[5].Value.ToString()));

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                }
                LoadOrder();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
*/
        private void btn_add_Click(object sender, EventArgs e)
        {
            Order_Module moduleForm = new Order_Module();
            moduleForm.ShowDialog();
            LoadOrder();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            OrderReport or = new OrderReport();
            or.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    
    }
}
