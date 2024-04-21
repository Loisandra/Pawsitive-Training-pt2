namespace Pawsitive_Training_pt2
{
    partial class Addlog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtgoal = new TextBox();
            txtloc = new TextBox();
            txtduration = new TextBox();
            txttrainer = new TextBox();
            dtplog = new DateTimePicker();
            comboxincident = new ComboBox();
            comboxinjury = new ComboBox();
            txtdescription = new TextBox();
            label9 = new Label();
            label10 = new Label();
            btnadd = new Button();
            button2 = new Button();
            label11 = new Label();
            txtboxentry = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 87);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Training Goal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 54);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 121);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Duration:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(89, 155);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(101, 191);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Trainer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1, 227);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 5;
            label6.Text = "Was there an incident?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 264);
            label7.Name = "label7";
            label7.Size = new Size(151, 20);
            label7.TabIndex = 6;
            label7.Text = "Was there an injury?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(70, 299);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 7;
            label8.Text = "Description:";
            // 
            // txtgoal
            // 
            txtgoal.Location = new Point(174, 86);
            txtgoal.Name = "txtgoal";
            txtgoal.Size = new Size(167, 23);
            txtgoal.TabIndex = 9;
            // 
            // txtloc
            // 
            txtloc.Location = new Point(174, 155);
            txtloc.Name = "txtloc";
            txtloc.Size = new Size(167, 23);
            txtloc.TabIndex = 10;
            // 
            // txtduration
            // 
            txtduration.Location = new Point(174, 120);
            txtduration.Name = "txtduration";
            txtduration.Size = new Size(167, 23);
            txtduration.TabIndex = 11;
            // 
            // txttrainer
            // 
            txttrainer.Location = new Point(174, 191);
            txttrainer.Name = "txttrainer";
            txttrainer.Size = new Size(167, 23);
            txttrainer.TabIndex = 12;
            // 
            // dtplog
            // 
            dtplog.CustomFormat = "dd-MM-yyyy";
            dtplog.Format = DateTimePickerFormat.Custom;
            dtplog.Location = new Point(174, 51);
            dtplog.Name = "dtplog";
            dtplog.Size = new Size(167, 23);
            dtplog.TabIndex = 13;
            // 
            // comboxincident
            // 
            comboxincident.FormattingEnabled = true;
            comboxincident.Items.AddRange(new object[] { "Yes", "No" });
            comboxincident.Location = new Point(174, 228);
            comboxincident.Name = "comboxincident";
            comboxincident.Size = new Size(167, 23);
            comboxincident.TabIndex = 15;
            // 
            // comboxinjury
            // 
            comboxinjury.FormattingEnabled = true;
            comboxinjury.Items.AddRange(new object[] { "Yes", "No" });
            comboxinjury.Location = new Point(174, 265);
            comboxinjury.Name = "comboxinjury";
            comboxinjury.Size = new Size(167, 23);
            comboxinjury.TabIndex = 16;
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(174, 299);
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(167, 23);
            txtdescription.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(101, 91);
            label9.Name = "label9";
            label9.Size = new Size(73, 13);
            label9.TabIndex = 18;
            label9.Text = "(if none: n/a)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(101, 125);
            label10.Name = "label10";
            label10.Size = new Size(67, 13);
            label10.TabIndex = 19;
            label10.Text = "(in minutes)";
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.SaddleBrown;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.ForeColor = SystemColors.ControlLightLight;
            btnadd.Location = new Point(266, 328);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 20;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(330, 3);
            button2.Name = "button2";
            button2.Size = new Size(20, 27);
            button2.TabIndex = 21;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(78, 24);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 22;
            label11.Text = "Logging no:";
            // 
            // txtboxentry
            // 
            txtboxentry.Location = new Point(174, 24);
            txtboxentry.Name = "txtboxentry";
            txtboxentry.Size = new Size(106, 23);
            txtboxentry.TabIndex = 23;
            // 
            // Addlog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(353, 361);
            Controls.Add(txtboxentry);
            Controls.Add(label11);
            Controls.Add(button2);
            Controls.Add(btnadd);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtdescription);
            Controls.Add(comboxinjury);
            Controls.Add(comboxincident);
            Controls.Add(dtplog);
            Controls.Add(txttrainer);
            Controls.Add(txtduration);
            Controls.Add(txtloc);
            Controls.Add(txtgoal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Addlog";
            Text = "Addlog";
            Load += Addlog_Load;
            MouseDown += Addlog_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtgoal;
        private TextBox txtloc;
        private TextBox txtduration;
        private TextBox txttrainer;
        private DateTimePicker dtplog;
        private ComboBox comboxincident;
        private ComboBox comboxinjury;
        private TextBox txtdescription;
        private Label label9;
        private Label label10;
        private Button btnadd;
        private Button button2;
        private Label label11;
        private TextBox txtboxentry;
    }
}