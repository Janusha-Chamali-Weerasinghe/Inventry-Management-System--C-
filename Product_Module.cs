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
    public partial class Product_Module : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Reg_validation RegX = new Reg_validation();
        string ErrorMsg ;
        public Product_Module()
        {
            InitializeComponent();
            LoadCategory();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LoadCategory()
        {
            cmb_category.Items.Clear();
            cmd = new SqlCommand("SELECT Name FROM Category_tbl", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_category.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form_validation()!=false)
                {
                    if (MessageBox.Show("Are you sure you want to save this product?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("INSERT INTO Product_tbl(Name,Qty,Price,Description,Category)VALUES(@Name,@Qty,@Price,@Description,@Category)", con);

                        cmd.Parameters.AddWithValue("@Name", txt_pName.Text);
                        cmd.Parameters.AddWithValue("@Qty", Convert.ToInt16(txt_pQty.Text));
                        cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(txt_pPrice.Text));
                        cmd.Parameters.AddWithValue("@Description", txt_pdecscrition.Text);
                        cmd.Parameters.AddWithValue("@Category", cmb_category.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product has been successfully saved.");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show(ErrorMsg, "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



        }
        public void Clear()
        {
            txt_pName.Clear();
            txt_pQty.Clear();
            txt_pPrice.Clear();
            txt_pdecscrition.Clear();
            cmb_category.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
            btn_save.Enabled = true;
            btn_update.Enabled = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form_validation() != false)
                {
                    if (MessageBox.Show("Are you sure you want to update this product?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("UPDATE Product_tbl SET Name= @Name, Qty=@Qty, Price=@Price, Description=@Description, Category=@Category WHERE Product_ID LIKE '" + lblPid.Text + "' ", con);
                        cmd.Parameters.AddWithValue("@Name", txt_pName.Text);
                        cmd.Parameters.AddWithValue("@Qty", Convert.ToInt16(txt_pQty.Text));
                        cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(txt_pPrice.Text));
                        cmd.Parameters.AddWithValue("@Description", txt_pdecscrition.Text);
                        cmd.Parameters.AddWithValue("@Category", cmb_category.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product has been successfully updated!");
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(ErrorMsg, "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

      

        public bool Form_validation()
        {
            bool isValidate = true;
            ErrorMsg = null;

            if (RegX.FullName(txt_pName.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Product Name  \r\n";
            }
            if (RegX.Price(txt_pPrice.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Price  \r\n";
            }
            if (RegX.Quantity(txt_pQty.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Quantity  \r\n";
            }
            if (RegX.Description(txt_pdecscrition.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Description \r\n";
            }
            if (cmb_category.SelectedIndex == -1)
            {
                isValidate = false;
                ErrorMsg += "Please Select Category \r\n";
            }

            return isValidate;
        }
    }
}
