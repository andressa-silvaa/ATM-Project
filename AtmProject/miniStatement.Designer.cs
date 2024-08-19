namespace AtmProject
{
    partial class miniStatement
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
            pn_top = new Panel();
            lbl_sair = new Label();
            lbl_extrato = new Label();
            pn_bottom = new Panel();
            dt_extrato = new DataGridView();
            lbl_back = new Label();
            lb_numConta = new Label();
            pn_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt_extrato).BeginInit();
            SuspendLayout();
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.DarkSlateGray;
            pn_top.Controls.Add(lbl_sair);
            pn_top.Controls.Add(lbl_extrato);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 90);
            pn_top.TabIndex = 18;
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(672, 2);
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(42, 42);
            lbl_sair.TabIndex = 12;
            lbl_sair.Text = "X";
            lbl_sair.TextAlign = ContentAlignment.MiddleCenter;
            lbl_sair.Click += lbl_sair_Click;
            // 
            // lbl_extrato
            // 
            lbl_extrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_extrato.AutoSize = true;
            lbl_extrato.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_extrato.ForeColor = Color.White;
            lbl_extrato.Location = new Point(137, 9);
            lbl_extrato.Name = "lbl_extrato";
            lbl_extrato.Size = new Size(449, 45);
            lbl_extrato.TabIndex = 2;
            lbl_extrato.Text = "EXTRATO BANCÁRIO";
            lbl_extrato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.DarkSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 435);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(720, 8);
            pn_bottom.TabIndex = 39;
            // 
            // dt_extrato
            // 
            dt_extrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dt_extrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt_extrato.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt_extrato.BackgroundColor = SystemColors.ButtonFace;
            dt_extrato.BorderStyle = BorderStyle.None;
            dt_extrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_extrato.Location = new Point(12, 96);
            dt_extrato.Name = "dt_extrato";
            dt_extrato.Size = new Size(696, 267);
            dt_extrato.TabIndex = 40;
            // 
            // lbl_back
            // 
            lbl_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_back.AutoSize = true;
            lbl_back.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_back.ForeColor = Color.DarkSlateGray;
            lbl_back.Location = new Point(318, 397);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(70, 25);
            lbl_back.TabIndex = 46;
            lbl_back.Text = "BACK";
            lbl_back.TextAlign = ContentAlignment.MiddleCenter;
            lbl_back.Click += lbl_back_Click;
            // 
            // lb_numConta
            // 
            lb_numConta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_numConta.AutoSize = true;
            lb_numConta.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_numConta.ForeColor = Color.DarkSlateGray;
            lb_numConta.Location = new Point(0, 416);
            lb_numConta.Name = "lb_numConta";
            lb_numConta.Size = new Size(113, 18);
            lb_numConta.TabIndex = 47;
            lb_numConta.Text = "Nº da conta:";
            lb_numConta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // miniStatement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(lb_numConta);
            Controls.Add(lbl_back);
            Controls.Add(dt_extrato);
            Controls.Add(pn_bottom);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "miniStatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "miniStatement";
            Load += miniStatement_Load;
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt_extrato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_top;
        private Label lbl_sair;
        private Label lbl_extrato;
        private Panel pn_bottom;
        private DataGridView dt_extrato;
        private Label lbl_back;
        private Label lb_numConta;
    }
}