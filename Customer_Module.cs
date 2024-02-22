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
    public partial class Customer_Module : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        Reg_validation RegX = new Reg_validation();
        string ErrorMsg;
        
        public Customer_Module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            Clear();
            btn_save.Enabled = true;
            btn_update.Enabled = false;
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form_validation() != false)
                {
                    if (MessageBox.Show("Are you sure you want to save this customer?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("INSERT INTO Customer_tbl(CName,CAddress,TP_Number)VALUES(@CName,@CAddress,@TP_Number)", con);
                        cmd.Parameters.AddWithValue("@CName", txt_name.Text);
                        cmd.Parameters.AddWithValue("@CAddress", txt_address.Text);
                        cmd.Parameters.AddWithValue("@TP_Number", txt_tp.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User has been successfully saved.");
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
            txt_name.Clear();
            txt_address.Clear();
            txt_tp.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form_validation()!=false)
                {
                    if (MessageBox.Show("Are you sure you want to update this Customer?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("UPDATE Customer_tbl SET CName = @CName,CAddress=@CAddress,TP_Number=@TP_Number WHERE Cid LIKE '" + lblCId.Text + "' ", con);
                        cmd.Parameters.AddWithValue("@CName", txt_name.Text);
                        cmd.Parameters.AddWithValue("@CAddress", txt_address.Text);
                        cmd.Parameters.AddWithValue("@TP_Number", txt_tp.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Customer has been successfully updated!");
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

            if (RegX.FullName(txt_name.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Name  \r\n";
            }
            if (RegX.Address(txt_address.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Address  \r\n";
            }
            if (RegX.TelephoneNumber_validate(txt_tp.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Mobile Number  \r\n";
            }

            return isValidate;
        }

    }
}
