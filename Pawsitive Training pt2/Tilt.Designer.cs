namespace Pawsitive_Training_pt2
{
    partial class Tilt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tilt));
            label1 = new Label();
            btnexit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Goudy Stout", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(391, 37);
            label1.TabIndex = 7;
            label1.Text = "TILTING HEAD";
            // 
            // btnexit
            // 
            btnexit.Location = new Point(421, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(31, 27);
            btnexit.TabIndex = 8;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shutterstock_1073296643;
            pictureBox1.Location = new Point(38, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(231, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 139);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(29, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 14);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 192);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 2);
            label2.Name = "label2";
            label2.Size = new Size(420, 217);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Tilt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(458, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tilt";
            Text = "Tilt";
            MouseDown += Tilt_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnexit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}