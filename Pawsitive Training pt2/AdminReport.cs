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

namespace Pawsitive_Training_pt2
{
    public partial class AdminReport : Form
    {
        public AdminReport()
        {
            InitializeComponent();
            PopulateComboBoxUser();
            PopulateReportDataGridView("");
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void PopulateComboBoxUser()
        {
            string query = "SELECT DISTINCT username FROM tbl_report";
            OleDbCommand cmd = new OleDbCommand(query, con);
            DataTable dt = new DataTable();

            con.Open();
            dt.Load(cmd.ExecuteReader());

            if (dt.Rows.Count > 0)
            {
                comboboxuser.DataSource = dt;
                comboboxuser.DisplayMember = "username";
            }
            else
            {
                MessageBox.Show("No users found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void PopulateComboBoxReport(string selectedUser)
        {
            string query = $"SELECT Report FROM tbl_report WHERE username = '{selectedUser}'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            DataTable dt = new DataTable();

            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }

            con.Open();
            dt.Load(cmd.ExecuteReader());

            if (dt.Rows.Count > 0)
            {
                comboboxreport.DataSource = dt;
                comboboxreport.DisplayMember = "Report";
            }
            con.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string selectedUser = comboboxuser.Text;
            string selectedReport = comboboxreport.Text;
            string response = txtboxresponse.Text;

            if (string.IsNullOrEmpty(selectedUser) || string.IsNullOrEmpty(selectedReport) || string.IsNullOrEmpty(response))
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = $"UPDATE tbl_report SET Response = @Response WHERE username = @Username AND Report = @Report";

            OleDbCommand cmd = new OleDbCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@Response", response);
            cmd.Parameters.AddWithValue("@Username", selectedUser);
            cmd.Parameters.AddWithValue("@Report", selectedReport);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Response saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateReportDataGridView(selectedUser);
            }
            else
            {
                MessageBox.Show("No matching record found to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopulateReportDataGridView(string selectedUser)
        {
            string query = "SELECT Report, username, Response FROM tbl_report";
            OleDbCommand cmd = new OleDbCommand(query, con);
            DataTable dt = new DataTable();

            con.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgvReport.DataSource = dt;
                dgvReport.Columns["Report"].HeaderText = "USER REPORT/CONCERN";
                dgvReport.Columns["username"].HeaderText = "USERNAME";
                dgvReport.Columns["Response"].HeaderText = "ADMIN RESPONSE";

                dgvReport.Columns["Report"].Width = 350;
                dgvReport.Columns["Response"].Width = 350;

                dgvReport.Columns["Report"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgvReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                MessageBox.Show("No reports found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void comboboxreport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboboxuser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedUser = comboboxuser.Text;
            PopulateComboBoxReport(selectedUser);
        }
    }
}
