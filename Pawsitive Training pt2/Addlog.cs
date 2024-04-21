using Microsoft.Win32;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pawsitive_Training_pt2
{
    public partial class Addlog : Form
    {
        string username;
        public Addlog(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtgoal.Text) || string.IsNullOrWhiteSpace(txtduration.Text) || string.IsNullOrWhiteSpace(txtloc.Text) || string.IsNullOrWhiteSpace(txttrainer.Text) || comboxincident.SelectedItem == null || comboxinjury.SelectedItem == null || string.IsNullOrWhiteSpace(txtdescription.Text) || string.IsNullOrWhiteSpace(txtboxentry.Text))
            {
                MessageBox.Show("Please fill out all the details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtduration.Text, out _))
            {
                MessageBox.Show("Please fill out the duration in number (in minutes).", "Invalid Duration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int logEntryNo;
            if (!int.TryParse(txtboxentry.Text, out logEntryNo))
            {
                MessageBox.Show("Log entry invalid. Please type in a number.", "Invalid Log Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Continue to add data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM tbl_logging WHERE LogEntryNo = @logentryno AND username = @username";
                cmd = new OleDbCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@logentryno", txtboxentry.Text);
                cmd.Parameters.AddWithValue("@username", username);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show($"LogNumber '{txtboxentry.Text}' already exists.", "Duplicate LogNumber", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                string log = "INSERT INTO tbl_logging (LogDate, LogGoal, LogDuration, LogLoc, LogTrainer, LogIncident, LogInjury, LogDescription, username, LogEntryNo) VALUES (@logdate, @loggoal, @logduration, @logloc, @logtrainer, @logincident, @loginjury, @logdescription, @username, @logentryno)";
                cmd = new OleDbCommand(log, con);
                cmd.Parameters.AddWithValue("@logdate", dtplog.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@loggoal", txtgoal.Text);
                cmd.Parameters.AddWithValue("@logduration", txtduration.Text);
                cmd.Parameters.AddWithValue("@logloc", txtloc.Text);
                cmd.Parameters.AddWithValue("@logtrainer", txttrainer.Text);
                cmd.Parameters.AddWithValue("@logincident", comboxincident.SelectedItem);
                cmd.Parameters.AddWithValue("@loginjury", comboxinjury.SelectedItem);
                cmd.Parameters.AddWithValue("@logdescription", txtdescription.Text);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@logentryno", txtboxentry.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                this.Hide();
            }

        }

        private void Addlog_Load(object sender, EventArgs e)
        {

        }

        private void Addlog_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
