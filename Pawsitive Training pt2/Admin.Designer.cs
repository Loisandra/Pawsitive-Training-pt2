namespace Pawsitive_Training_pt2
{
    partial class Admin
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
            panel2 = new Panel();
            dgvReport = new DataGridView();
            label1 = new Label();
            comboboxuser = new ComboBox();
            comboboxreport = new ComboBox();
            label2 = new Label();
            txtboxresponse = new TextBox();
            btnsubmit = new Button();
            btnlogout = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Sienna;
            panel2.Controls.Add(dgvReport);
            panel2.Location = new Point(260, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 245);
            panel2.TabIndex = 5;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(16, 14);
            dgvReport.Name = "dgvReport";
            dgvReport.RowTemplate.Height = 25;
            dgvReport.Size = new Size(619, 215);
            dgvReport.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(495, 297);
            label1.Name = "label1";
            label1.Size = new Size(137, 17);
            label1.TabIndex = 9;
            label1.Text = "Choose user - report:";
            // 
            // comboboxuser
            // 
            comboboxuser.FormattingEnabled = true;
            comboboxuser.Location = new Point(630, 296);
            comboboxuser.Name = "comboboxuser";
            comboboxuser.Size = new Size(118, 23);
            comboboxuser.TabIndex = 10;
            comboboxuser.SelectedIndexChanged += comboboxuser_SelectedIndexChanged;
            // 
            // comboboxreport
            // 
            comboboxreport.FormattingEnabled = true;
            comboboxreport.Location = new Point(754, 296);
            comboboxreport.Name = "comboboxreport";
            comboboxreport.Size = new Size(186, 23);
            comboboxreport.TabIndex = 11;
            comboboxreport.SelectedIndexChanged += comboboxreport_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(498, 328);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 12;
            label2.Text = "Response:";
            // 
            // txtboxresponse
            // 
            txtboxresponse.Location = new Point(510, 348);
            txtboxresponse.Multiline = true;
            txtboxresponse.Name = "txtboxresponse";
            txtboxresponse.Size = new Size(430, 112);
            txtboxresponse.TabIndex = 13;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.Sienna;
            btnsubmit.FlatStyle = FlatStyle.Flat;
            btnsubmit.ForeColor = Color.White;
            btnsubmit.Location = new Point(807, 466);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(133, 30);
            btnsubmit.TabIndex = 14;
            btnsubmit.Text = "SUBMIT RESPONSE";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Sienna;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(872, 502);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(68, 30);
            btnlogout.TabIndex = 16;
            btnlogout.Text = "LOGOUT";
            btnlogout.UseVisualStyleBackColor = false;
            //btnlogout.Click += btnlogout_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 538);
            Controls.Add(btnlogout);
            Controls.Add(btnsubmit);
            Controls.Add(txtboxresponse);
            Controls.Add(label2);
            Controls.Add(comboboxreport);
            Controls.Add(comboboxuser);
            Controls.Add(label1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private DataGridView dgvReport;
        private Label label1;
        private ComboBox comboboxuser;
        private ComboBox comboboxreport;
        private Label label2;
        private TextBox txtboxresponse;
        private Button btnsubmit;
        private Button btnlogout;
    }
}