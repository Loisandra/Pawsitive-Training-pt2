﻿namespace Pawsitive_Training_pt2
{
    partial class AdminFeed
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
            dgvFeedBack = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeedBack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(dgvFeedBack);
            panel1.Location = new Point(23, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 361);
            panel1.TabIndex = 1;
            // 
            // dgvFeedBack
            // 
            dgvFeedBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFeedBack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedBack.Location = new Point(17, 19);
            dgvFeedBack.Name = "dgvFeedBack";
            dgvFeedBack.ReadOnly = true;
            dgvFeedBack.Size = new Size(535, 324);
            dgvFeedBack.TabIndex = 0;
            // 
            // AdminFeed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PAWSITIVE_TRAINING_DESIGN;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(612, 415);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminFeed";
            Text = "AdminFeed";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFeedBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvFeedBack;
    }
}