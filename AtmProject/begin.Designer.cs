namespace AtmProject
{
    partial class begin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_title = new Label();
            pic_logo = new PictureBox();
            pb_begin = new ProgressBar();
            lbl_percent = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.White;
            lbl_title.Location = new Point(169, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(372, 59);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "ATM SYSTEM";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic_logo
            // 
            pic_logo.Image = Properties.Resources.banco_central;
            pic_logo.Location = new Point(208, 118);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(285, 205);
            pic_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_logo.TabIndex = 2;
            pic_logo.TabStop = false;
            // 
            // pb_begin
            // 
            pb_begin.Location = new Point(1, 426);
            pb_begin.Name = "pb_begin";
            pb_begin.Size = new Size(694, 23);
            pb_begin.TabIndex = 3;
            // 
            // lbl_percent
            // 
            lbl_percent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_percent.AutoSize = true;
            lbl_percent.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_percent.ForeColor = Color.White;
            lbl_percent.Location = new Point(283, 354);
            lbl_percent.Name = "lbl_percent";
            lbl_percent.Size = new Size(86, 59);
            lbl_percent.TabIndex = 4;
            lbl_percent.Text = "%";
            lbl_percent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // begin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(695, 450);
            Controls.Add(lbl_percent);
            Controls.Add(pb_begin);
            Controls.Add(pic_logo);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "begin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += begin_Load;
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private PictureBox pic_logo;
        private ProgressBar pb_begin;
        private Label lbl_percent;
        private System.Windows.Forms.Timer timer1;
    }
}
