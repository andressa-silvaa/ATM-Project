namespace AtmProject
{
    partial class WithdrawalView
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
            lbl_saque = new Label();
            pn_bottom = new Panel();
            lbl_back = new Label();
            btn_sacar = new Button();
            lbl_valor = new Label();
            lbl_disponivel = new Label();
            lbl_valor_real = new Label();
            lb_numConta = new Label();
            tb_valor = new MaskedTextBox();
            pn_top.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(677, 9);
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
            pn_top.Controls.Add(lbl_saque);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 90);
            pn_top.TabIndex = 17;
            // 
            // lbl_saque
            // 
            lbl_saque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_saque.AutoSize = true;
            lbl_saque.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_saque.ForeColor = Color.White;
            lbl_saque.Location = new Point(281, 9);
            lbl_saque.Name = "lbl_saque";
            lbl_saque.Size = new Size(161, 45);
            lbl_saque.TabIndex = 2;
            lbl_saque.Text = "SAQUE";
            lbl_saque.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.DarkSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 435);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(720, 8);
            pn_bottom.TabIndex = 38;
            // 
            // lbl_back
            // 
            lbl_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_back.AutoSize = true;
            lbl_back.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_back.ForeColor = Color.DarkSlateGray;
            lbl_back.Location = new Point(499, 388);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(62, 23);
            lbl_back.TabIndex = 49;
            lbl_back.Text = "BACK";
            lbl_back.TextAlign = ContentAlignment.MiddleCenter;
            lbl_back.Click += lbl_back_Click;
            // 
            // btn_sacar
            // 
            btn_sacar.BackColor = Color.DarkSlateGray;
            btn_sacar.Cursor = Cursors.Hand;
            btn_sacar.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sacar.ForeColor = Color.White;
            btn_sacar.Location = new Point(447, 320);
            btn_sacar.Name = "btn_sacar";
            btn_sacar.Size = new Size(171, 46);
            btn_sacar.TabIndex = 48;
            btn_sacar.Text = "SACAR";
            btn_sacar.UseVisualStyleBackColor = false;
            btn_sacar.UseWaitCursor = true;
            btn_sacar.Click += btn_sacar_Click;
            // 
            // lbl_valor
            // 
            lbl_valor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor.ForeColor = Color.DarkSlateGray;
            lbl_valor.Location = new Point(75, 185);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(116, 32);
            lbl_valor.TabIndex = 46;
            lbl_valor.Text = "VALOR:";
            lbl_valor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_disponivel
            // 
            lbl_disponivel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_disponivel.AutoSize = true;
            lbl_disponivel.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_disponivel.ForeColor = Color.DarkSlateGray;
            lbl_disponivel.Location = new Point(418, 103);
            lbl_disponivel.Name = "lbl_disponivel";
            lbl_disponivel.Size = new Size(146, 23);
            lbl_disponivel.TabIndex = 50;
            lbl_disponivel.Text = "DISPONÍVEL: ";
            lbl_disponivel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_valor_real
            // 
            lbl_valor_real.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_valor_real.AutoSize = true;
            lbl_valor_real.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor_real.ForeColor = Color.DarkSlateGray;
            lbl_valor_real.Location = new Point(562, 103);
            lbl_valor_real.Name = "lbl_valor_real";
            lbl_valor_real.Size = new Size(35, 23);
            lbl_valor_real.TabIndex = 51;
            lbl_valor_real.Text = "R$";
            lbl_valor_real.TextAlign = ContentAlignment.MiddleCenter;
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
            lb_numConta.TabIndex = 52;
            lb_numConta.Text = "Nº da conta:";
            lb_numConta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_valor
            // 
 
            tb_valor.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_valor.Location = new Point(418, 185);
            tb_valor.Name = "tb_valor";
            tb_valor.Size = new Size(228, 32);
            tb_valor.TabIndex = 53;

            // 
            // withdrawal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(tb_valor);
            Controls.Add(lb_numConta);
            Controls.Add(lbl_valor_real);
            Controls.Add(lbl_disponivel);
            Controls.Add(lbl_back);
            Controls.Add(btn_sacar);
            Controls.Add(lbl_valor);
            Controls.Add(pn_bottom);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "withdrawal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "withdrawal";
            Load += withdrawal_Load;
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sair;
        private Panel pn_top;
        private Label lbl_saque;
        private Panel pn_bottom;
        private Label lbl_back;
        private Button btn_sacar;
        private Label lbl_valor;
        private Label lbl_disponivel;
        private Label lbl_valor_real;
        private Label lb_numConta;
        private MaskedTextBox tb_valor;
    }
}