using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pawsitive_Training_pt2
{
    public partial class DogProfile : Form
    {
        string username;
        public DogProfile(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Addlog addlog = new Addlog(username);
            addlog.Show();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            FeedBack feed = new FeedBack(username);
            feed.Show();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Report report = new Report(username);
            report.Show();
        }
    }
}
