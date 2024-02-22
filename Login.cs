using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INVENTORY_MANAGEMENT_SYSTEM
{

    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                cm = new SqlCommand("SELECT * FROM user_tbl WHERE username=@username AND password=@password", con);
                cm.Parameters.AddWithValue("@username", txt_userName.Text);
                cm.Parameters.AddWithValue("@password", txt_password.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome " + dr["fullname"].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HOME main = new HOME();
                    this.Hide();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "ACCESS DENITED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chb_passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_passCheck.Checked == false)
                txt_password.UseSystemPasswordChar = true;
            else
                txt_password.UseSystemPasswordChar = false;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_userName.Clear();
            txt_password.Clear();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Applicaton", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

}
