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
    public partial class MainForm : Form
    {
        public string Operation = "";

        public static string Username;
        public static string PassWord;
        public MainForm()
        {
            InitializeComponent();

            Username = LoginForm.Username;
            PassWord = LoginForm.PassWord;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "0")
                txtValue.Clear();
            Button button = (Button)sender;
            txtValue.Text = txtValue.Text + button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            LoginForm objForm = new LoginForm();
            objForm.Show();
        }

        private void rbtDeposite_CheckedChanged(object sender, EventArgs e)
        {
            //Deposite Related Code
            if (rbtDeposite.Checked)
            {
                lblAccountNumber.Visible = false;
                txtAccountNumber.Visible = false;
                Operation = rbtDeposite.Text;
                rbtPayBill.Checked = false;
                rbtTransfer.Checked = false;
                rbtWithdrawl.Checked = false;
            }
        }

        private void rbtWithdrawl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtWithdrawl.Checked)
            {
                lblAccountNumber.Visible = false;
                txtAccountNumber.Visible = false;
                Operation = rbtWithdrawl.Text;
                rbtPayBill.Checked = false;
                rbtTransfer.Checked = false;
                rbtDeposite.Checked = false;
            }
        }

        private void rbtTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTransfer.Checked)
            {
                lblAccountNumber.Text = "Account Number";
                lblAccountNumber.Visible = true;
                txtAccountNumber.Visible = true;
                Operation = rbtTransfer.Text;
                rbtPayBill.Checked = false;
                rbtWithdrawl.Checked = false;
                rbtDeposite.Checked = false;
            }
        }

        private void rbtPayBill_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPayBill.Checked)
            {
                lblAccountNumber.Text = "Bill Number";
                lblAccountNumber.Visible = true;
                txtAccountNumber.Visible = true;
                Operation = rbtPayBill.Text;
                rbtTransfer.Checked = false;
                rbtWithdrawl.Checked = false;
                rbtDeposite.Checked = false;
            }
        }

        private void rbtChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtChecking.Checked)
            {
                rbtSavings.Checked = false;
            }
            else
            {
                rbtSavings.Checked = true;
            }
        }

        private void rbtSavings_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSavings.Checked)
            {
                rbtChecking.Checked = false;
            }
            else
            {
                rbtChecking.Checked = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Operation == "")
                {
                    Operation = rbtDeposite.Text;
                }
                switch (Operation)
                {
                    case "Deposite":
                        Deposite();
                        break;
                    case "Withdraw":
                        Widthdraw();
                        break;
                    case "Pay Bill":
                        PayBill();
                        break;
                    case "Transfer Funds":
                        Transfer();
                        break;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


        //Deposite Related Code
        public void Deposite()
        {
            try
            {
                if (txtValue.Text == "")
                {
                    MessageBox.Show("Please Enter Amount to Deposite");
                }
                else
                {
                    string ConnectionString = "";
                    using (SqlConnection conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
                    {
                        SqlCommand cmd = conDatabase.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Transactions_Insert";
                        cmd.Parameters.AddWithValue("@UserName", Username);
                        cmd.Parameters.AddWithValue("@Amount", txtValue.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransactionType", 'D');
                        conDatabase.Open();
                        Double result = Convert.ToDouble(cmd.ExecuteScalar());
                        conDatabase.Close();
                        if (result > 0)
                        {
                            result = result + Convert.ToDouble(txtValue.Text.Trim());

                            cmd = conDatabase.CreateCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Accounts_Update";
                            cmd.Parameters.AddWithValue("@Username", Username);
                            cmd.Parameters.AddWithValue("@Amount", result);
                            conDatabase.Open();
                            Double finalresult = Convert.ToDouble(cmd.ExecuteScalar());
                            conDatabase.Close();
                            MessageBox.Show("Amount Deposited Successfully...!");
                            txtValue.Text = "";
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        //Widra Related Code
        public void Widthdraw()
        {
            try
            {
                if (txtValue.Text == "")
                {
                    MessageBox.Show("Please Enter Amount to Deposite");
                }
                else
                {
                    if (Convert.ToDouble(txtValue.Text.Trim()) > 1000)
                    {
                        MessageBox.Show("Please enter below or equal to $1000");
                    }
                    else
                    {
                        string ConnectionString = "";
                        using (SqlConnection conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
                        {
                            SqlCommand cmd = conDatabase.CreateCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Transactions_Insert";
                            cmd.Parameters.AddWithValue("@UserName", Username);
                            cmd.Parameters.AddWithValue("@Amount", txtValue.Text.Trim());
                            cmd.Parameters.AddWithValue("@TransactionType", 'W');
                            conDatabase.Open();
                            Double result = Convert.ToDouble(cmd.ExecuteScalar());
                            conDatabase.Close();
                            if (result > 0)
                            {
                                result = result - Convert.ToDouble(txtValue.Text.Trim());
                                if (result > 0)
                                {
                                    cmd = conDatabase.CreateCommand();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "Accounts_Update";
                                    cmd.Parameters.AddWithValue("@Username", Username);
                                    cmd.Parameters.AddWithValue("@Amount", result);
                                    conDatabase.Open();
                                    Double finalresult = Convert.ToDouble(cmd.ExecuteScalar());
                                    conDatabase.Close();
                                    MessageBox.Show("Amount Withdraw Successfully Completed...!");
                                    txtValue.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("You dont have sufficient amount In your Account..!");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //PayBill Related Code
        public void PayBill()
        {
            try
            {
                if (txtAccountNumber.Text == "")
                {
                    MessageBox.Show("Please Enter Bill Number..!");

                }
                else
                {
                    if (txtValue.Text == "")
                    {
                        MessageBox.Show("Please Enter Amount to Deposite");
                    }
                    else
                    {
                        string ConnectionString = "";
                        using (SqlConnection conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
                        {
                            SqlCommand cmd = conDatabase.CreateCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Transactions_Insert";
                            cmd.Parameters.AddWithValue("@UserName", Username);
                            cmd.Parameters.AddWithValue("@Amount", txtValue.Text.Trim());
                            cmd.Parameters.AddWithValue("@TransactionType", 'W');
                            conDatabase.Open();
                            Double result = Convert.ToDouble(cmd.ExecuteScalar());
                            conDatabase.Close();
                            if (result > 0)
                            {
                                result = result - Convert.ToDouble(txtValue.Text.Trim());
                                if (result > 0)
                                {
                                    cmd = conDatabase.CreateCommand();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "Accounts_Update";
                                    cmd.Parameters.AddWithValue("@Username", Username);
                                    cmd.Parameters.AddWithValue("@Amount", result);
                                    conDatabase.Open();
                                    Double finalresult = Convert.ToDouble(cmd.ExecuteScalar());
                                    conDatabase.Close();
                                    MessageBox.Show("Amount BillPay Successfully Completed...!");
                                    txtValue.Text = "";
                                    txtAccountNumber.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("You dont have sufficient amount In your Account..!");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Transfer RelatedCode
        public void Transfer()
        {
            try
            {
                if (txtAccountNumber.Text == "")
                {
                    MessageBox.Show("Please Enter Account Number..!");

                }
                else
                {
                    if (txtValue.Text == "")
                    {
                        MessageBox.Show("Please Enter Amount to Deposite");
                    }
                    else
                    {
                        string ConnectionString = "";
                        using (SqlConnection conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
                        {
                            SqlCommand cmd = conDatabase.CreateCommand();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Transactions_Insert";
                            cmd.Parameters.AddWithValue("@UserName", Username);
                            cmd.Parameters.AddWithValue("@Amount", txtValue.Text.Trim());
                            cmd.Parameters.AddWithValue("@TransactionType", 'W');
                            conDatabase.Open();
                            Double result = Convert.ToDouble(cmd.ExecuteScalar());
                            conDatabase.Close();
                            if (result > 0)
                            {
                                result = result - Convert.ToDouble(txtValue.Text.Trim());
                                if (result > 0)
                                {
                                    cmd = conDatabase.CreateCommand();
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.CommandText = "Accounts_Update";
                                    cmd.Parameters.AddWithValue("@Username", Username);
                                    cmd.Parameters.AddWithValue("@Amount", result);
                                    conDatabase.Open();
                                    Double finalresult = Convert.ToDouble(cmd.ExecuteScalar());
                                    conDatabase.Close();
                                    MessageBox.Show("Amount Transfer Successfully Completed...!");
                                    txtValue.Text = "";
                                    txtAccountNumber.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("You dont have sufficient amount In your Account..!");
                                }
                            }
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
