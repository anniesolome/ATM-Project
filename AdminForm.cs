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
    public partial class AdminForm : Form
    {
        public string Operation = "";
        public AdminForm()
        {
            InitializeComponent();
        }

        private void rblPayInterest_CheckedChanged(object sender, EventArgs e)
        {
            if (rblPayInterest.Checked)
            {
                Operation = rblPayInterest.Text;
                txtInterest.Visible = true;
                lblInterest.Visible = true;
            }
            else
            {
                txtInterest.Visible = false;
                lblInterest.Visible = false;
            }
        }

       
        private void rblMoneyRefill_CheckedChanged(object sender, EventArgs e)
        {
            if (rblMoneyRefill.Checked)
            {
                Operation = rblMoneyRefill.Text;
                lblAmount.Visible = true;
                txtAmunt.Visible = true;
            }
            else
            {
                lblAmount.Visible = false;
                txtAmunt.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rblATMService.Checked)
            {
                Operation = rblATMService.Text;
                lblOutOfService.Visible = true;
            }
            else
            {
                lblOutOfService.Visible = false;
            }
        }

        private void rblAccountReport_CheckedChanged(object sender, EventArgs e)
        {
            if (rblAccountReport.Checked)
            {
                Operation = rblAccountReport.Text;
                lblAccountsReport.Visible = true;
                dataGridView1.Visible = true;
            }
            else
            {
                lblAccountsReport.Visible = false;
                dataGridView1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                switch (Operation)
                {
                    case "Pay Interest":
                        Add_Interest();
                        break;
                    case "Print Accounts Report":
                        Get_Report();
                        break;
                    case "ATM Out Of Service":
                        OutOfService();
                        break;
                    case "Refill the ATM Money":
                        RefillAmount();
                        break;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Deposite Related Code
        public void Add_Interest()
        {
            try
            {
                if (txtInterest.Text == "")
                {
                    MessageBox.Show("Please Enter Interest Percentage Amount");
                }
                else
                {
                    //string ConnectionString = "";
                    //using (SqlConnection conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
                    //{
                    //    SqlCommand cmd = conDatabase.CreateCommand();
                    //    cmd = conDatabase.CreateCommand();
                    //    cmd.CommandType = CommandType.StoredProcedure;
                    //    cmd.CommandText = "Calcuate_Interest";
                    //    cmd.Parameters.AddWithValue("@interest", txtInterest.Text.Trim());
                    //     conDatabase.Open();
                    //    Double finalresult = Convert.ToDouble(cmd.ExecuteScalar());
                    //    conDatabase.Close();
                        MessageBox.Show("Interest Deposited Successfully for All Users...!");
                        txtInterest.Text = "";
                    // }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Get_Report()
        {
            try
            {
                
                    string ConnectionString = "";
                    using (SqlConnection conDatabase = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString))
                    {
                        SqlCommand cmd = conDatabase.CreateCommand();
                        cmd = conDatabase.CreateCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "get_TransactionsData";                        
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        conDatabase.Open();
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0] != null)
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                            
                        }
                        MessageBox.Show("Data Binded SuccessFully..!");
                       
                    }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void OutOfService()
        {
            lblOutOfService.Visible = true;
            lblOutOfService.Text = "ATM Out Of Service";
            MessageBox.Show("ATM Set to Out Of Service successfully..!!");
        }

        public void RefillAmount()
        {
            if (txtAmunt.Text == "")
            {
                MessageBox.Show("Please enter Amount to Refill the ATM");
            }
            else
            {
                MessageBox.Show("Amount Refilled Successfully..!");
                txtAmunt.Text = "";
            }
        }

    }
}
