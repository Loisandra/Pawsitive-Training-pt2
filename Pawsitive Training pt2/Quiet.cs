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
    public partial class Quiet : Form
    {
        public Quiet()
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

        private void Quiet_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string f = @"C:\Users\saced\Documents\SANDRA FILES\VIDS\How To Teach Your Dog To Be Quiet By Barking On Command!.mp4";
            MediaPlayer.URL = f;
        }
    }
}
