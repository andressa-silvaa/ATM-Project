namespace AtmProject
{
    partial class balance
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
            lbl_sair = new Label();
            pn_top = new Panel();
            lbl_saldo_title = new Label();
            pn_bottom = new Panel();
            lbl_num_conta = new Label();
            lbl_saldo = new Label();
            lbl_num_conta_real = new Label();
            lbl_saldo_real = new Label();
            lbl_back = new Label();
            pn_top.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(677, 6);
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(42, 42);
            lbl_sair.TabIndex = 11;
            lbl_sair.Text = "X";
            lbl_sair.TextAlign = ContentAlignment.MiddleCenter;
            lbl_sair.Click += lbl_sair_Click;
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.DarkSlateGray;
            pn_top.Controls.Add(lbl_sair);
            pn_top.Controls.Add(lbl_saldo_title);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 90);
            pn_top.TabIndex = 14;
            // 
            // lbl_saldo_title
            // 
            lbl_saldo_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_saldo_title.AutoSize = true;
            lbl_saldo_title.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saldo_title.ForeColor = Color.White;
            lbl_saldo_title.Location = new Point(283, 9);
            lbl_saldo_title.Name = "lbl_saldo_title";
            lbl_saldo_title.Size = new Size(161, 45);
            lbl_saldo_title.TabIndex = 2;
            lbl_saldo_title.Text = "SALDO";
            lbl_saldo_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.DarkSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 435);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(720, 8);
            pn_bottom.TabIndex = 35;
            // 
            // lbl_num_conta
            // 
            lbl_num_conta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_num_conta.AutoSize = true;
            lbl_num_conta.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_num_conta.ForeColor = Color.DarkSlateGray;
            lbl_num_conta.Location = new Point(70, 160);
            lbl_num_conta.Name = "lbl_num_conta";
            lbl_num_conta.Size = new Size(213, 32);
            lbl_num_conta.TabIndex = 36;
            lbl_num_conta.Text = "Nº DA CONTA:";
            lbl_num_conta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_saldo
            // 
            lbl_saldo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_saldo.AutoSize = true;
            lbl_saldo.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_saldo.ForeColor = Color.DarkSlateGray;
            lbl_saldo.Location = new Point(70, 272);
            lbl_saldo.Name = "lbl_saldo";
            lbl_saldo.Size = new Size(184, 32);
            lbl_saldo.TabIndex = 37;
            lbl_saldo.Text = "SEU SALDO:";
            lbl_saldo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_num_conta_real
            // 
            lbl_num_conta_real.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_num_conta_real.AutoSize = true;
            lbl_num_conta_real.Font = new Font("Verdana", 20.25F);
            lbl_num_conta_real.ForeColor = Color.DarkSlateGray;
            lbl_num_conta_real.Location = new Point(429, 160);
            lbl_num_conta_real.Name = "lbl_num_conta_real";
            lbl_num_conta_real.Size = new Size(213, 32);
            lbl_num_conta_real.TabIndex = 40;
            lbl_num_conta_real.Text = "Nº DA CONTA:";
            lbl_num_conta_real.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_saldo_real
            // 
            lbl_saldo_real.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_saldo_real.AutoSize = true;
            lbl_saldo_real.Font = new Font("Verdana", 20.25F);
            lbl_saldo_real.ForeColor = Color.DarkSlateGray;
            lbl_saldo_real.Location = new Point(429, 272);
            lbl_saldo_real.Name = "lbl_saldo_real";
            lbl_saldo_real.Size = new Size(184, 32);
            lbl_saldo_real.TabIndex = 41;
            lbl_saldo_real.Text = "SEU SALDO:";
            lbl_saldo_real.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_back
            // 
            lbl_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_back.AutoSize = true;
            lbl_back.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_back.ForeColor = Color.DarkSlateGray;
            lbl_back.Location = new Point(320, 391);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(70, 25);
            lbl_back.TabIndex = 42;
            lbl_back.Text = "BACK";
            lbl_back.TextAlign = ContentAlignment.MiddleCenter;
            lbl_back.Click += label7_Click;
            // 
            // balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(lbl_back);
            Controls.Add(lbl_saldo_real);
            Controls.Add(lbl_num_conta_real);
            Controls.Add(lbl_saldo);
            Controls.Add(lbl_num_conta);
            Controls.Add(pn_bottom);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "balance";
            Load += balance_Load;
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sair;
        private Panel pn_top;
        private Label lbl_saldo_title;
        private Panel pn_bottom;
        private Label lbl_num_conta;
        private Label lbl_saldo;
        private Label lbl_num_conta_real;
        private Label lbl_saldo_real;
        private Label lbl_back;
    }
}