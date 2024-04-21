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
            btnadd = new Button();
            panelbuttons = new Panel();
            btnreport = new Button();
            btnsub = new Button();
            cal = new MonthCalendar();
            panelcalendar = new Panel();
            paneldash = new Panel();
            panelbuttons.SuspendLayout();
            panelcalendar.SuspendLayout();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnadd.BackColor = Color.SaddleBrown;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnreport.FlatStyle = FlatStyle.Flat;
            btnreport.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnsub.FlatStyle = FlatStyle.Flat;
            btnsub.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            paneldash.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paneldash.BackColor = Color.SaddleBrown;
            paneldash.Location = new Point(278, 37);
            paneldash.Name = "paneldash";
            paneldash.Size = new Size(454, 435);
            paneldash.TabIndex = 9;
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
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Button btnadd;
        private Panel panelbuttons;
        private Button button3;
        private Button btnreport;
        private Button btnsub;
        private MonthCalendar cal;
        private Panel panelcalendar;
        private Panel paneldash;
    }
}