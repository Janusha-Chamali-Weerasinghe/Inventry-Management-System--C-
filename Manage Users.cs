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
    public partial class Manage_Users : Form
    {         
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        ////cloud databse
        //SqlConnection con = new SqlConnection(@"Data Source=SQL8004.site4now.net,1433;Initial Catalog=db_a8b212_inventorymngsys;User Id=db_a8b212_inventorymngsys_admin;Password=22002@chimp");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        
        public Manage_Users()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadUser();
        }
        public void LoadUser()
        {
            try
            {
                int i = 0;
                dgv_user.Rows.Clear();
                cmd = new SqlCommand("SELECT user_tbl.username,user_tbl.fullname,user_tbl.password,user_tbl.TP,Email,otp_tbl.otp FROM user_tbl JOIN otp_tbl ON otp_tbl.username=user_tbl.username", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgv_user.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            User_Module userModule = new User_Module();
            userModule.btn_save.Enabled = true;
            userModule.btn_update.Enabled = false;
            userModule.txt_otp.Visible = false;
            userModule.btn_otp.Visible = false;
            userModule.lbl_otp.Visible = false; 
            userModule.lbl_otpName.Visible = false;
            userModule.txt_email.ReadOnly = false;            
            userModule.ShowDialog();
            LoadUser();
        }


        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string colName = dgv_user.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                User_Module userModule = new User_Module();
                userModule.txt_uName.Text = dgv_user.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txt_fName.Text = dgv_user.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txt_password.Text = dgv_user.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txt_tp.Text = dgv_user.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.txt_email.Text = dgv_user.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.lbl_otp.Text = dgv_user.Rows[e.RowIndex].Cells[6].Value.ToString();

                userModule.txt_email.ReadOnly = true;
                userModule.btn_save.Enabled = false;
                userModule.btn_update.Enabled = false;
                userModule.txt_uName.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM user_tbl WHERE username LIKE '" + dgv_user.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    otpfieldsetDel(dgv_user.Rows[e.RowIndex].Cells[1].Value.ToString());
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadUser();

        }

        private void dgv_user_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 3 ) && e.Value != null)
            {
                dgv_user.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        public void otpfieldsetDel(String Username)
        {
            cmd = new SqlCommand("DELETE FROM otp_tbl WHERE username LIKE '" + Username + "'", con);
            cmd.Parameters.AddWithValue("@username", Username);
            //cmd.Parameters.AddWithValue("@otp", 0000);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
