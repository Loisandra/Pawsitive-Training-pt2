namespace Pawsitive_Training_pt2
{
    partial class Report
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
            txtboxreport = new TextBox();
            label1 = new Label();
            btnsubmit = new Button();
            panel1 = new Panel();
            lblresponse = new Label();
            label5 = new Label();
            lblreport = new Label();
            label3 = new Label();
            btnview = new Button();
            comboboxreport = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.Location = new Point(867, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(31, 27);
            btnexit.TabIndex = 4;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // txtboxreport
            // 
            txtboxreport.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxreport.Location = new Point(12, 114);
            txtboxreport.Multiline = true;
            txtboxreport.Name = "txtboxreport";
            txtboxreport.Size = new Size(402, 280);
            txtboxreport.TabIndex = 7;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(382, 78);
            label1.TabIndex = 6;
            label1.Text = "Are you facing an issue with Pawsitive Training? Describe the issue in detail, and we'll be happy to help.";
            label1.Click += label1_Click;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.Sienna;
            btnsubmit.FlatStyle = FlatStyle.Flat;
            btnsubmit.ForeColor = Color.White;
            btnsubmit.Location = new Point(309, 400);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(105, 33);
            btnsubmit.TabIndex = 9;
            btnsubmit.Text = "SUBMIT";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(lblresponse);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblreport);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnview);
            panel1.Controls.Add(comboboxreport);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(420, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 400);
            panel1.TabIndex = 10;
            // 
            // lblresponse
            // 
            lblresponse.BackColor = Color.Transparent;
            lblresponse.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblresponse.Location = new Point(34, 244);
            lblresponse.Name = "lblresponse";
            lblresponse.Size = new Size(412, 104);
            lblresponse.TabIndex = 16;
            lblresponse.Text = "---";
            lblresponse.Click += lblresponse_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 216);
            label5.Name = "label5";
            label5.Size = new Size(382, 34);
            label5.TabIndex = 15;
            label5.Text = "Response:";
            // 
            // lblreport
            // 
            lblreport.BackColor = Color.Transparent;
            lblreport.Font = new Font("Segoe UI Variable Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblreport.Location = new Point(34, 104);
            lblreport.Name = "lblreport";
            lblreport.Size = new Size(412, 112);
            lblreport.TabIndex = 14;
            lblreport.Text = "---";
            lblreport.Click += lblreport_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 70);
            label3.Name = "label3";
            label3.Size = new Size(382, 34);
            label3.TabIndex = 13;
            label3.Text = "Report:";
            // 
            // btnview
            // 
            btnview.BackColor = Color.Sienna;
            btnview.FlatStyle = FlatStyle.Flat;
            btnview.Location = new Point(251, 30);
            btnview.Name = "btnview";
            btnview.Size = new Size(125, 23);
            btnview.TabIndex = 11;
            btnview.Text = "VIEW";
            btnview.UseVisualStyleBackColor = false;
            btnview.Click += btnview_Click;
            // 
            // comboboxreport
            // 
            comboboxreport.FormattingEnabled = true;
            comboboxreport.Location = new Point(10, 30);
            comboboxreport.Name = "comboboxreport";
            comboboxreport.Size = new Size(235, 23);
            comboboxreport.TabIndex = 12;
            comboboxreport.SelectedIndexChanged += comboboxreport_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 2);
            label2.Name = "label2";
            label2.Size = new Size(382, 34);
            label2.TabIndex = 11;
            label2.Text = "We Heard You!";
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 448);
            Controls.Add(panel1);
            Controls.Add(btnsubmit);
            Controls.Add(txtboxreport);
            Controls.Add(label1);
            Controls.Add(btnexit);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            Load += Report_Load_1;
            MouseDown += Report_MouseDown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private TextBox txtboxreport;
        private Label label1;
        private Button btnsubmit;
        private Panel panel1;
        private Label label2;
        private Button btnview;
        private ComboBox comboboxreport;
        private Label lblresponse;
        private Label label5;
        private Label lblreport;
        private Label label3;
    }
}