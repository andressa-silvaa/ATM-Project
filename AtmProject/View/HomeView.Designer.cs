namespace AtmProject
{
    partial class HomeView
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
            pn_top = new Panel();
            lbl_valor = new Label();
            lbl_sair = new Label();
            lbl_menu = new Label();
            label5 = new Label();
            lbl_title = new Label();
            btn_deposito = new Button();
            btn_pin = new Button();
            btn_saque = new Button();
            btn_extrato = new Button();
            btn_saldo = new Button();
            btn_caixa = new Button();
            pn_bottom = new Panel();
            lbl_log_out = new Label();
            pic_deposito = new PictureBox();
            pic_caixa = new PictureBox();
            pic_pin = new PictureBox();
            pic_saque = new PictureBox();
            pic_extrato = new PictureBox();
            pic_saldo = new PictureBox();
            panel1.SuspendLayout();
            pn_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_deposito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_caixa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_pin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_saque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_extrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_saldo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pn_top);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbl_title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 100);
            panel1.TabIndex = 0;
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.DarkSlateGray;
            pn_top.Controls.Add(lbl_sair);
            pn_top.Controls.Add(lbl_menu);
            pn_top.Dock = DockStyle.Bottom;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 100);
            pn_top.TabIndex = 12;
            // 
            // lbl_valor
            // 
            lbl_valor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_valor.ForeColor = Color.DarkSlateGray;
            lbl_valor.Location = new Point(0, 406);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(113, 18);
            lbl_valor.TabIndex = 13;
            lbl_valor.Text = "Nº da conta:";
            lbl_valor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(671, 6);
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(42, 42);
            lbl_sair.TabIndex = 11;
            lbl_sair.Text = "X";
            lbl_sair.TextAlign = ContentAlignment.MiddleCenter;
            lbl_sair.Click += lbl_sair_Click;
            // 
            // lbl_menu
            // 
            lbl_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_menu.AutoSize = true;
            lbl_menu.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_menu.ForeColor = Color.White;
            lbl_menu.Location = new Point(83, 9);
            lbl_menu.Name = "lbl_menu";
            lbl_menu.Size = new Size(565, 45);
            lbl_menu.TabIndex = 2;
            lbl_menu.Text = "SELECIONE A TRANSAÇÃO";
            lbl_menu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(755, 6);
            label5.Name = "label5";
            label5.Size = new Size(42, 42);
            label5.TabIndex = 11;
            label5.Text = "X";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_title
            // 
            lbl_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.White;
            lbl_title.Location = new Point(125, 23);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(565, 45);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "SELECIONE A TRANSAÇÃO";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_deposito
            // 
            btn_deposito.BackColor = Color.DarkSlateGray;
            btn_deposito.Cursor = Cursors.Hand;
            btn_deposito.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_deposito.ForeColor = Color.White;
            btn_deposito.Location = new Point(90, 132);
            btn_deposito.Name = "btn_deposito";
            btn_deposito.Size = new Size(177, 51);
            btn_deposito.TabIndex = 9;
            btn_deposito.Text = "DEPÓSITO";
            btn_deposito.UseVisualStyleBackColor = false;
            btn_deposito.UseWaitCursor = true;
            btn_deposito.Click += btn_deposito_Click;
            // 
            // btn_pin
            // 
            btn_pin.BackColor = Color.DarkSlateGray;
            btn_pin.Cursor = Cursors.Hand;
            btn_pin.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pin.ForeColor = Color.White;
            btn_pin.Location = new Point(90, 290);
            btn_pin.Name = "btn_pin";
            btn_pin.Size = new Size(177, 51);
            btn_pin.TabIndex = 11;
            btn_pin.Text = "PIN";
            btn_pin.UseVisualStyleBackColor = false;
            btn_pin.UseWaitCursor = true;
            btn_pin.Click += btn_pin_Click;
            // 
            // btn_saque
            // 
            btn_saque.BackColor = Color.DarkSlateGray;
            btn_saque.Cursor = Cursors.Hand;
            btn_saque.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_saque.ForeColor = Color.White;
            btn_saque.Location = new Point(448, 132);
            btn_saque.Name = "btn_saque";
            btn_saque.Size = new Size(177, 51);
            btn_saque.TabIndex = 12;
            btn_saque.Text = "SAQUE";
            btn_saque.UseVisualStyleBackColor = false;
            btn_saque.UseWaitCursor = true;
            btn_saque.Click += btn_saque_Click;
            // 
            // btn_extrato
            // 
            btn_extrato.BackColor = Color.DarkSlateGray;
            btn_extrato.Cursor = Cursors.Hand;
            btn_extrato.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_extrato.ForeColor = Color.White;
            btn_extrato.Location = new Point(448, 214);
            btn_extrato.Name = "btn_extrato";
            btn_extrato.Size = new Size(177, 51);
            btn_extrato.TabIndex = 13;
            btn_extrato.Text = "EXTRATO";
            btn_extrato.UseVisualStyleBackColor = false;
            btn_extrato.UseWaitCursor = true;
            btn_extrato.Click += btn_extrato_Click;
            // 
            // btn_saldo
            // 
            btn_saldo.BackColor = Color.DarkSlateGray;
            btn_saldo.Cursor = Cursors.Hand;
            btn_saldo.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_saldo.ForeColor = Color.White;
            btn_saldo.Location = new Point(448, 290);
            btn_saldo.Name = "btn_saldo";
            btn_saldo.Size = new Size(177, 51);
            btn_saldo.TabIndex = 14;
            btn_saldo.Text = "SALDO";
            btn_saldo.UseVisualStyleBackColor = false;
            btn_saldo.UseWaitCursor = true;
            btn_saldo.Click += btn_saldo_Click;
            // 
            // btn_caixa
            // 
            btn_caixa.BackColor = Color.DarkSlateGray;
            btn_caixa.Cursor = Cursors.Hand;
            btn_caixa.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_caixa.ForeColor = Color.White;
            btn_caixa.Location = new Point(90, 214);
            btn_caixa.Name = "btn_caixa";
            btn_caixa.Size = new Size(177, 51);
            btn_caixa.TabIndex = 15;
            btn_caixa.Text = "CAIXA";
            btn_caixa.UseVisualStyleBackColor = false;
            btn_caixa.UseWaitCursor = true;
            btn_caixa.Click += btn_caixa_Click;
            // 
            // pn_bottom
            // 
            pn_bottom.BackColor = Color.DarkSlateGray;
            pn_bottom.BackgroundImageLayout = ImageLayout.None;
            pn_bottom.BorderStyle = BorderStyle.FixedSingle;
            pn_bottom.Dock = DockStyle.Bottom;
            pn_bottom.Location = new Point(0, 426);
            pn_bottom.Name = "pn_bottom";
            pn_bottom.Size = new Size(720, 17);
            pn_bottom.TabIndex = 16;
            // 
            // lbl_log_out
            // 
            lbl_log_out.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_log_out.AutoSize = true;
            lbl_log_out.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_log_out.ForeColor = Color.DarkSlateGray;
            lbl_log_out.Location = new Point(310, 386);
            lbl_log_out.Name = "lbl_log_out";
            lbl_log_out.Size = new Size(99, 23);
            lbl_log_out.TabIndex = 12;
            lbl_log_out.Text = "LOG OUT";
            lbl_log_out.TextAlign = ContentAlignment.MiddleCenter;
            lbl_log_out.Click += lbl_log_out_Click;
            // 
            // pic_deposito
            // 
            pic_deposito.Image = Properties.Resources.deposito__1_;
            pic_deposito.Location = new Point(29, 132);
            pic_deposito.Name = "pic_deposito";
            pic_deposito.Size = new Size(55, 51);
            pic_deposito.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_deposito.TabIndex = 17;
            pic_deposito.TabStop = false;
            // 
            // pic_caixa
            // 
            pic_caixa.Image = Properties.Resources.fluxo_de_caixa__1_;
            pic_caixa.Location = new Point(29, 214);
            pic_caixa.Name = "pic_caixa";
            pic_caixa.Size = new Size(55, 47);
            pic_caixa.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_caixa.TabIndex = 18;
            pic_caixa.TabStop = false;
            // 
            // pic_pin
            // 
            pic_pin.Image = Properties.Resources.senha__1_;
            pic_pin.Location = new Point(29, 290);
            pic_pin.Name = "pic_pin";
            pic_pin.Size = new Size(55, 51);
            pic_pin.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_pin.TabIndex = 19;
            pic_pin.TabStop = false;
            // 
            // pic_saque
            // 
            pic_saque.Image = Properties.Resources.dinheiro;
            pic_saque.Location = new Point(631, 132);
            pic_saque.Name = "pic_saque";
            pic_saque.Size = new Size(60, 51);
            pic_saque.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_saque.TabIndex = 20;
            pic_saque.TabStop = false;
            // 
            // pic_extrato
            // 
            pic_extrato.Image = Properties.Resources.extrato_bancario__1_;
            pic_extrato.Location = new Point(631, 214);
            pic_extrato.Name = "pic_extrato";
            pic_extrato.Size = new Size(60, 47);
            pic_extrato.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_extrato.TabIndex = 21;
            pic_extrato.TabStop = false;
            // 
            // pic_saldo
            // 
            pic_saldo.Image = Properties.Resources.dolar__1_;
            pic_saldo.Location = new Point(631, 290);
            pic_saldo.Name = "pic_saldo";
            pic_saldo.Size = new Size(60, 51);
            pic_saldo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_saldo.TabIndex = 22;
            pic_saldo.TabStop = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(lbl_valor);
            Controls.Add(pic_saldo);
            Controls.Add(pic_extrato);
            Controls.Add(pic_saque);
            Controls.Add(pic_pin);
            Controls.Add(pic_caixa);
            Controls.Add(pic_deposito);
            Controls.Add(lbl_log_out);
            Controls.Add(pn_bottom);
            Controls.Add(btn_caixa);
            Controls.Add(btn_saldo);
            Controls.Add(btn_extrato);
            Controls.Add(btn_saque);
            Controls.Add(btn_pin);
            Controls.Add(btn_deposito);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "home";
            Load += home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_deposito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_caixa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_pin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_saque).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_extrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_saldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_title;
        private Label label5;
        private Button btn_deposito;
        private Button btn_pin;
        private Button btn_saque;
        private Button btn_extrato;
        private Button btn_saldo;
        private Button btn_caixa;
        private Panel pn_top;
        private Label lbl_sair;
        private Label lbl_menu;
        private Panel pn_bottom;
        private Label lbl_log_out;
        private PictureBox pic_deposito;
        private PictureBox pic_caixa;
        private PictureBox pic_pin;
        private PictureBox pic_saque;
        private PictureBox pic_extrato;
        private PictureBox pic_saldo;
        private Label lbl_valor;
    }
}