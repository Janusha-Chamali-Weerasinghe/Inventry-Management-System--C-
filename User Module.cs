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
    public partial class User_Module : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V7BKP8H;Initial Catalog=Inventry_Managemnet_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        Email email = new Email();
        Reg_validation RegX = new Reg_validation();
        private string ErrorMsg = null;
        int GenareteOptCode;
        String Gototpcode;
        public User_Module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void User_Module_Load(object sender, EventArgs e)
        {
       
            if (txt_password != null)
            {
                txt_password.UseSystemPasswordChar = true;
                txt_repassword.UseSystemPasswordChar = true;
            }
            lbl_otp.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Form_validation() != false)
            {
                try
                {

                    if (txt_password.Text != txt_repassword.Text)
                    {
                        MessageBox.Show("Password did not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("INSERT INTO user_tbl(username,fullname,password,TP,Email)VALUES(@username,@fullname,@password,@TP,@Email)", con);
                        cmd.Parameters.AddWithValue("@username", txt_uName.Text);
                        cmd.Parameters.AddWithValue("@fullname", txt_fName.Text);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);
                        cmd.Parameters.AddWithValue("@TP", txt_tp.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("User has been successfully saved.");
                        otpfieldset();
                        email.Email_Send(txt_email.Text.ToString(), "Account successfully activated", $"{txt_fName.Text.ToString()} your account has been successfully activated.");
                        Clear();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(ErrorMsg, "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            {
                Clear();
                btn_save.Enabled = true;
                btn_update.Enabled = false;
            }
        }

        public void Clear()
        {
            txt_uName.Clear();
            txt_fName.Clear();
            txt_password.Clear();
            txt_repassword.Clear();
            txt_email.Clear();
            txt_tp.Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (Form_validation() != false && Otp_Validate())
            {
                try
                {

                    if (MessageBox.Show("Are you sure you want to update this user?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("Update user_tbl set username=@username,fullname=@fullname,password=@password,TP=@TP WHERE username LIKE '" + txt_uName.Text + "' ", con);
                        cmd.Parameters.AddWithValue("@username", txt_uName.Text);
                        cmd.Parameters.AddWithValue("@fullname", txt_fName.Text);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);
                        cmd.Parameters.AddWithValue("@TP", txt_tp.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_email.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        SetOtp(0);
                        MessageBox.Show("User has been successfully updated!");
                        email.Email_Send(txt_email.Text.ToString(), "Account successfully Reset", $"Dear {txt_fName.Text.ToString()} your account has been successfully reset .");
                        this.Dispose();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show(ErrorMsg, "Field Required Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public  bool Form_validation()
        {
            bool isValidate = true;
            ErrorMsg = null;

            if (RegX.Username_validate(txt_uName.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Username  \r\n";
            }
            if (RegX.Password_validate(txt_password.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Strong password Ex:!Q1w2e3r4  \r\n";
            }

            if (txt_password.Text != txt_repassword.Text)
            {
                ErrorMsg += "Password did not Match!";
                //MessageBox.Show("Password did not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValidate = false;
            }

            if (RegX.TelephoneNumber_validate(txt_tp.Text) != true)
            {
                isValidate = false;
                ErrorMsg += "Please Enter Valid Telephone number Format in Srilanka  \r\n";
            }            
            return isValidate;
        }

        public bool Otp_Validate()
        {
            bool isValidate = true;
            ErrorMsg = null;
            
            if (otpfieldsetGet() != txt_otp.Text.ToString())
            {
                isValidate = false;
                ErrorMsg += "Please Enter correct OTP  \r\n";
            }
            return isValidate;
        }


            public void SetOtp(int otpcode)
        {
            try
            {
                if(txt_uName != null && otpcode==0)
                {
                    //int code = GenarateOtp();
                    cmd = new SqlCommand("Update otp_tbl set otp=@otp WHERE username LIKE '" + txt_uName.Text + "' ", con);
                    //cmd.Parameters.AddWithValue("@username", txt_uName.Text);
                    cmd.Parameters.AddWithValue("@otp", otpcode);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("OTP Code has been successfully send.");
                    //email.Email_Send(txt_email.Text.ToString(), "OTP-Code", $"{txt_uName.Text.ToString()} your OTP code is : {otpcode} .");                    
                }
                else if (txt_uName != null)
                {
                    cmd = new SqlCommand("Update otp_tbl set otp=@otp WHERE username LIKE '" + txt_uName.Text + "' ", con);
                    //cmd.Parameters.AddWithValue("@username", txt_uName.Text);
                    cmd.Parameters.AddWithValue("@otp", otpcode);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("OTP Code has been successfully send.");
                    email.Email_Send(txt_email.Text.ToString(), "OTP-Code", $"{txt_uName.Text.ToString()} your OTP code is : {otpcode} .");
                }
                btn_update.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("E mail send error");
            }
            
        }

        public int GenarateOtp()
        {
            Random rnd = new Random();
            GenareteOptCode = rnd.Next(1111, 9999);
            return GenareteOptCode;
        }

        private void btn_otp_Click(object sender, EventArgs e)
        {
            SetOtp(GenarateOtp());
        }

        public void otpfieldset()
        {
            cmd = new SqlCommand("INSERT INTO otp_tbl(username,otp)VALUES(@username,0000)", con);
            cmd.Parameters.AddWithValue("@username", txt_uName.Text);
            //cmd.Parameters.AddWithValue("@otp", 0000);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void otpfieldsetUpd()
        {
            cmd = new SqlCommand("INSERT INTO otp_tbl(username,otp)VALUES(@username,0000)", con);
            cmd.Parameters.AddWithValue("@username", txt_uName.Text);
            //cmd.Parameters.AddWithValue("@otp", 0000);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string otpfieldsetGet()
        {
            try
            {
                cmd = new SqlCommand("SELECT otp FROM otp_tbl WHERE username LIKE '%" + txt_uName.Text + "%'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Gototpcode = Convert.ToInt32(dr[0].ToString());
                    Gototpcode = dr[0].ToString();
                }
                dr.Close();
                con.Close();                
            }

            catch (Exception)
            { 

            }
            return Gototpcode;
        }

        public bool checkOtpcorrect()
        {
            bool otpbool = false;
            if (txt_otp.Text== lbl_otp.Text)
            {
                MessageBox.Show("OTP Code is wrong please check");
                otpbool = true;
            }
            return otpbool;
        }
    }
}


