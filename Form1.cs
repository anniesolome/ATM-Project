using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class LoginForm : Form
    {
        static int count = 0;
        public static string Username;
        public static string PassWord;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == "")
                {
                    MessageBox.Show("Please Enter UserID");
                    return;
                }
                if (txtPwd.Text == "")
                {
                    MessageBox.Show("Please Enter Password");
                    return;
                }
                Login();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void Login()
        {
            try
            {
                count++;
                string ConnectionString = "";
                using (SqlConnection conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
                {
                    SqlCommand cmd = conDatabase.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UserLogin";
                    cmd.Parameters.AddWithValue("@UserName", txtUserID.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPwd.Text);
                    conDatabase.Open();                    
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    conDatabase.Close();
                    if (result > 0)
                    {
                        Username = txtUserID.Text.Trim();
                        PassWord = txtPwd.Text.Trim();
                        MessageBox.Show("Login Successfull");
                        this.Hide();
                        if (Username == "Admin")
                        {
                            AdminForm objAd = new AdminForm();
                            objAd.Show();
                        }
                        else
                        {
                            MainForm objmain = new MainForm();
                            objmain.Show();
                        }
                    }
                    else
                    {
                        if (count == 1)
                        {
                            MessageBox.Show("Please Enter Valid User Name and Password");
                        }
                        else if (count == 2)
                        {
                            MessageBox.Show("Please Enter Valid User Name and Password. You have Only one attempt Left..!");
                        }
                        else
                        {
                            MessageBox.Show("Application is closing. Please contact your supervisor.");
                            Application.Exit();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
                
        }
        
    }
}
