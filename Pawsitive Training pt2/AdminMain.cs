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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pawsitive_Training_pt2
{
    public partial class AdminMain : Form
    {
        private bool panelVisible = false;
        private Form currentForm;
        public AdminMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenAnotherForm(Form form)
        {
            currentForm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            paneladmin.Controls.Clear();
            paneladmin.Controls.Add(form);

            panelVisible = true;

            form.Show();
        }

        private void paneladmin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new AdminUsers());
            this.Focus();
        }

        private void btnfeed_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new AdminFeed());
            this.Focus();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            OpenAnotherForm(new AdminReport());
            this.Focus();
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

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
