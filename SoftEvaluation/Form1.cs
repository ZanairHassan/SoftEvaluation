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

namespace SoftEvaluation
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-QQNA2SU;Initial Catalog=SoftEvaluation;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("InsertVoucherMaster", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VoucherNo", int.Parse(vouchernumber.Value.ToString()));
                command.Parameters.AddWithValue("@VoucherDate", DateTime.Parse(voucherdate.Text));
                command.Parameters.AddWithValue("@Remarks", remarks.Text);
                command.Parameters.AddWithValue("@Account", int.Parse(account.Value.ToString()));
                command.Parameters.AddWithValue("@SubAccount", subaccount.Text);
                command.Parameters.AddWithValue("@Debit", int.Parse(debit.Value.ToString()));
                command.Parameters.AddWithValue("@Credit", int.Parse(credit.Value.ToString()));
                command.Parameters.AddWithValue("@CostCenter", int.Parse(costcenter.Value.ToString()));
                command.Parameters.AddWithValue("@UserId", (userid.Text));
                command.Parameters.AddWithValue("@EntryDate", DateTime.Parse(enterydate.Text));
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                cleardata();

            }
        }

        private void cleardata()
        {
            //vouchernumber.Clear();
            //voucherdate.Clear();
            remarks.Clear();
            subaccount.Clear();
            userid.Clear();
            
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            journelVoucherCreationMenu nform = new journelVoucherCreationMenu();
            nform.Show();
            this.Hide();
        }
    }
}
