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
    public partial class journelVoucherCreationMenu : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        //datashow
        //public void desplaydata()
        //{
        //    conn.Open();
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "select * from GetVoucherMaster";
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    conn.Close();
       // }
        public journelVoucherCreationMenu()
        {
            InitializeComponent();
        }
        private void loadStoreProcedure()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GetVoucherMaster", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void vrdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void remark_TextChanged(object sender, EventArgs e)
        {

        }

        private void journelVoucherCreationMenu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-QQNA2SU;Initial Catalog=SoftEvaluation;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;

            //displaydata();
            loadStoreProcedure();
        }

        //private void UpdateRecord()
        //{
        //    // Open another form for editing
        //    Form1 edit_form1 = new Form1();
        //    edit_form1.ShowDialog();
        //    DialogResult result = edit_form1.DialogResult;

        //    // After editing, update the record in the grid view
        //    if (result == DialogResult.OK)
        //    {
        //        loadStoreProcedure();
        //    }
        //}

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // desplaydata();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nform1 = new Form1();
            nform1.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            EditRecord editRecord = new EditRecord();
            editRecord.Show();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            EditRecord editRecord = new EditRecord();
            editRecord.Show();
        }

        private void show_Click(object sender, EventArgs e)
        {
            journelVoucherCreationMenu newjournelmenuform = new journelVoucherCreationMenu();
            newjournelmenuform.Show();
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
