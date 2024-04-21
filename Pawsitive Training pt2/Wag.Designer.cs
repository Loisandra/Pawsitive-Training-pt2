namespace Pawsitive_Training_pt2
{
    partial class Wag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wag));
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnexit = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 192);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
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
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(30, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 14);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(422, 8);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(31, 27);
            btnexit.TabIndex = 14;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Goudy Stout", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(398, 37);
            label1.TabIndex = 13;
            label1.Text = "WAGGING TAIL";
            label1.Click += label1_Click;
            // 
            // Wag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(458, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnexit);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Wag";
            Text = "Wag";
            MouseDown += Wag_MouseDown;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnexit;
        private Label label1;
    }
}