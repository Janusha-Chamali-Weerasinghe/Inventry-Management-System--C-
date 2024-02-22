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
    public partial class Order_Module : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int qty = 0;
        Reg_validation RegX = new Reg_validation();
      
        public Order_Module()
        {
            InitializeComponent();
            LoadCustomer();
            LoadProduct();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadCustomer()
        {
            int i = 0;
            dgv_customer.Rows.Clear();
            cmd = new SqlCommand("SELECT Cid, Cname FROM Customer_tbl WHERE CONCAT(Cid, Cname) LIKE '%" + txt_searchCustomer.Text + "%'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_customer.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgv_product.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM Product_tbl WHERE CONCAT(Product_ID,Name,Price,Description,Category) LIKE '%" + txt_searchProduct.Text + "%'", con);
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


        private void txt_searchCustomer_TextChanged(object sender, EventArgs e)
        {/*
            if (RegX.Address(txt_searchCustomer.Text) != false)
            {
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Customer Details", "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            LoadCustomer();

        }

        private void txt_searchProduct_TextChanged(object sender, EventArgs e)
        {
            /*if (RegX.Address(txt_searchProduct.Text) !=false)
            {
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Product Details", "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            LoadCustomer();
        }

        private void UDQty_ValueChanged(object sender, EventArgs e)
        {
            GetQty();
            if (Convert.ToInt16(UDQty.Value) > qty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQty.Value = UDQty.Value - 1;
                return;
            }
            if (Convert.ToInt16(UDQty.Value) > 0)
            {
                int total = Convert.ToInt32(txt_price.Text) * Convert.ToInt32(UDQty.Value);
                txt_total.Text = total.ToString();
            }

        }

        public void GetQty()
        {
            cmd = new SqlCommand("SELECT Qty FROM Product_tbl WHERE Product_ID='" + txt_Product_ID.Text + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                qty = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Cid.Text = dgv_customer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_CName.Text = dgv_customer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Product_ID.Text = dgv_product.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_PName.Text = dgv_product.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_price.Text = dgv_product.Rows[e.RowIndex].Cells[4].Value.ToString();
        }


        public void Clear()
        {
            txt_Cid.Clear();
            txt_CName.Clear();

            txt_Product_ID.Clear();
            txt_PName.Clear();

            txt_price.Clear();
            UDQty.Value = 0;
            txt_total.Clear();
            dtOrder.Value = DateTime.Now;
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Cid.Text == "")
                {
                    MessageBox.Show("Please select customer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txt_Product_ID.Text == "")
                {
                    MessageBox.Show("Please select product!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to insert this order?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cmd = new SqlCommand("INSERT INTO Order_tbl(Date,PID,CID,Qty,Price,Total_Amount)VALUES(@Date,@PID,@CID,@Qty,@Price,@Total_Amount)", con);
                    cmd.Parameters.AddWithValue("@Date", dtOrder.Value);
                    cmd.Parameters.AddWithValue("@PID", Convert.ToInt32(txt_Product_ID.Text));
                    cmd.Parameters.AddWithValue("@CID", Convert.ToInt32(txt_Cid.Text));
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(UDQty.Value));
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(txt_price.Text));
                    cmd.Parameters.AddWithValue("@Total_Amount", Convert.ToInt32(txt_total.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Order has been successfully inserted.");


                    cmd = new SqlCommand("UPDATE Product_tbl SET Qty=(Qty-@Qty) WHERE Product_ID LIKE '" + txt_Product_ID.Text + "' ", con);
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(UDQty.Value));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadProduct();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            Clear();
        }

        
        
    }
}
