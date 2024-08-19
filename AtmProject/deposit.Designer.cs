namespace AtmProject
{
    partial class deposit
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
            lbl_deposito = new Label();
            pn_bottom = new Panel();
            tb_valor = new TextBox();
            lbl_valor = new Label();
            lbl_back = new Label();
            btn_deposito = new Button();
            lb_numConta = new Label();
            pn_top.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(677, 4);
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
            pn_top.Controls.Add(lbl_deposito);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 90);
            pn_top.TabIndex = 16;
            // 
            // lbl_deposito
            // 
            lbl_deposito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_deposito.AutoSize = true;
            lbl_deposito.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_deposito.ForeColor = Color.White;
            lbl_deposito.Location = new Point(239, 9);
            lbl_deposito.Name = "lbl_deposito";
            lbl_deposito.Size = new Size(236, 45);
            lbl_deposito.TabIndex = 2;
            lbl_deposito.Text = "DEPÓSITO";
            lbl_deposito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.DarkSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 435);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(720, 8);
            pn_bottom.TabIndex = 37;
            // 
            // tb_valor
            // 
            tb_valor.Font = new Font("Verdana", 14.25F);
            tb_valor.Location = new Point(418, 179);
            tb_valor.Multiline = true;
            tb_valor.Name = "tb_valor";
            tb_valor.Size = new Size(228, 32);
            tb_valor.TabIndex = 42;
            // 
            // lbl_valor
            // 
            lbl_valor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor.ForeColor = Color.DarkSlateGray;
            lbl_valor.Location = new Point(75, 179);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(116, 32);
            lbl_valor.TabIndex = 41;
            lbl_valor.Text = "VALOR:";
            lbl_valor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_back
            // 
            lbl_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_back.AutoSize = true;
            lbl_back.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_back.ForeColor = Color.DarkSlateGray;
            lbl_back.Location = new Point(499, 382);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(62, 23);
            lbl_back.TabIndex = 45;
            lbl_back.Text = "BACK";
            lbl_back.TextAlign = ContentAlignment.MiddleCenter;
            lbl_back.Click += lbl_log_out_Click;
            // 
            // btn_deposito
            // 
            btn_deposito.BackColor = Color.DarkSlateGray;
            btn_deposito.Cursor = Cursors.Hand;
            btn_deposito.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deposito.ForeColor = Color.White;
            btn_deposito.Location = new Point(447, 314);
            btn_deposito.Name = "btn_deposito";
            btn_deposito.Size = new Size(171, 46);
            btn_deposito.TabIndex = 44;
            btn_deposito.Text = "DEPOSITAR";
            btn_deposito.UseVisualStyleBackColor = false;
            btn_deposito.UseWaitCursor = true;
            btn_deposito.Click += btn_deposito_Click;
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
            lb_numConta.TabIndex = 46;
            lb_numConta.Text = "Nº da conta:";
            lb_numConta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(lb_numConta);
            Controls.Add(lbl_back);
            Controls.Add(btn_deposito);
            Controls.Add(tb_valor);
            Controls.Add(lbl_valor);
            Controls.Add(pn_bottom);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "deposit";
            Load += deposit_Load;
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sair;
        private Panel pn_top;
        private Label lbl_deposito;
        private Panel pn_bottom;
        private TextBox tb_valor;
        private Label lbl_valor;
        private Label lbl_back;
        private Button btn_deposito;
        private Label lb_numConta;
    }
}