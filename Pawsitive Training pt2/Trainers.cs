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
    public partial class Trainers : Form
    {
        string username;
        public Trainers(string username)
        {
            InitializeComponent();
            this.username = username;
        }
    }
}
