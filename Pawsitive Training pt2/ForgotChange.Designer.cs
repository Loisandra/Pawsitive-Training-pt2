namespace Pawsitive_Training_pt2
{
    partial class ForgotChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotChange));
            btnExit = new Button();
            panel1 = new Panel();
            checkbxShowPass = new CheckBox();
            txtConPass = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnconfirm = new Button();
            txtUsername = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Chocolate;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(489, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(checkbxShowPass);
            panel1.Controls.Add(txtConPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnconfirm);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(36, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 449);
            panel1.TabIndex = 6;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.ForeColor = Color.Sienna;
            checkbxShowPass.Location = new Point(242, 339);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(105, 19);
            checkbxShowPass.TabIndex = 15;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // txtConPass
            // 
            txtConPass.BackColor = Color.FromArgb(230, 231, 233);
            txtConPass.BorderStyle = BorderStyle.None;
            txtConPass.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConPass.Location = new Point(79, 308);
            txtConPass.Multiline = true;
            txtConPass.Name = "txtConPass";
            txtConPass.PasswordChar = '*';
            txtConPass.Size = new Size(268, 25);
            txtConPass.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 11.25F);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(79, 287);
            label3.Name = "label3";
            label3.Size = new Size(152, 18);
            label3.TabIndex = 13;
            label3.Text = "Confirm New Password";
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(230, 231, 233);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(79, 250);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(268, 25);
            txtPass.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 11.25F);
            label1.ForeColor = Color.SandyBrown;
            label1.Location = new Point(79, 229);
            label1.Name = "label1";
            label1.Size = new Size(99, 18);
            label1.TabIndex = 11;
            label1.Text = "New Password";
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
            btnconfirm.Location = new Point(63, 387);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(311, 38);
            btnconfirm.TabIndex = 8;
            btnconfirm.Text = "CONFIRM";
            btnconfirm.UseVisualStyleBackColor = false;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(79, 197);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
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
            // ForgotChange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(521, 516);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotChange";
            Text = "ForgotChange";
            MouseDown += ForgotChange_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Panel panel1;
        private TextBox txtConPass;
        private Label label3;
        private TextBox txtPass;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnconfirm;
        private TextBox txtUsername;
        private Label label2;
        private CheckBox checkbxShowPass;
    }
}