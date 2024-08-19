namespace AtmProject
{
    partial class changePin
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
            lbl_atualiza_pin = new Label();
            pn_bottom = new Panel();
            lbl_confirma_pin = new Label();
            lbl_novo_pin = new Label();
            btn_confirma = new Button();
            lbl_log_out = new Label();
            lbl_valor = new Label();
            tb_pin = new MaskedTextBox();
            tb_confirma_pin = new MaskedTextBox();
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
            pn_top.Controls.Add(lbl_atualiza_pin);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 90);
            pn_top.TabIndex = 15;
            // 
            // lbl_atualiza_pin
            // 
            lbl_atualiza_pin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_atualiza_pin.AutoSize = true;
            lbl_atualiza_pin.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_atualiza_pin.ForeColor = Color.White;
            lbl_atualiza_pin.Location = new Point(186, 9);
            lbl_atualiza_pin.Name = "lbl_atualiza_pin";
            lbl_atualiza_pin.Size = new Size(352, 45);
            lbl_atualiza_pin.TabIndex = 2;
            lbl_atualiza_pin.Text = "ATUALIZAR PIN";
            lbl_atualiza_pin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.DarkSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 435);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(720, 8);
            pn_bottom.TabIndex = 36;
            // 
            // lbl_confirma_pin
            // 
            lbl_confirma_pin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_confirma_pin.AutoSize = true;
            lbl_confirma_pin.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_confirma_pin.ForeColor = Color.DarkSlateGray;
            lbl_confirma_pin.Location = new Point(80, 259);
            lbl_confirma_pin.Name = "lbl_confirma_pin";
            lbl_confirma_pin.Size = new Size(260, 32);
            lbl_confirma_pin.TabIndex = 39;
            lbl_confirma_pin.Text = "CONFIRME O PIN:";
            lbl_confirma_pin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_novo_pin
            // 
            lbl_novo_pin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_novo_pin.AutoSize = true;
            lbl_novo_pin.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_novo_pin.ForeColor = Color.DarkSlateGray;
            lbl_novo_pin.Location = new Point(80, 161);
            lbl_novo_pin.Name = "lbl_novo_pin";
            lbl_novo_pin.Size = new Size(163, 32);
            lbl_novo_pin.TabIndex = 38;
            lbl_novo_pin.Text = "NOVO PIN:";
            lbl_novo_pin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_confirma
            // 
            btn_confirma.BackColor = Color.DarkSlateGray;
            btn_confirma.Cursor = Cursors.Hand;
            btn_confirma.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_confirma.ForeColor = Color.White;
            btn_confirma.Location = new Point(455, 328);
            btn_confirma.Name = "btn_confirma";
            btn_confirma.Size = new Size(171, 46);
            btn_confirma.TabIndex = 42;
            btn_confirma.Text = "CONFIRMAR";
            btn_confirma.UseVisualStyleBackColor = false;
            btn_confirma.UseWaitCursor = true;
            btn_confirma.Click += btn_confirma_Click;
            // 
            // lbl_log_out
            // 
            lbl_log_out.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_log_out.AutoSize = true;
            lbl_log_out.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_log_out.ForeColor = Color.DarkSlateGray;
            lbl_log_out.Location = new Point(506, 389);
            lbl_log_out.Name = "lbl_log_out";
            lbl_log_out.Size = new Size(62, 23);
            lbl_log_out.TabIndex = 43;
            lbl_log_out.Text = "BACK";
            lbl_log_out.TextAlign = ContentAlignment.MiddleCenter;
            lbl_log_out.Click += lbl_log_out_Click;
            // 
            // lbl_valor
            // 
            lbl_valor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor.ForeColor = Color.DarkSlateGray;
            lbl_valor.Location = new Point(0, 416);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(113, 18);
            lbl_valor.TabIndex = 44;
            lbl_valor.Text = "Nº da conta:";
            lbl_valor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_pin
            // 
            tb_pin.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_pin.Location = new Point(420, 161);
            tb_pin.Mask = "00000";
            tb_pin.Name = "tb_pin";
            tb_pin.PromptChar = ' ';
            tb_pin.Size = new Size(231, 32);
            tb_pin.TabIndex = 45;
            // 
            // tb_confirma_pin
            // 
            tb_confirma_pin.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_confirma_pin.Location = new Point(420, 259);
            tb_confirma_pin.Mask = "00000";
            tb_confirma_pin.Name = "tb_confirma_pin";
            tb_confirma_pin.PromptChar = ' ';
            tb_confirma_pin.Size = new Size(231, 32);
            tb_confirma_pin.TabIndex = 46;
            // 
            // changePin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(tb_confirma_pin);
            Controls.Add(tb_pin);
            Controls.Add(lbl_valor);
            Controls.Add(lbl_log_out);
            Controls.Add(btn_confirma);
            Controls.Add(lbl_confirma_pin);
            Controls.Add(lbl_novo_pin);
            Controls.Add(pn_bottom);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "changePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "changePin";
            Load += changePin_Load;
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_sair;
        private Panel pn_top;
        private Label lbl_atualiza_pin;
        private Panel pn_bottom;
        private Label lbl_confirma_pin;
        private Label lbl_novo_pin;
        private Button btn_confirma;
        private Label lbl_log_out;
        private Label lbl_valor;
        private MaskedTextBox tb_pin;
        private MaskedTextBox tb_confirma_pin;
    }
}