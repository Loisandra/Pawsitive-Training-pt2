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

namespace Pawsitive_Training_pt2
{
    public partial class Logging : Form
    {
        string username;
        public Logging(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Logging_Load(object sender, EventArgs e)
        {
            LoadLogEntries();
        }

        private void LoadLogEntries()
        {
            comboboxdate.Items.Clear();
            string query = "SELECT LogEntryNo FROM tbl_logging WHERE username = ?";
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@username", username);

                con.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboboxdate.Items.Add(reader["LogEntryNo"].ToString());
                    }
                }
                con.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Addlog addlog = new Addlog(username);
            addlog.Show();
        }

        private void comboboxdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (comboboxdate.SelectedItem == null)
            {
                MessageBox.Show("Please select entry number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedLogEntry = comboboxdate.SelectedItem.ToString();

            string query = "SELECT * FROM tbl_logging WHERE LogEntryNo = ? AND username = ?";

            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@logentryno", selectedLogEntry);
                cmd.Parameters.AddWithValue("@username", username);

                con.Open();
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        DateTime logDate = Convert.ToDateTime(reader["LogDate"]);
                        lbldate.Text = logDate.ToShortDateString();
                        lblgoal.Text = reader["LogGoal"].ToString();
                        lblduration.Text = reader["LogDuration"].ToString();
                        lblloc.Text = reader["LogLoc"].ToString();
                        lbltrainer.Text = reader["LogTrainer"].ToString();
                        lblincident.Text = reader["LogIncident"].ToString();
                        lblinjury.Text = reader["LogInjury"].ToString();
                        lblnotes.Text = reader["LogDescription"].ToString();
                    }

                    else
                    {
                        MessageBox.Show("No data found for selected entry.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                con.Close();
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (comboboxdate.SelectedItem == null)
            {
                MessageBox.Show("Please select an entry number to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this log entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string selectedLogEntry = comboboxdate.SelectedItem.ToString();

                string query = "DELETE FROM tbl_logging WHERE LogEntryNo = ? AND username = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@logentryno", selectedLogEntry);
                    cmd.Parameters.AddWithValue("@username", username);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Log entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadLogEntries();

                        lbldate.Text = "";
                        lblgoal.Text = "";
                        lblduration.Text = "";
                        lblloc.Text = "";
                        lbltrainer.Text = "";
                        lblincident.Text = "";
                        lblinjury.Text = "";
                        lblnotes.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete log entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btntilt_Click(object sender, EventArgs e)
        {
            Tilt tilt = new Tilt();
            tilt.Show();
        }

        private void btnwag_Click(object sender, EventArgs e)
        {
            Wag wag = new Wag();
            wag.Show();
        }

        private void btnbite_Click(object sender, EventArgs e)
        {
            Bite bite = new Bite();
            bite.Show();
        }

        private void btnshake_Click(object sender, EventArgs e)
        {
            ShakeHead shakehead = new ShakeHead();
            shakehead.Show();
        }

        private void btnbark_Click(object sender, EventArgs e)
        {
            Bark bark = new Bark();
            bark.Show();
        }

        private void btngrowl_Click(object sender, EventArgs e)
        {
            Growl growl = new Growl();
            growl.Show();
        }

        private void btnhowl_Click(object sender, EventArgs e)
        {
            Howl howl = new Howl();
            howl.Show();
        }

        private void btnpant_Click(object sender, EventArgs e)
        {
            Pant pant = new Pant();
            pant.Show();
        }

        private void btnwhine_Click(object sender, EventArgs e)
        {
            Whine whine = new Whine();
            whine.Show();
        }

        private void btnsniff_Click(object sender, EventArgs e)
        {
            Sniff sniff = new Sniff();
            sniff.Show();
        }

        private void btnbelly_Click(object sender, EventArgs e)
        {
            Belly belly = new Belly();
            belly.Show();
        }

        private void btndig_Click(object sender, EventArgs e)
        {
            Dig dig = new Dig();
            dig.Show();
        }

        private void btnpaws_Click(object sender, EventArgs e)
        {
            Raise raise = new Raise();
            raise.Show();
        }

        private void btnhump_Click(object sender, EventArgs e)
        {
            Mount mount = new Mount();
            mount.Show();
        }

        private void btnflick_Click(object sender, EventArgs e)
        {
            Flick flick = new Flick();
            flick.Show();
        }
    }
}
