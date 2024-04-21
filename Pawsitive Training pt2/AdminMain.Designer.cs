namespace Pawsitive_Training_pt2
{
    partial class AdminMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
            panel3 = new Panel();
            btnmin = new Button();
            btnmax = new Button();
            lbltitle = new Label();
            btnexit = new Button();
            panel1 = new Panel();
            btnlogout = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnusers = new Button();
            btnfeed = new Button();
            btnreport = new Button();
            paneladmin = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel3.Size = new Size(828, 33);
            panel3.TabIndex = 5;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // btnmin
            // 
            btnmin.BackColor = Color.Chocolate;
            btnmin.BackgroundImage = (Image)resources.GetObject("btnmin.BackgroundImage");
            btnmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnmin.FlatStyle = FlatStyle.Flat;
            btnmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmin.Location = new Point(732, 3);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(26, 27);
            btnmin.TabIndex = 6;
            btnmin.UseVisualStyleBackColor = false;
            btnmin.Click += btnmin_Click;
            // 
            // btnmax
            // 
            btnmax.BackColor = Color.Chocolate;
            btnmax.BackgroundImage = (Image)resources.GetObject("btnmax.BackgroundImage");
            btnmax.BackgroundImageLayout = ImageLayout.Stretch;
            btnmax.FlatStyle = FlatStyle.Flat;
            btnmax.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmax.Location = new Point(764, 3);
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
            lbltitle.Size = new Size(90, 18);
            lbltitle.TabIndex = 4;
            lbltitle.Text = "ADMIN";
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Chocolate;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(796, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(26, 27);
            btnexit.TabIndex = 3;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnusers);
            panel1.Controls.Add(btnfeed);
            panel1.Controls.Add(btnreport);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 415);
            panel1.TabIndex = 6;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Transparent;
            btnlogout.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogout.Location = new Point(12, 359);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(198, 56);
            btnlogout.TabIndex = 10;
            btnlogout.Text = "LOG OUT";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnusers
            // 
            btnusers.BackColor = Color.Transparent;
            btnusers.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnusers.FlatAppearance.BorderSize = 0;
            btnusers.FlatStyle = FlatStyle.Flat;
            btnusers.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnusers.Location = new Point(12, 139);
            btnusers.Name = "btnusers";
            btnusers.Size = new Size(181, 56);
            btnusers.TabIndex = 2;
            btnusers.Text = "USERS";
            btnusers.UseVisualStyleBackColor = false;
            btnusers.Click += btnusers_Click;
            // 
            // btnfeed
            // 
            btnfeed.BackColor = Color.Transparent;
            btnfeed.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnfeed.FlatAppearance.BorderSize = 0;
            btnfeed.FlatStyle = FlatStyle.Flat;
            btnfeed.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnfeed.Location = new Point(12, 201);
            btnfeed.Name = "btnfeed";
            btnfeed.Size = new Size(181, 56);
            btnfeed.TabIndex = 3;
            btnfeed.Text = "FEEDBACKS";
            btnfeed.UseVisualStyleBackColor = false;
            btnfeed.Click += btnfeed_Click;
            // 
            // btnreport
            // 
            btnreport.BackColor = Color.Transparent;
            btnreport.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnreport.FlatAppearance.BorderSize = 0;
            btnreport.FlatStyle = FlatStyle.Flat;
            btnreport.Font = new Font("Segoe UI Variable Display", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnreport.Location = new Point(12, 263);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(181, 56);
            btnreport.TabIndex = 4;
            btnreport.Text = "REPORTS/CONCERNS";
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // paneladmin
            // 
            paneladmin.BackColor = Color.Transparent;
            paneladmin.Dock = DockStyle.Fill;
            paneladmin.Location = new Point(216, 33);
            paneladmin.Name = "paneladmin";
            paneladmin.Size = new Size(612, 415);
            paneladmin.TabIndex = 7;
            paneladmin.MouseDown += paneladmin_MouseDown;
            // 
            // AdminMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 448);
            Controls.Add(paneladmin);
            Controls.Add(panel1);
            Controls.Add(panel3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMain";
            Text = "AdminMain";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btnmin;
        private Button btnmax;
        private Label lbltitle;
        private Button btnexit;
        private Panel panel1;
        private Button btnlogout;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnusers;
        private Button btnfeed;
        private Button btnreport;
        private Panel paneladmin;
    }
}