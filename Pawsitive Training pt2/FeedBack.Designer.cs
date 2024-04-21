namespace Pawsitive_Training_pt2
{
    partial class FeedBack
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
            btnexit = new Button();
            label1 = new Label();
            txtboxFeed = new TextBox();
            label2 = new Label();
            comboboxrate = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.Location = new Point(392, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(31, 27);
            btnexit.TabIndex = 3;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(382, 33);
            label1.TabIndex = 4;
            label1.Text = "Share your feedback here. We value your input!";
            // 
            // txtboxFeed
            // 
            txtboxFeed.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxFeed.Location = new Point(12, 68);
            txtboxFeed.Multiline = true;
            txtboxFeed.Name = "txtboxFeed";
            txtboxFeed.Size = new Size(402, 142);
            txtboxFeed.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 222);
            label2.Name = "label2";
            label2.Size = new Size(382, 73);
            label2.TabIndex = 6;
            label2.Text = "To help us improve, could you please rate your experience with our app from 1 (least satisfied) to 5 (most satisfied)?";
            // 
            // comboboxrate
            // 
            comboboxrate.FormattingEnabled = true;
            comboboxrate.Items.AddRange(new object[] { "5", "4", "3", "2", "1" });
            comboboxrate.Location = new Point(12, 298);
            comboboxrate.Name = "comboboxrate";
            comboboxrate.Size = new Size(172, 23);
            comboboxrate.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(312, 337);
            button1.Name = "button1";
            button1.Size = new Size(105, 33);
            button1.TabIndex = 8;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FeedBack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(426, 381);
            Controls.Add(button1);
            Controls.Add(comboboxrate);
            Controls.Add(label2);
            Controls.Add(txtboxFeed);
            Controls.Add(label1);
            Controls.Add(btnexit);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeedBack";
            Text = "FeedBack";
            MouseDown += FeedBack_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private Label label1;
        private TextBox txtboxFeed;
        private Label label2;
        private ComboBox comboboxrate;
        private Button button1;
    }
}