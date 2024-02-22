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
    public partial class Category_Module : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        Reg_validation RegX = new Reg_validation();
        public Category_Module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                if (RegX.OneSpaceAndLettersOnly(txt_categoryName.Text) != false)
                {
                    if (MessageBox.Show("Are you sure you want to save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("INSERT INTO Category_tbl(Name)VALUES(@Name)", con);
                        cmd.Parameters.AddWithValue("@Name", txt_categoryName.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Category has been successfully saved.");
                        Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter vaild category name", "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            txt_categoryName.Clear();
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
                if (RegX.OneSpaceAndLettersOnly(txt_categoryName.Text) != false)
                {
                    if (MessageBox.Show("Are you sure you want to update this Category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("UPDATE Category_tbl SET Name = @Name WHERE Category_ID LIKE '" + lblCatId.Text + "' ", con);
                        cmd.Parameters.AddWithValue("@Name", txt_categoryName.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Category has been successfully updated!");
                        this.Dispose();
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter vaild category name", "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }


}
