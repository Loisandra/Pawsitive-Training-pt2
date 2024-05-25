using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pawsitive_Training_pt2
{
    public partial class ForgotChange : Form
    {
        string username;
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb";
        public ForgotChange(string username)
        {
            InitializeComponent();
            this.username = username;
            txtUsername.Text = username;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtConPass.PasswordChar = '*';
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string newPassword = txtPass.Text.Trim();
            string confirmPassword = txtConPass.Text.Trim();

            // Check if passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please re-enter the passwords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update password in the database
            if (UpdatePassword(username, newPassword))
            {
                MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Show message box for successful password change

                // Navigate to frmLogin
                frmLogin loginForm = new frmLogin();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePassword(string username, string newPassword)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "UPDATE tbl_users SET [password] = @newPassword WHERE username = @username";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@username", username);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        // Close the connection after executing the query
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to change password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        private void ForgotChange_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
