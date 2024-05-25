namespace Pawsitive_Training_pt2
{
    partial class AdminReport
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
            dgvReport = new DataGridView();
            btnsubmit = new Button();
            txtboxresponse = new TextBox();
            label2 = new Label();
            comboboxreport = new ComboBox();
            comboboxuser = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(dgvReport);
            panel1.Location = new Point(23, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 215);
            panel1.TabIndex = 2;
            // 
            // dgvReport
            // 
            dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(17, 19);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.Size = new Size(535, 175);
            dgvReport.TabIndex = 0;
            // 
            // btnsubmit
            // 
            btnsubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnsubmit.BackColor = Color.Sienna;
            btnsubmit.FlatStyle = FlatStyle.Flat;
            btnsubmit.ForeColor = Color.White;
            btnsubmit.Location = new Point(467, 373);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(133, 30);
            btnsubmit.TabIndex = 22;
            btnsubmit.Text = "SUBMIT RESPONSE";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // txtboxresponse
            // 
            txtboxresponse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtboxresponse.Location = new Point(23, 293);
            txtboxresponse.Multiline = true;
            txtboxresponse.Name = "txtboxresponse";
            txtboxresponse.Size = new Size(430, 112);
            txtboxresponse.TabIndex = 21;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(23, 273);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 20;
            label2.Text = "Response:";
            // 
            // comboboxreport
            // 
            comboboxreport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboboxreport.FormattingEnabled = true;
            comboboxreport.Location = new Point(404, 249);
            comboboxreport.Name = "comboboxreport";
            comboboxreport.Size = new Size(186, 23);
            comboboxreport.TabIndex = 19;
            comboboxreport.SelectedIndexChanged += comboboxreport_SelectedIndexChanged;
            // 
            // comboboxuser
            // 
            comboboxuser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboboxuser.FormattingEnabled = true;
            comboboxuser.Location = new Point(116, 248);
            comboboxuser.Name = "comboboxuser";
            comboboxuser.Size = new Size(151, 23);
            comboboxuser.TabIndex = 18;
            comboboxuser.SelectedIndexChanged += comboboxuser_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(23, 249);
            label1.Name = "label1";
            label1.Size = new Size(87, 17);
            label1.TabIndex = 17;
            label1.Text = "Choose User:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(284, 250);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 24;
            label3.Text = "Choose Report:";
            // 
            // AdminReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(612, 415);
            Controls.Add(label3);
            Controls.Add(btnsubmit);
            Controls.Add(txtboxresponse);
            Controls.Add(label2);
            Controls.Add(comboboxreport);
            Controls.Add(comboboxuser);
            Controls.Add(label1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminReport";
            Text = "AdminReport";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvReport;
        private Button btnsubmit;
        private TextBox txtboxresponse;
        private Label label2;
        private ComboBox comboboxreport;
        private ComboBox comboboxuser;
        private Label label1;
        private Label label3;
    }
}