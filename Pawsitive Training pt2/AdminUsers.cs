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
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void PopulateDataGridView()
        {
            string query = "SELECT Username FROM tbl_users WHERE Username <> 'admin'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            DataTable dt = new DataTable();

            con.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dgvUsers.DataSource = dt;
                dgvUsers.Columns["Username"].HeaderText = "USERNAMES";
                dgvUsers.Columns["Username"].Width = 510;
            }
            else
            {
                MessageBox.Show("No users found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }
    }
}
