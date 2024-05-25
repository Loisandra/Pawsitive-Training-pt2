using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace Pawsitive_Training_pt2
{
    public partial class ForgotPass : Form
    {
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb";
        public ForgotPass()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool CheckUserInput(string username, string dogName, string dob)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM tbl_profile WHERE username = @username AND DogName = @dogName AND DOB = @dob";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@dogName", dogName);
                    command.Parameters.AddWithValue("@dob", dob);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void btnconfirm_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string dogName = txtDogName.Text.Trim();
            string dob = dtpbirth.Value.ToShortDateString();

            // Check if the inputs match the data in tbl_profile
            if (CheckUserInput(username, dogName, dob))
            {
                // If inputs match, show confirmation message and navigate to ForgotChange form
                MessageBox.Show("Confirmed username.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ForgotChange forgotChangeForm = new ForgotChange(username);
                forgotChangeForm.Show();
                this.Hide();
            }
            else
            {
                // If inputs do not match, show error message
                MessageBox.Show("Invalid credentials. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnconfirm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ForgotPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
