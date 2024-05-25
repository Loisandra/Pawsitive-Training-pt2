using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pawsitive_Training_pt2
{
    public partial class TheMain : Form
    {
        string username;
        private bool panelVisible = false;
        private Form currentForm;
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb";
        public TheMain(string username)
        {
            InitializeComponent();
            this.username = username;
            UpdateTitleLabel();
            OpenAnotherForm(new DogProfile(username));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void UpdateTitleLabel()
        {
            string dogName = GetDogName(username);

            if (!string.IsNullOrEmpty(dogName))
            {
                lbltitle.Text = $"{dogName}'s Training and Behavior Tracker";
            }
            else
            {
                lbltitle.Text = "Doggy's Training and Behavior Tracker";
            }
        }

        private string GetDogName(string username)
        {
            string dogName = "";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT DogName FROM tbl_profile WHERE username = @username";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dogName = reader["DogName"].ToString();
                }
            }

            return dogName;
        }

        private void DogProfile_DogNameUpdated(object sender, EventArgs e)
        {
            UpdateTitleLabel();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
            }
        }

        private void OpenAnotherForm(Form form)
        {
            currentForm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            PanelControl.Controls.Clear();
            PanelControl.Controls.Add(form);

            //adjust sa something
            panelVisible = true;

            form.Show();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new DogProfile(username));
            this.Focus();
        }

        private void btndogprof_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new dashboard(username));
            this.Focus();
        }

        private void btngoal_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new TrainingGoal(username));
            this.Focus();
        }

        private void btnsession_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new Trainers(username));
            this.Focus();
        }

        private void btnbehave_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new Logging(username));
            this.Focus();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }

            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
