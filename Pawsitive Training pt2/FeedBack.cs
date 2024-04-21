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
    public partial class FeedBack : Form
    {
        string username;
        public FeedBack(string username)
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxFeed.Text) || comboboxrate.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all the details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Continue to submit feedback?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                con.Open();
                string insertQuery = "INSERT INTO tbl_feedback (FeedBack, Rating, username) VALUES (@feedback, @rating, @Username)";
                using (OleDbCommand command = new OleDbCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@feedback", txtboxFeed.Text);
                    command.Parameters.AddWithValue("@rating", comboboxrate.SelectedItem);
                    command.Parameters.AddWithValue("@Username", username);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Feedback submitted successfully. Thank You!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Hide();
            }
        }

        private void FeedBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
