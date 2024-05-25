namespace Pawsitive_Training_pt2
{
    partial class frmLogin
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
            panel1 = new Panel();
            label4 = new Label();
            lblbackregis = new Label();
            label5 = new Label();
            btnclear = new Button();
            btnlogin = new Button();
            checkbxShowPass = new CheckBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblbackregis);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnclear);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(checkbxShowPass);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(538, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 367);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Peru;
            label4.Location = new Point(133, 341);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 12;
            label4.Text = "Forgot Password";
            label4.Click += label4_Click;
            // 
            // lblbackregis
            // 
            lblbackregis.AutoSize = true;
            lblbackregis.Cursor = Cursors.Hand;
            lblbackregis.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic);
            lblbackregis.ForeColor = Color.Peru;
            lblbackregis.Location = new Point(228, 319);
            lblbackregis.Name = "lblbackregis";
            lblbackregis.Size = new Size(92, 23);
            lblbackregis.TabIndex = 11;
            lblbackregis.Text = "REGISTER";
            lblbackregis.Click += lblbackregis_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 12F);
            label5.ForeColor = Color.Peru;
            label5.Location = new Point(39, 321);
            label5.Name = "label5";
            label5.Size = new Size(191, 19);
            label5.TabIndex = 10;
            label5.Text = "Don't Have an Account yet?";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Snow;
            btnclear.Cursor = Cursors.Hand;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Cooper Black", 18F);
            btnclear.ForeColor = Color.Chocolate;
            btnclear.Location = new Point(20, 271);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(311, 38);
            btnclear.TabIndex = 9;
            btnclear.Text = "CLEAR ENTRY";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Chocolate;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Cooper Black", 18F);
            btnlogin.ForeColor = Color.SeaShell;
            btnlogin.Location = new Point(20, 224);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(311, 38);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.ForeColor = Color.Sienna;
            checkbxShowPass.Location = new Point(226, 187);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(105, 19);
            checkbxShowPass.TabIndex = 7;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F);
            txtPassword.Location = new Point(20, 153);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(311, 28);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 15.75F);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(20, 124);
            label3.Name = "label3";
            label3.Size = new Size(94, 26);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F);
            txtUsername.Location = new Point(20, 81);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(311, 28);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(99, 26);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 20.25F);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(181, 31);
            label1.TabIndex = 0;
            label1.Text = "Get Started!";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Chocolate;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(899, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(930, 503);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblbackregis;
        private Label label5;
        private Button btnclear;
        private Button btnlogin;
        private CheckBox checkbxShowPass;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Button btnExit;
        private Label label4;
    }
}