using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;

namespace Pawsitive_Training_pt2
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Please enter Username and Password!", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();
            }
            else
            {
                con.Open();
                string checkUserQuery = "SELECT COUNT(*) FROM tbl_users WHERE username = @username";
                OleDbCommand checkUserCmd = new OleDbCommand(checkUserQuery, con);
                checkUserCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                int userCount = (int)checkUserCmd.ExecuteScalar();
                

                string checkPasswordQuery = "SELECT COUNT(*) FROM tbl_users WHERE password = @password";
                OleDbCommand checkPasswordCmd = new OleDbCommand(checkPasswordQuery, con);
                checkPasswordCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                int passwordCount = (int)checkPasswordCmd.ExecuteScalar();

                con.Close();

                if (userCount > 0) 
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";
                    txtUsername.Focus();
                }

                else if (passwordCount > 0)
                {
                    MessageBox.Show("Password already exists. Please choose a different password.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtComPassword.Text = "";
                    txtPassword.Focus();
                }

                else
                {
                    con.Open();
                    string register = "INSERT INTO tbl_users VALUES(@username, @password)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";

                    MessageBox.Show("Account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void lblbacklogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}