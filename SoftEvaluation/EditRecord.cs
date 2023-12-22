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
    public partial class EditRecord : Form
    {
        SqlConnection conn;
        SqlCommand command;
        public EditRecord()
        {
            InitializeComponent();
        }
        private void EditRecord_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-QQNA2SU;Initial Catalog=SoftEvaluation;Integrated Security=True");
            command = new SqlCommand();
            command.Connection = conn;
        }
        //Update Record Function       
        private void UpdateRecord()
        {
            try
            {
                using (SqlCommand command = new SqlCommand("UpdateVoucherMaster", conn))
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
                    // Add other parameters similarly

                    conn.Open();
                    command.ExecuteNonQuery();
                    vouchernumber.Text = "";
                    conn.Close();

                    // Refresh the DataGridView after updating a record


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        //Delete Records

        private void DeleteRecord()
        {
            try 
            { 
            using (SqlCommand command = new SqlCommand("DeleteVoucherMaster", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@VoucherNo", int.Parse(vouchernumber.Value.ToString()));

                conn.Open();
                command.ExecuteNonQuery();
                vouchernumber.Text = "";
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } // Refresh the DataGridView after deleting a record
             
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void vouchernumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }
    }
}
