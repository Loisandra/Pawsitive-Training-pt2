namespace Pawsitive_Training_pt2
{
    partial class TheMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheMain));
            btnexit = new Button();
            panel3 = new Panel();
            btnmin = new Button();
            btnmax = new Button();
            lbltitle = new Label();
            panel1 = new Panel();
            btndash = new Button();
            pictureBox7 = new PictureBox();
            btnlogout = new Button();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnbehave = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btndogprof = new Button();
            btngoal = new Button();
            btnsession = new Button();
            PanelControl = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnexit.BackColor = Color.Chocolate;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(929, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(26, 27);
            btnexit.TabIndex = 3;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Peru;
            panel3.Controls.Add(btnmin);
            panel3.Controls.Add(btnmax);
            panel3.Controls.Add(lbltitle);
            panel3.Controls.Add(btnexit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(960, 33);
            panel3.TabIndex = 4;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // btnmin
            // 
            btnmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmin.BackColor = Color.Chocolate;
            btnmin.BackgroundImage = (Image)resources.GetObject("btnmin.BackgroundImage");
            btnmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnmin.FlatStyle = FlatStyle.Flat;
            btnmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmin.Location = new Point(865, 3);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(26, 27);
            btnmin.TabIndex = 6;
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += btnmin_Click;
            // 
            // btnmax
            // 
            btnmax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmax.BackColor = Color.Chocolate;
            btnmax.BackgroundImage = (Image)resources.GetObject("btnmax.BackgroundImage");
            btnmax.BackgroundImageLayout = ImageLayout.Stretch;
            btnmax.FlatStyle = FlatStyle.Flat;
            btnmax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmax.Location = new Point(897, 3);
            btnmax.Name = "btnmax";
            btnmax.Size = new Size(26, 27);
            btnmax.TabIndex = 5;
            btnmax.UseVisualStyleBackColor = false;
            btnmax.Click += btnmax_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Goudy Stout", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbltitle.Location = new Point(12, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(551, 18);
            lbltitle.TabIndex = 4;
            lbltitle.Text = "Doggy's Training and Behavior Tracker";
            lbltitle.Click += lbltitle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(btndash);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnbehave);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btndogprof);
            panel1.Controls.Add(btngoal);
            panel1.Controls.Add(btnsession);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 536);
            panel1.TabIndex = 5;
            // 
            // btndash
            // 
            btndash.BackColor = Color.Peru;
            btndash.FlatStyle = FlatStyle.Flat;
            btndash.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndash.Location = new Point(8, 118);
            btndash.Name = "btndash";
            btndash.Size = new Size(197, 23);
            btndash.TabIndex = 26;
            btndash.Text = "Go to Dashboard";
            btndash.UseVisualStyleBackColor = false;
            btndash.Click += btndash_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(5, 490);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 11;
            pictureBox7.TabStop = false;
            // 
            // btnlogout
            // 
            btnlogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnlogout.BackColor = Color.Transparent;
            btnlogout.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogout.Location = new Point(52, 476);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(158, 56);
            btnlogout.TabIndex = 10;
            btnlogout.Text = "LOG OUT";
            btnlogout.TextAlign = ContentAlignment.MiddleLeft;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(8, 337);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(8, 273);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(8, 214);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnbehave
            // 
            btnbehave.BackColor = Color.Transparent;
            btnbehave.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnbehave.FlatAppearance.BorderSize = 0;
            btnbehave.FlatStyle = FlatStyle.Flat;
            btnbehave.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnbehave.Location = new Point(50, 325);
            btnbehave.Name = "btnbehave";
            btnbehave.Size = new Size(155, 56);
            btnbehave.TabIndex = 5;
            btnbehave.Text = "BEHAVIOR LOGGING";
            btnbehave.TextAlign = ContentAlignment.MiddleLeft;
            btnbehave.UseVisualStyleBackColor = false;
            btnbehave.Click += btnbehave_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 103);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btndogprof
            // 
            btndogprof.BackColor = Color.Transparent;
            btndogprof.FlatAppearance.BorderColor = Color.SaddleBrown;
            btndogprof.FlatAppearance.BorderSize = 0;
            btndogprof.FlatStyle = FlatStyle.Flat;
            btndogprof.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btndogprof.Location = new Point(50, 139);
            btndogprof.Name = "btndogprof";
            btndogprof.Size = new Size(155, 56);
            btndogprof.TabIndex = 2;
            btndogprof.Text = "DOG PROFILE";
            btndogprof.TextAlign = ContentAlignment.MiddleLeft;
            btndogprof.UseVisualStyleBackColor = false;
            btndogprof.Click += btndogprof_Click;
            // 
            // btngoal
            // 
            btngoal.BackColor = Color.Transparent;
            btngoal.FlatAppearance.BorderColor = Color.SaddleBrown;
            btngoal.FlatAppearance.BorderSize = 0;
            btngoal.FlatStyle = FlatStyle.Flat;
            btngoal.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btngoal.Location = new Point(50, 201);
            btngoal.Name = "btngoal";
            btngoal.Size = new Size(155, 56);
            btngoal.TabIndex = 3;
            btngoal.Text = "TRAINING GOAL";
            btngoal.TextAlign = ContentAlignment.MiddleLeft;
            btngoal.UseVisualStyleBackColor = false;
            btngoal.Click += btngoal_Click;
            // 
            // btnsession
            // 
            btnsession.BackColor = Color.Transparent;
            btnsession.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnsession.FlatAppearance.BorderSize = 0;
            btnsession.FlatStyle = FlatStyle.Flat;
            btnsession.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsession.Location = new Point(50, 263);
            btnsession.Name = "btnsession";
            btnsession.Size = new Size(155, 56);
            btnsession.TabIndex = 4;
            btnsession.Text = "DOG TRAINERS";
            btnsession.TextAlign = ContentAlignment.MiddleLeft;
            btnsession.UseVisualStyleBackColor = false;
            btnsession.Click += btnsession_Click;
            // 
            // PanelControl
            // 
            PanelControl.AutoScroll = true;
            PanelControl.BackColor = Color.Transparent;
            PanelControl.Dock = DockStyle.Fill;
            PanelControl.Location = new Point(216, 33);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(744, 536);
            PanelControl.TabIndex = 6;
            // 
            // TheMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 569);
            Controls.Add(PanelControl);
            Controls.Add(panel1);
            Controls.Add(panel3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TheMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TheMain";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnexit;
        private Panel panel3;
        private Panel panel1;
        private Button btndash;
        private PictureBox pictureBox7;
        private Button btnlogout;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Button btnbehave;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btndogprof;
        private Button btngoal;
        private Button btnsession;
        private Panel PanelControl;
        private Label lbltitle;
        private Button btnmax;
        private Button btnmin;
    }
}