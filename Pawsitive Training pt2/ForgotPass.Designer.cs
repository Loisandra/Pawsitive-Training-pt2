namespace Pawsitive_Training_pt2
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            panel1 = new Panel();
            dtpbirth = new DateTimePicker();
            label3 = new Label();
            txtDogName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnconfirm = new Button();
            txtUsername = new TextBox();
            label2 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtpbirth);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDogName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnconfirm);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(33, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 449);
            panel1.TabIndex = 2;
            // 
            // dtpbirth
            // 
            dtpbirth.CustomFormat = "dd-MM-yyyy";
            dtpbirth.Format = DateTimePickerFormat.Custom;
            dtpbirth.Location = new Point(79, 308);
            dtpbirth.Name = "dtpbirth";
            dtpbirth.Size = new Size(268, 23);
            dtpbirth.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 11.25F);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(79, 287);
            label3.Name = "label3";
            label3.Size = new Size(124, 18);
            label3.TabIndex = 13;
            label3.Text = "Dog's Date of Birth";
            // 
            // txtDogName
            // 
            txtDogName.BackColor = Color.FromArgb(230, 231, 233);
            txtDogName.BorderStyle = BorderStyle.None;
            txtDogName.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDogName.Location = new Point(79, 250);
            txtDogName.Multiline = true;
            txtDogName.Name = "txtDogName";
            txtDogName.Size = new Size(268, 25);
            txtDogName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 11.25F);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(79, 229);
            label1.Name = "label1";
            label1.Size = new Size(73, 18);
            label1.TabIndex = 11;
            label1.Text = "Dog Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnconfirm
            // 
            btnconfirm.BackColor = Color.Chocolate;
            btnconfirm.Cursor = Cursors.Hand;
            btnconfirm.FlatAppearance.BorderSize = 0;
            btnconfirm.FlatStyle = FlatStyle.Flat;
            btnconfirm.Font = new Font("Cooper Black", 18F);
            btnconfirm.ForeColor = Color.SeaShell;
            btnconfirm.Location = new Point(62, 356);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(311, 38);
            btnconfirm.TabIndex = 8;
            btnconfirm.Text = "CONFIRM";
            btnconfirm.UseVisualStyleBackColor = false;
            btnconfirm.Click += btnconfirm_Click_1;
            btnconfirm.MouseDown += btnconfirm_MouseDown;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(79, 197);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(268, 25);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 11.25F);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(79, 176);
            label2.Name = "label2";
            label2.Size = new Size(70, 18);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Chocolate;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(490, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(521, 516);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPass";
            Text = "ForgotPass";
            MouseDown += ForgotPass_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnconfirm;
        private Label label2;
        private Label label3;
        private TextBox txtDogName;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private DateTimePicker dtpbirth;
        private Button btnExit;
    }
}