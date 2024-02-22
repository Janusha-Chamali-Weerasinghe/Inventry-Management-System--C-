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
    public partial class Manage_categories : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Manage_categories()
        {
            InitializeComponent();
            LoadCategory();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        public void LoadCategory()
        {
            try
            {
                int i = 0;
                dgv_categories.Rows.Clear();
                cmd = new SqlCommand("SELECT * FROM Category_tbl", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgv_categories.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            Category_Module formModule = new Category_Module();
            formModule.btn_save.Enabled = true;
            formModule.btn_update.Enabled = false;
            formModule.ShowDialog();
            LoadCategory();

        }
        private void dgv_categories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string colName = dgv_categories.Columns[e.ColumnIndex].Name;
                if (colName == "edit")
                {
                    Category_Module formModule = new Category_Module();
                    formModule.lblCatId.Text = dgv_categories.Rows[e.RowIndex].Cells[1].Value.ToString();
                    formModule.txt_categoryName.Text = dgv_categories.Rows[e.RowIndex].Cells[2].Value.ToString();

                    formModule.btn_save.Enabled = false;
                    formModule.btn_update.Enabled = true;
                    formModule.ShowDialog();
                }
                else if (colName == "delete")
                {
                    if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM Category_tbl WHERE category_ID LIKE '" + dgv_categories.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record has been successfully deleted!");
                    }
                }
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
