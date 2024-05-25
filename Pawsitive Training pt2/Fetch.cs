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

namespace Pawsitive_Training_pt2
{
    public partial class Fetch : Form
    {
        public Fetch()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Fetch_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string f = @"C:\Users\saced\Documents\SANDRA FILES\VIDS\How to Teach Your Dog to Fetch _ Chewy.mp4";
            MediaPlayer.URL = f;
        }
    }
}
