namespace Pawsitive_Training_pt2
{
    partial class DogProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogProfile));
            btnadd = new Button();
            panelbuttons = new Panel();
            btnreport = new Button();
            btnsub = new Button();
            cal = new MonthCalendar();
            panelcalendar = new Panel();
            paneldash = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            slidePic = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelbuttons.SuspendLayout();
            panelcalendar.SuspendLayout();
            paneldash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slidePic).BeginInit();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnadd.BackColor = Color.SaddleBrown;
            btnadd.Cursor = Cursors.Hand;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(19, 13);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(220, 63);
            btnadd.TabIndex = 5;
            btnadd.Text = "Add Training or Behavior Logging";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // panelbuttons
            // 
            panelbuttons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelbuttons.BackColor = Color.Chocolate;
            panelbuttons.Controls.Add(btnreport);
            panelbuttons.Controls.Add(btnsub);
            panelbuttons.Controls.Add(btnadd);
            panelbuttons.Location = new Point(12, 227);
            panelbuttons.Name = "panelbuttons";
            panelbuttons.Size = new Size(250, 245);
            panelbuttons.TabIndex = 6;
            // 
            // btnreport
            // 
            btnreport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnreport.BackColor = Color.SaddleBrown;
            btnreport.Cursor = Cursors.Hand;
            btnreport.FlatStyle = FlatStyle.Flat;
            btnreport.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnreport.ForeColor = Color.White;
            btnreport.Location = new Point(19, 171);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(220, 63);
            btnreport.TabIndex = 7;
            btnreport.Text = "Report an Issue or Get Help";
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // btnsub
            // 
            btnsub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnsub.BackColor = Color.SaddleBrown;
            btnsub.Cursor = Cursors.Hand;
            btnsub.FlatStyle = FlatStyle.Flat;
            btnsub.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold);
            btnsub.ForeColor = Color.White;
            btnsub.Location = new Point(19, 91);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(220, 63);
            btnsub.TabIndex = 6;
            btnsub.Text = "Submit a Feedback";
            btnsub.UseVisualStyleBackColor = false;
            btnsub.Click += btnsub_Click;
            // 
            // cal
            // 
            cal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cal.Location = new Point(12, 11);
            cal.Name = "cal";
            cal.TabIndex = 7;
            // 
            // panelcalendar
            // 
            panelcalendar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelcalendar.BackColor = Color.Chocolate;
            panelcalendar.Controls.Add(cal);
            panelcalendar.Location = new Point(12, 37);
            panelcalendar.Name = "panelcalendar";
            panelcalendar.Size = new Size(250, 184);
            panelcalendar.TabIndex = 8;
            // 
            // paneldash
            // 
            paneldash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            paneldash.BackColor = Color.SaddleBrown;
            paneldash.Controls.Add(panel1);
            paneldash.Controls.Add(pictureBox1);
            paneldash.Controls.Add(slidePic);
            paneldash.Location = new Point(278, 37);
            paneldash.Name = "paneldash";
            paneldash.Size = new Size(454, 435);
            paneldash.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Snow;
            panel1.Location = new Point(13, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 10);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // slidePic
            // 
            slidePic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            slidePic.BackColor = Color.Transparent;
            slidePic.Image = (Image)resources.GetObject("slidePic.Image");
            slidePic.Location = new Point(16, 164);
            slidePic.Name = "slidePic";
            slidePic.Size = new Size(422, 255);
            slidePic.SizeMode = PictureBoxSizeMode.StretchImage;
            slidePic.TabIndex = 0;
            slidePic.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // DogProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(744, 536);
            Controls.Add(paneldash);
            Controls.Add(panelcalendar);
            Controls.Add(panelbuttons);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DogProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DogProfile";
            panelbuttons.ResumeLayout(false);
            panelcalendar.ResumeLayout(false);
            paneldash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slidePic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnadd;
        private Panel panelbuttons;
        private Button button3;
        private Button btnreport;
        private Button btnsub;
        private MonthCalendar cal;
        private Panel panelcalendar;
        private Panel paneldash;
        private PictureBox slidePic;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}