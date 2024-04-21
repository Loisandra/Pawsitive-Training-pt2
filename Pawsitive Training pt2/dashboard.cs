using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pawsitive_Training_pt2
{
    public partial class dashboard : Form
    {
        string username;
        public dashboard(string username)
        {
            InitializeComponent();
            LoadDataFromDatabase(username);
            this.username = username;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void LoadDataFromDatabase(string username)
        {
            con.Open();
            string query = "SELECT * FROM tbl_profile WHERE username = @username";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbldogname.Text = reader["DogName"].ToString();
                lblbreed.Text = reader["DogBreed"].ToString();
                lblbirth.Text = reader["DOB"].ToString();
                lblgender.Text = reader["DogGender"].ToString();
            }
            con.Close();

            DisplayProfilePicture(username);
        }

        private void DisplayProfilePicture(string username)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb"))
                {
                    connection.Open();
                    string selectQuery = "SELECT DogPic FROM tbl_pic WHERE Username = @username";
                    using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    // Retrieve image data from the database
                                    byte[] imageData = (byte[])reader["DogPic"];

                                    // Convert byte array to image and display it in the picprofile PictureBox
                                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                                    {
                                        picprofile.Image = System.Drawing.Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred While Retrieving Profile Picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxname.Text) || string.IsNullOrWhiteSpace(txtboxbreed.Text) || comboboxgender.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to save this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string selectQuery = "SELECT COUNT(*) FROM tbl_profile WHERE username = @username";
                    cmd = new OleDbCommand(selectQuery, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    if (count > 0)
                    {
                        con.Open();
                        string updateQuery = "UPDATE tbl_profile SET DogName = @dogName, DogBreed = @dogBreed, DOB = @birthDate, DogGender = @dogGender WHERE username = @username";
                        cmd = new OleDbCommand(updateQuery, con);
                        cmd.Parameters.AddWithValue("@dogName", txtboxname.Text);
                        cmd.Parameters.AddWithValue("@dogBreed", txtboxbreed.Text);
                        cmd.Parameters.AddWithValue("@birthDate", dtpbirth.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@dogGender", comboboxgender.SelectedItem);
                        cmd.Parameters.AddWithValue("@username", username);
                        
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        string register = "INSERT INTO tbl_profile (DogName, DogBreed, DOB, DogGender, username) VALUES (@dogName, @dogBreed, @birthDate, @dogGender, @username)";
                        cmd = new OleDbCommand(register, con);
                        cmd.Parameters.AddWithValue("@dogName", txtboxname.Text);
                        cmd.Parameters.AddWithValue("@dogBreed", txtboxbreed.Text);
                        cmd.Parameters.AddWithValue("@birthDate", dtpbirth.Value.ToShortDateString());
                        cmd.Parameters.AddWithValue("@dogGender", comboboxgender.SelectedItem);
                        cmd.Parameters.AddWithValue("@username", username);
                        
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    lbldogname.Text = txtboxname.Text;
                    lblbreed.Text = txtboxbreed.Text;
                    lblbirth.Text = dtpbirth.Value.ToShortDateString();
                    lblgender.Text = comboboxgender.SelectedItem.ToString();
                    txtboxname.Text = "";
                    txtboxbreed.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while saving data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    lbldogname.Text = "No name";
                    lblbreed.Text = "No breed";
                    lblbirth.Text = "No birth date";
                    lblgender.Text = "-";
                    txtboxname.Text = "";
                    txtboxbreed.Text = "";

                    con.Open();
                    string deleteQuery = "DELETE FROM tbl_profile WHERE username = @username";
                    cmd = new OleDbCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblbirth_Click(object sender, EventArgs e)
        {
            lblbirth.Text = dtpbirth.Value.ToShortDateString();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagelocation = dialog.FileName;

                    DialogResult result = MessageBox.Show("Please confirm your selection. Is this the image you wish to choose?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        picprofile.ImageLocation = imagelocation;
                        SaveImageToDatabase(imagelocation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveImageToDatabase(string imagePath)
        {
            try
            {
                byte[] imageData;

                using (System.IO.FileStream fs = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    imageData = new byte[fs.Length];
                    fs.Read(imageData, 0, imageData.Length);
                }

                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb"))
                {
                    connection.Open();

                    string selectQuery = "SELECT COUNT(*) FROM tbl_pic WHERE Username = @username";
                    using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        int count = (int)selectCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = "UPDATE tbl_pic SET DogPic = @dogPic WHERE Username = @username";
                            using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@dogPic", imageData);
                                updateCommand.Parameters.AddWithValue("@username", username);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO tbl_pic (DogPic, Username) VALUES (@dogPic, @username)";
                            using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@dogPic", imageData);
                                insertCommand.Parameters.AddWithValue("@username", username);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                picprofile.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred While Saving Image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picprofile_Click(object sender, EventArgs e)
        {

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string selectQuery = "SELECT COUNT(*) FROM tbl_pic WHERE Username = @username";
                cmd = new OleDbCommand(selectQuery, con);
                cmd.Parameters.AddWithValue("@username", username);
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count == 0)
                {
                    MessageBox.Show("No picture to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to remove the profile picture?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    con.Open();
                    string deleteQuery = "DELETE FROM tbl_pic WHERE Username = @username";
                    cmd = new OleDbCommand(deleteQuery, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    picprofile.Image = null;

                    MessageBox.Show("Profile picture removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
