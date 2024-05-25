namespace Pawsitive_Training_pt2
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel3 = new Panel();
            label8 = new Label();
            lblgender = new Label();
            lblbirth = new Label();
            lblbreed = new Label();
            lbldogname = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnsave = new Button();
            btndel = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtboxname = new TextBox();
            txtboxbreed = new TextBox();
            dtpbirth = new DateTimePicker();
            btnupload = new Button();
            picprofile = new PictureBox();
            label4 = new Label();
            comboboxgender = new ComboBox();
            btnremove = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picprofile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Peru;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblgender);
            panel3.Controls.Add(lblbirth);
            panel3.Controls.Add(lblbreed);
            panel3.Controls.Add(lbldogname);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(55, 260);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 253);
            panel3.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(177, 5);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 12;
            label8.Text = "GENDER:";
            // 
            // lblgender
            // 
            lblgender.Anchor = AnchorStyles.None;
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblgender.Location = new Point(204, 52);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(16, 21);
            lblgender.TabIndex = 11;
            lblgender.Text = "-";
            lblgender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblbirth
            // 
            lblbirth.Anchor = AnchorStyles.None;
            lblbirth.AutoSize = true;
            lblbirth.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblbirth.Location = new Point(43, 217);
            lblbirth.Name = "lblbirth";
            lblbirth.Size = new Size(107, 21);
            lblbirth.TabIndex = 10;
            lblbirth.Text = "No birthdate";
            lblbirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblbreed
            // 
            lblbreed.Anchor = AnchorStyles.None;
            lblbreed.AutoSize = true;
            lblbreed.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lblbreed.Location = new Point(43, 140);
            lblbreed.Name = "lblbreed";
            lblbreed.Size = new Size(81, 21);
            lblbreed.TabIndex = 9;
            lblbreed.Text = "No breed";
            lblbreed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldogname
            // 
            lbldogname.Anchor = AnchorStyles.None;
            lbldogname.AutoSize = true;
            lbldogname.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            lbldogname.Location = new Point(43, 52);
            lbldogname.Name = "lbldogname";
            lbldogname.Size = new Size(78, 21);
            lbldogname.TabIndex = 8;
            lbldogname.Text = "No name";
            lbldogname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 180);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 7;
            label3.Text = "BIRTHDATE:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 6;
            label2.Text = "DOG BREED:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 5;
            label1.Text = "DOG NAME:";
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.None;
            btnsave.BackColor = Color.SaddleBrown;
            btnsave.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(97, 258);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(66, 31);
            btnsave.TabIndex = 11;
            btnsave.Text = "ENTER";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btndel
            // 
            btndel.Anchor = AnchorStyles.None;
            btndel.BackColor = Color.SaddleBrown;
            btndel.FlatAppearance.BorderColor = Color.SaddleBrown;
            btndel.FlatStyle = FlatStyle.Popup;
            btndel.ForeColor = Color.White;
            btndel.Location = new Point(176, 258);
            btndel.Name = "btndel";
            btndel.Size = new Size(66, 31);
            btndel.TabIndex = 13;
            btndel.Text = "DELETE";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label5.Location = new Point(24, 9);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 11;
            label5.Text = "Enter Dog Name:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label6.Location = new Point(24, 67);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 14;
            label6.Text = "Enter Dog Breed:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label7.Location = new Point(24, 124);
            label7.Name = "label7";
            label7.Size = new Size(166, 21);
            label7.TabIndex = 15;
            label7.Text = "Enter Dog Birthdate:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtboxname
            // 
            txtboxname.Anchor = AnchorStyles.None;
            txtboxname.Location = new Point(27, 38);
            txtboxname.Name = "txtboxname";
            txtboxname.Size = new Size(215, 23);
            txtboxname.TabIndex = 16;
            // 
            // txtboxbreed
            // 
            txtboxbreed.Anchor = AnchorStyles.None;
            txtboxbreed.Location = new Point(27, 98);
            txtboxbreed.Name = "txtboxbreed";
            txtboxbreed.Size = new Size(215, 23);
            txtboxbreed.TabIndex = 17;
            // 
            // dtpbirth
            // 
            dtpbirth.Anchor = AnchorStyles.None;
            dtpbirth.CustomFormat = "dd-MM-yyyy";
            dtpbirth.Format = DateTimePickerFormat.Custom;
            dtpbirth.Location = new Point(27, 153);
            dtpbirth.Name = "dtpbirth";
            dtpbirth.Size = new Size(215, 23);
            dtpbirth.TabIndex = 18;
            // 
            // btnupload
            // 
            btnupload.Anchor = AnchorStyles.Bottom;
            btnupload.BackColor = Color.SaddleBrown;
            btnupload.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnupload.FlatStyle = FlatStyle.Popup;
            btnupload.ForeColor = Color.White;
            btnupload.Location = new Point(115, 201);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(90, 45);
            btnupload.TabIndex = 20;
            btnupload.Text = "UPLOAD PHOTO";
            btnupload.UseVisualStyleBackColor = false;
            btnupload.Click += btnupload_Click;
            // 
            // picprofile
            // 
            picprofile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picprofile.BackColor = Color.White;
            picprofile.BackgroundImageLayout = ImageLayout.Stretch;
            picprofile.Image = (Image)resources.GetObject("picprofile.Image");
            picprofile.Location = new Point(103, 21);
            picprofile.Name = "picprofile";
            picprofile.Size = new Size(212, 174);
            picprofile.SizeMode = PictureBoxSizeMode.StretchImage;
            picprofile.TabIndex = 22;
            picprofile.TabStop = false;
            picprofile.Click += picprofile_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold);
            label4.Location = new Point(26, 183);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 23;
            label4.Text = "Enter Dog Gender:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboboxgender
            // 
            comboboxgender.Anchor = AnchorStyles.None;
            comboboxgender.FormattingEnabled = true;
            comboboxgender.Items.AddRange(new object[] { "Female", "Male" });
            comboboxgender.Location = new Point(27, 207);
            comboboxgender.Name = "comboboxgender";
            comboboxgender.Size = new Size(150, 23);
            comboboxgender.TabIndex = 24;
            // 
            // btnremove
            // 
            btnremove.Anchor = AnchorStyles.Bottom;
            btnremove.BackColor = Color.SaddleBrown;
            btnremove.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnremove.FlatStyle = FlatStyle.Popup;
            btnremove.ForeColor = Color.White;
            btnremove.Location = new Point(211, 201);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(90, 45);
            btnremove.TabIndex = 25;
            btnremove.Text = "REMOVE PHOTO";
            btnremove.UseVisualStyleBackColor = false;
            btnremove.Click += btnremove_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(414, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboboxgender);
            panel1.Controls.Add(btnsave);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btndel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtboxname);
            panel1.Controls.Add(dtpbirth);
            panel1.Controls.Add(txtboxbreed);
            panel1.Location = new Point(408, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 295);
            panel1.TabIndex = 13;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(744, 536);
            Controls.Add(btnremove);
            Controls.Add(picprofile);
            Controls.Add(btnupload);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAWSITIVE TRAINING";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picprofile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblbreed;
        private Label lbldogname;
        private Label lblbirth;
        private Button btnsave;
        private Button btndel;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtboxname;
        private TextBox txtboxbreed;
        private DateTimePicker dtpbirth;
        private Button btnupload;
        private PictureBox picprofile;
        private Label label4;
        private ComboBox comboboxgender;
        private Label lblgender;
        private Label label8;
        private Button btnremove;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}