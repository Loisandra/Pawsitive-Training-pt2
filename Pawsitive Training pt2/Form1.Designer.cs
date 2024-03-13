namespace Pawsitive_Training_pt2
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            panel1 = new Panel();
            lblbacklogin = new Label();
            label5 = new Label();
            btnclear = new Button();
            btnregister = new Button();
            checkbxShowPass = new CheckBox();
            txtComPassword = new TextBox();
            label4 = new Label();
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
            panel1.Controls.Add(lblbacklogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnclear);
            panel1.Controls.Add(btnregister);
            panel1.Controls.Add(checkbxShowPass);
            panel1.Controls.Add(txtComPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(544, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 435);
            panel1.TabIndex = 0;
            // 
            // lblbacklogin
            // 
            lblbacklogin.AutoSize = true;
            lblbacklogin.Cursor = Cursors.Hand;
            lblbacklogin.Font = new Font("Corbel", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblbacklogin.ForeColor = Color.Peru;
            lblbacklogin.Location = new Point(237, 402);
            lblbacklogin.Name = "lblbacklogin";
            lblbacklogin.Size = new Size(64, 23);
            lblbacklogin.TabIndex = 11;
            lblbacklogin.Text = "LOGIN";
            lblbacklogin.Click += lblbacklogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Peru;
            label5.Location = new Point(61, 404);
            label5.Name = "label5";
            label5.Size = new Size(181, 19);
            label5.TabIndex = 10;
            label5.Text = "Already Have an Account?";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Snow;
            btnclear.Cursor = Cursors.Hand;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.ForeColor = Color.Chocolate;
            btnclear.Location = new Point(21, 356);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(311, 38);
            btnclear.TabIndex = 9;
            btnclear.Text = "CLEAR ENTRY";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.Chocolate;
            btnregister.Cursor = Cursors.Hand;
            btnregister.FlatAppearance.BorderSize = 0;
            btnregister.FlatStyle = FlatStyle.Flat;
            btnregister.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnregister.ForeColor = Color.SeaShell;
            btnregister.Location = new Point(21, 309);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(311, 38);
            btnregister.TabIndex = 8;
            btnregister.Text = "REGISTER";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Cursor = Cursors.Hand;
            checkbxShowPass.FlatStyle = FlatStyle.Flat;
            checkbxShowPass.ForeColor = Color.Sienna;
            checkbxShowPass.Location = new Point(224, 275);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(105, 19);
            checkbxShowPass.TabIndex = 7;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(21, 241);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(311, 28);
            txtComPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.SandyBrown;
            label4.Location = new Point(21, 212);
            label4.Name = "label4";
            label4.Size = new Size(167, 26);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(21, 166);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(311, 28);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.SandyBrown;
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(94, 26);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(21, 94);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(311, 28);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SandyBrown;
            label2.Location = new Point(21, 65);
            label2.Name = "label2";
            label2.Size = new Size(99, 26);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(251, 31);
            label1.TabIndex = 0;
            label1.Text = "Let's Get Started!";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Chocolate;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(899, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(930, 496);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAWsitive Training";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Button btnregister;
        private CheckBox checkbxShowPass;
        private TextBox txtComPassword;
        private Label label4;
        private Button btnclear;
        private Label lblbacklogin;
        private Label label5;
        private Button btnExit;
    }
}