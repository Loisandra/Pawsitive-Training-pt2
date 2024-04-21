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
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picprofile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
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
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(177, 5);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 12;
            label8.Text = "GENDER:";
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblgender.Location = new Point(204, 52);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(16, 21);
            lblgender.TabIndex = 11;
            lblgender.Text = "-";
            lblgender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblbirth
            // 
            lblbirth.AutoSize = true;
            lblbirth.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblbirth.Location = new Point(43, 217);
            lblbirth.Name = "lblbirth";
            lblbirth.Size = new Size(107, 21);
            lblbirth.TabIndex = 10;
            lblbirth.Text = "No birthdate";
            lblbirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblbreed
            // 
            lblbreed.AutoSize = true;
            lblbreed.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblbreed.Location = new Point(43, 140);
            lblbreed.Name = "lblbreed";
            lblbreed.Size = new Size(81, 21);
            lblbreed.TabIndex = 9;
            lblbreed.Text = "No breed";
            lblbreed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbldogname
            // 
            lbldogname.AutoSize = true;
            lbldogname.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldogname.Location = new Point(43, 52);
            lbldogname.Name = "lbldogname";
            lbldogname.Size = new Size(78, 21);
            lbldogname.TabIndex = 8;
            lbldogname.Text = "No name";
            lbldogname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 180);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 7;
            label3.Text = "BIRTHDATE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 6;
            label2.Text = "DOG BREED:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 5;
            label1.Text = "DOG NAME:";
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.SaddleBrown;
            btnsave.FlatAppearance.BorderColor = Color.SaddleBrown;
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(501, 482);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(66, 31);
            btnsave.TabIndex = 11;
            btnsave.Text = "ENTER";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btndel
            // 
            btndel.BackColor = Color.SaddleBrown;
            btndel.FlatAppearance.BorderColor = Color.SaddleBrown;
            btndel.FlatStyle = FlatStyle.Popup;
            btndel.ForeColor = Color.White;
            btndel.Location = new Point(580, 482);
            btndel.Name = "btndel";
            btndel.Size = new Size(66, 31);
            btndel.TabIndex = 13;
            btndel.Text = "DELETE";
            btndel.UseVisualStyleBackColor = false;
            btndel.Click += btndel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(428, 233);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 11;
            label5.Text = "Enter Dog Name:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(428, 291);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 14;
            label6.Text = "Enter Dog Breed:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(428, 348);
            label7.Name = "label7";
            label7.Size = new Size(166, 21);
            label7.TabIndex = 15;
            label7.Text = "Enter Dog Birthdate:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtboxname
            // 
            txtboxname.Location = new Point(431, 262);
            txtboxname.Name = "txtboxname";
            txtboxname.Size = new Size(215, 23);
            txtboxname.TabIndex = 16;
            // 
            // txtboxbreed
            // 
            txtboxbreed.Location = new Point(431, 322);
            txtboxbreed.Name = "txtboxbreed";
            txtboxbreed.Size = new Size(215, 23);
            txtboxbreed.TabIndex = 17;
            // 
            // dtpbirth
            // 
            dtpbirth.CustomFormat = "dd-MM-yyyy";
            dtpbirth.Format = DateTimePickerFormat.Custom;
            dtpbirth.Location = new Point(431, 377);
            dtpbirth.Name = "dtpbirth";
            dtpbirth.Size = new Size(215, 23);
            dtpbirth.TabIndex = 18;
            // 
            // btnupload
            // 
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
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(430, 407);
            label4.Name = "label4";
            label4.Size = new Size(151, 21);
            label4.TabIndex = 23;
            label4.Text = "Enter Dog Gender:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboboxgender
            // 
            comboboxgender.FormattingEnabled = true;
            comboboxgender.Items.AddRange(new object[] { "Female", "Male" });
            comboboxgender.Location = new Point(431, 431);
            comboboxgender.Name = "comboboxgender";
            comboboxgender.Size = new Size(150, 23);
            comboboxgender.TabIndex = 24;
            // 
            // btnremove
            // 
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
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(428, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 191);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            Controls.Add(comboboxgender);
            Controls.Add(label4);
            Controls.Add(picprofile);
            Controls.Add(btnupload);
            Controls.Add(pictureBox2);
            Controls.Add(dtpbirth);
            Controls.Add(txtboxbreed);
            Controls.Add(txtboxname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btndel);
            Controls.Add(btnsave);
            Controls.Add(panel3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAWSITIVE TRAINING";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picprofile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}