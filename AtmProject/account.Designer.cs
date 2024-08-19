namespace AtmProject
{
    partial class account
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
            lbl_cadastro = new Label();
            lbl_num_conta = new Label();
            lbl_nome = new Label();
            lbl_telefone = new Label();
            lbl_educacao = new Label();
            lbl_nascimento = new Label();
            lbl_pin = new Label();
            tb_nome = new TextBox();
            dt_nascimento = new DateTimePicker();
            btn_sign_in = new Button();
            panel1 = new Panel();
            lbl_log_out = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            cb_educacao = new ComboBox();
            pn_bottom = new Panel();
            tb_endereco = new TextBox();
            lbl_endereco = new Label();
            tb_telefone = new MaskedTextBox();
            tb_num_conta = new MaskedTextBox();
            tb_pin = new MaskedTextBox();
            pn_top.SuspendLayout();
            SuspendLayout();
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.DarkSlateGray;
            pn_top.Controls.Add(lbl_sair);
            pn_top.Controls.Add(lbl_cadastro);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(1067, 100);
            pn_top.TabIndex = 13;
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(1021, 5);
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(42, 42);
            lbl_sair.TabIndex = 11;
            lbl_sair.Text = "X";
            lbl_sair.TextAlign = ContentAlignment.MiddleCenter;
            lbl_sair.Click += lbl_sair_Click;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastro.ForeColor = Color.White;
            lbl_cadastro.Location = new Point(415, 9);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(247, 45);
            lbl_cadastro.TabIndex = 2;
            lbl_cadastro.Text = "CADASTRO";
            lbl_cadastro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_num_conta
            // 
            lbl_num_conta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_num_conta.AutoSize = true;
            lbl_num_conta.Font = new Font("Verdana", 18F);
            lbl_num_conta.ForeColor = Color.DarkSlateGray;
            lbl_num_conta.Location = new Point(49, 170);
            lbl_num_conta.Name = "lbl_num_conta";
            lbl_num_conta.Size = new Size(190, 29);
            lbl_num_conta.TabIndex = 14;
            lbl_num_conta.Text = "Nº DA CONTA:";
            lbl_num_conta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nome
            // 
            lbl_nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Verdana", 18F);
            lbl_nome.ForeColor = Color.DarkSlateGray;
            lbl_nome.Location = new Point(607, 170);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(96, 29);
            lbl_nome.TabIndex = 15;
            lbl_nome.Text = "NOME:";
            lbl_nome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_telefone
            // 
            lbl_telefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_telefone.AutoSize = true;
            lbl_telefone.Font = new Font("Verdana", 18F);
            lbl_telefone.ForeColor = Color.DarkSlateGray;
            lbl_telefone.Location = new Point(607, 259);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(148, 29);
            lbl_telefone.TabIndex = 18;
            lbl_telefone.Text = "TELEFONE:";
            lbl_telefone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_educacao
            // 
            lbl_educacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_educacao.AutoSize = true;
            lbl_educacao.Font = new Font("Verdana", 18F);
            lbl_educacao.ForeColor = Color.DarkSlateGray;
            lbl_educacao.Location = new Point(607, 447);
            lbl_educacao.Name = "lbl_educacao";
            lbl_educacao.Size = new Size(150, 29);
            lbl_educacao.TabIndex = 20;
            lbl_educacao.Text = "EDUCAÇÃO";
            lbl_educacao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_nascimento
            // 
            lbl_nascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nascimento.AutoSize = true;
            lbl_nascimento.Font = new Font("Verdana", 18F);
            lbl_nascimento.ForeColor = Color.DarkSlateGray;
            lbl_nascimento.Location = new Point(607, 353);
            lbl_nascimento.Name = "lbl_nascimento";
            lbl_nascimento.Size = new Size(187, 29);
            lbl_nascimento.TabIndex = 21;
            lbl_nascimento.Text = "NASCIMENTO:";
            lbl_nascimento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_pin
            // 
            lbl_pin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_pin.AutoSize = true;
            lbl_pin.Font = new Font("Verdana", 18F);
            lbl_pin.ForeColor = Color.DarkSlateGray;
            lbl_pin.Location = new Point(49, 257);
            lbl_pin.Name = "lbl_pin";
            lbl_pin.Size = new Size(66, 29);
            lbl_pin.TabIndex = 22;
            lbl_pin.Text = "PIN:";
            lbl_pin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_nome
            // 
            tb_nome.Font = new Font("Verdana", 14.25F);
            tb_nome.Location = new Point(813, 170);
            tb_nome.Multiline = true;
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(203, 29);
            tb_nome.TabIndex = 28;
            // 
            // dt_nascimento
            // 
            dt_nascimento.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dt_nascimento.Location = new Point(813, 351);
            dt_nascimento.Name = "dt_nascimento";
            dt_nascimento.Size = new Size(200, 31);
            dt_nascimento.TabIndex = 32;
            // 
            // btn_sign_in
            // 
            btn_sign_in.BackColor = Color.DarkSlateGray;
            btn_sign_in.Cursor = Cursors.Hand;
            btn_sign_in.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sign_in.ForeColor = Color.White;
            btn_sign_in.Location = new Point(462, 517);
            btn_sign_in.Name = "btn_sign_in";
            btn_sign_in.Size = new Size(158, 41);
            btn_sign_in.TabIndex = 33;
            btn_sign_in.Text = "SIGN IN";
            btn_sign_in.UseVisualStyleBackColor = false;
            btn_sign_in.UseWaitCursor = true;
            btn_sign_in.Click += btn_sign_in_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 616);
            panel1.Name = "panel1";
            panel1.Size = new Size(1067, 8);
            panel1.TabIndex = 34;
            // 
            // lbl_log_out
            // 
            lbl_log_out.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_log_out.AutoSize = true;
            lbl_log_out.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_log_out.ForeColor = Color.DarkSlateGray;
            lbl_log_out.Location = new Point(489, 572);
            lbl_log_out.Name = "lbl_log_out";
            lbl_log_out.Size = new Size(99, 23);
            lbl_log_out.TabIndex = 35;
            lbl_log_out.Text = "LOG OUT";
            lbl_log_out.TextAlign = ContentAlignment.MiddleCenter;
            lbl_log_out.Click += lbl_log_out_Click;
            // 
            // cb_educacao
            // 
            cb_educacao.Font = new Font("Verdana", 14.25F);
            cb_educacao.FormattingEnabled = true;
            cb_educacao.Items.AddRange(new object[] { "Ensino Médio - Incompleto", "Ensino Médio - Completo", "Ensino Superior - Incompleto", "Ensino Superior - Completo", "Pós-Graduação - Incompleto", "Pós-Graduação - Completo", "Mestrado - Incompleto", "Mestrado - Completo", "Doutorado - Incompleto", "Doutorado - Completo", "Pós-Doutorado" });
            cb_educacao.Location = new Point(810, 445);
            cb_educacao.Name = "cb_educacao";
            cb_educacao.Size = new Size(203, 31);
            cb_educacao.TabIndex = 36;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.DarkSlateGray;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 606);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(1067, 10);
            pn_bottom.TabIndex = 37;
            // 
            // tb_endereco
            // 
            tb_endereco.Font = new Font("Verdana", 14.25F);
            tb_endereco.Location = new Point(251, 355);
            tb_endereco.Multiline = true;
            tb_endereco.Name = "tb_endereco";
            tb_endereco.Size = new Size(203, 121);
            tb_endereco.TabIndex = 27;
            // 
            // lbl_endereco
            // 
            lbl_endereco.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_endereco.AutoSize = true;
            lbl_endereco.Font = new Font("Verdana", 18F);
            lbl_endereco.ForeColor = Color.DarkSlateGray;
            lbl_endereco.Location = new Point(49, 353);
            lbl_endereco.Name = "lbl_endereco";
            lbl_endereco.Size = new Size(159, 29);
            lbl_endereco.TabIndex = 17;
            lbl_endereco.Text = "ENDEREÇO:";
            lbl_endereco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_telefone
            // 
            tb_telefone.Font = new Font("Verdana", 14.25F);
            tb_telefone.Location = new Point(810, 255);
            tb_telefone.Mask = "(99) 00000-0000";
            tb_telefone.Name = "tb_telefone";
            tb_telefone.Size = new Size(206, 31);
            tb_telefone.TabIndex = 38;
            // 
            // tb_num_conta
            // 
            tb_num_conta.Font = new Font("Verdana", 14.25F);
            tb_num_conta.Location = new Point(251, 168);
            tb_num_conta.Mask = "00000";
            tb_num_conta.Name = "tb_num_conta";
            tb_num_conta.PromptChar = ' ';
            tb_num_conta.Size = new Size(206, 31);
            tb_num_conta.TabIndex = 39;
            // 
            // tb_pin
            // 
            tb_pin.Font = new Font("Verdana", 14.25F);
            tb_pin.Location = new Point(248, 257);
            tb_pin.Mask = "00000";
            tb_pin.Name = "tb_pin";
            tb_pin.PromptChar = ' ';
            tb_pin.Size = new Size(206, 31);
            tb_pin.TabIndex = 40;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 624);
            Controls.Add(tb_pin);
            Controls.Add(tb_num_conta);
            Controls.Add(tb_telefone);
            Controls.Add(pn_bottom);
            Controls.Add(cb_educacao);
            Controls.Add(lbl_log_out);
            Controls.Add(panel1);
            Controls.Add(btn_sign_in);
            Controls.Add(dt_nascimento);
            Controls.Add(tb_nome);
            Controls.Add(tb_endereco);
            Controls.Add(lbl_pin);
            Controls.Add(lbl_nascimento);
            Controls.Add(lbl_educacao);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_endereco);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_num_conta);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "account";
            Load += account_Load;
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_top;
        private Label lbl_sair;
        private Label lbl_cadastro;
        private Label lbl_num_conta;
        private Label lbl_nome;
        private Label lbl_telefone;
        private Label lbl_educacao;
        private Label lbl_nascimento;
        private Label lbl_pin;
        private TextBox tb_nome;
        private DateTimePicker dt_nascimento;
        private Button btn_sign_in;
        private Panel panel1;
        private Label lbl_log_out;
        private FolderBrowserDialog folderBrowserDialog1;
        private ComboBox cb_educacao;
        private Panel pn_bottom;
        private TextBox tb_endereco;
        private Label lbl_endereco;
        private MaskedTextBox tb_telefone;
        private MaskedTextBox tb_num_conta;
        private MaskedTextBox tb_pin;
    }
}