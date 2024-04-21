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
    public partial class AdminFeed : Form
    {
        public AdminFeed()
        {
            InitializeComponent();
            PopulateFeedbackDataGridView();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void PopulateFeedbackDataGridView()
        {
            string query = "SELECT FeedBack, Rating, username FROM tbl_feedback";
            OleDbCommand cmd = new OleDbCommand(query, con);
            DataTable dt = new DataTable();

            con.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgvFeedBack.DataSource = dt;
                dgvFeedBack.Columns["FeedBack"].HeaderText = "FEEDBACK";
                dgvFeedBack.Columns["Rating"].HeaderText = "RATE";
                dgvFeedBack.Columns["username"].HeaderText = "USERS";

                dgvFeedBack.Columns["FeedBack"].Width = 300;

                dgvFeedBack.Columns["FeedBack"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgvFeedBack.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                MessageBox.Show("No feedback found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
