using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;

namespace Pawsitive_Training_pt2
{
    public partial class Report : Form
    {
        string username;
        public Report(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Load += Report_Load;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Report_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            comboboxreport.Items.Clear();

            con.Open();

            string selectQuery = "SELECT Report FROM tbl_report WHERE username = @Username";

            using (OleDbCommand command = new OleDbCommand(selectQuery, con))
            {
                command.Parameters.AddWithValue("@Username", username);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboboxreport.Items.Add(reader["Report"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No reports found for this user.", "No Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxreport.Text))
            {
                MessageBox.Show("Please fill out all the details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Continue to submit report?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                con.Open();
                string insertQuery = "INSERT INTO tbl_report (Report, username) VALUES (@report, @Username)";
                using (OleDbCommand command = new OleDbCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@report", txtboxreport.Text);
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Report submitted successfully. Thank You!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Hide();
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            lblreport.Text = "";
            lblresponse.Text = "";

            if (comboboxreport.SelectedItem != null)
            {
                con.Open();

                string selectQuery = "SELECT Report, Response FROM tbl_report WHERE username = @Username AND Report = @Report";

                using (OleDbCommand command = new OleDbCommand(selectQuery, con))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Report", comboboxreport.SelectedItem.ToString());

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblreport.Text = reader["Report"].ToString();

                            if (!reader.IsDBNull(reader.GetOrdinal("Response")))
                            {
                                lblresponse.Text = reader["Response"].ToString();
                            }
                            else
                            {
                                lblresponse.Text = "No response yet.";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Report not found.", "Report Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please select a report.", "No Report Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboboxreport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblreport_Click(object sender, EventArgs e)
        {

        }

        private void lblresponse_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Report_Load_1(object sender, EventArgs e)
        {

        }

        private void Report_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
