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
    public partial class TrainingGoal : Form
    {
        private string username;
        public TrainingGoal(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadTrainingGoals();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void dgvlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (comboboxtrain.SelectedItem == null)
            {
                MessageBox.Show("Please select a training goal.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to add this training goal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            string trainGoal = comboboxtrain.SelectedItem.ToString();
            DateTime startDate = dtpstart.Value.Date;
            DateTime endDate = dtpend.Value.Date;

            con.Open();
            string insertQuery = "INSERT INTO tbl_train (DateStart, DateEnd, TrainGoal, username) VALUES (@DateStart, @DateEnd, @TrainGoal, @Username)";
            using (OleDbCommand command = new OleDbCommand(insertQuery, con))
            {
                command.Parameters.AddWithValue("@DateStart", startDate);
                command.Parameters.AddWithValue("@DateEnd", endDate);
                command.Parameters.AddWithValue("@TrainGoal", trainGoal);
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();
            }
            con.Close();

            MessageBox.Show("Training goal added successfully!");
            LoadTrainingGoals();
        }

        private void dgvlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTrainingGoals()
        {
            dgvlist.Rows.Clear();
            con.Open();
            string selectQuery = "SELECT DateStart, DateEnd, TrainGoal FROM tbl_train WHERE username = @Username";

            using (OleDbCommand command = new OleDbCommand(selectQuery, con))
            {
                command.Parameters.AddWithValue("@Username", username);
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        DateTime startDate = Convert.ToDateTime(reader["DateStart"]);
                        DateTime endDate = Convert.ToDateTime(reader["DateEnd"]);
                        string trainGoal = reader["TrainGoal"].ToString();


                        dgvlist.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), trainGoal);
                    }
                }
            }

            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvlist.SelectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = dgvlist.SelectedRows[0];

                if (selectedRow.Cells["StartDate"].Value == null || selectedRow.Cells["EndDate"].Value == null)
                {
                    MessageBox.Show("No data exists in the selected row.", "Empty Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime oldStartDate = DateTime.Parse(selectedRow.Cells["StartDate"].Value.ToString());
                DateTime oldEndDate = DateTime.Parse(selectedRow.Cells["EndDate"].Value.ToString());


                DateTime newStartDate = dtpstart.Value.Date;
                DateTime newEndDate = dtpend.Value.Date;


                con.Open();
                string updateQuery = "UPDATE tbl_train SET DateStart = @NewStartDate, DateEnd = @NewEndDate WHERE DateStart = @OldStartDate AND DateEnd = @OldEndDate AND username = @Username";
                using (OleDbCommand command = new OleDbCommand(updateQuery, con))
                {
                    command.Parameters.AddWithValue("@NewStartDate", newStartDate);
                    command.Parameters.AddWithValue("@NewEndDate", newEndDate);
                    command.Parameters.AddWithValue("@OldStartDate", oldStartDate);
                    command.Parameters.AddWithValue("@OldEndDate", oldEndDate);
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
                con.Close();


                LoadTrainingGoals();

                MessageBox.Show("Training goal updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvlist_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            if (e.ColumnIndex == dgvlist.Columns["TrainGoal"].Index)
            {
                MessageBox.Show("You cannot edit the TrainGoal column.", "Invalid Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgvlist.SelectedRows.Count == 1)
            {

                DialogResult result = MessageBox.Show("Are you sure you want to delete this training goal?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dgvlist.SelectedRows[0];

                    if (selectedRow.Cells["StartDate"].Value == null || selectedRow.Cells["EndDate"].Value == null)
                    {
                        MessageBox.Show("No data exists in the selected row.", "Empty Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DateTime startDate = DateTime.Parse(selectedRow.Cells["StartDate"].Value.ToString());
                    DateTime endDate = DateTime.Parse(selectedRow.Cells["EndDate"].Value.ToString());
                    string trainGoal = selectedRow.Cells["TrainGoal"].Value.ToString();

                    con.Open();
                    string deleteQuery = "DELETE FROM tbl_train WHERE DateStart = @StartDate AND DateEnd = @EndDate AND TrainGoal = @TrainGoal AND username = @Username";
                    using (OleDbCommand command = new OleDbCommand(deleteQuery, con))
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@TrainGoal", trainGoal);
                        command.Parameters.AddWithValue("@Username", username);
                        command.ExecuteNonQuery();
                    }
                    con.Close();

                    dgvlist.Rows.Remove(selectedRow);

                    MessageBox.Show("Training goal deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsit_Click(object sender, EventArgs e)
        {
            Sit sit = new Sit();
            sit.Show();
        }

        private void btnstay_Click(object sender, EventArgs e)
        {
            Stay stay = new Stay();
            stay.Show();
        }

        private void btnjump_Click(object sender, EventArgs e)
        {
            Jump jump = new Jump();
            jump.Show();
        }

        private void btnroll_Click(object sender, EventArgs e)
        {
            RollOver roll = new RollOver();
            roll.Show();
        }

        private void btnspin_Click(object sender, EventArgs e)
        {
            Spin spin = new Spin();
            spin.Show();
        }

        private void btnquiet_Click(object sender, EventArgs e)
        {
            Quiet quiet = new Quiet();
            quiet.Show();
        }

        private void btnshake_Click(object sender, EventArgs e)
        {
            Shake shake = new Shake();
            shake.Show();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            No no = new No();
            no.Show();
        }

        private void btnlie_Click(object sender, EventArgs e)
        {
            Down down = new Down();
            down.Show();
        }

        private void btndrop_Click(object sender, EventArgs e)
        {
            Drop drop = new Drop();
            drop.Show();
        }

        private void btnbed_Click(object sender, EventArgs e)
        {
            Bed bed = new Bed();
            bed.Show();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            Fetch fetch = new Fetch();
            fetch.Show();
        }

        private void btndead_Click(object sender, EventArgs e)
        {
            Dead dead = new Dead();
            dead.Show();
        }

        private void btnloose_Click(object sender, EventArgs e)
        {
            Leash leash = new Leash();
            leash.Show();
        }

        private void btnpotty_Click(object sender, EventArgs e)
        {
            Potty potty = new Potty();
            potty.Show();
        }
    }
}
