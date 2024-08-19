namespace AtmProject
{
    partial class login
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
            lbl_login = new Label();
            pic_logo = new PictureBox();
            lbl_num_conta = new Label();
            lbl_senha = new Label();
            btn_login = new Button();
            lbl_sign_up = new Label();
            pn_bottom = new Panel();
            tb_num_conta = new MaskedTextBox();
            tb_senha = new MaskedTextBox();
            pn_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            SuspendLayout();
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.DarkSlateGray;
            pn_top.Controls.Add(lbl_sair);
            pn_top.Controls.Add(lbl_login);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 100);
            pn_top.TabIndex = 0;
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(675, 6);
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(42, 42);
            lbl_sair.TabIndex = 10;
            lbl_sair.Text = "X";
            lbl_sair.TextAlign = ContentAlignment.MiddleCenter;
            lbl_sair.Click += lbl_sair_Click;
            // 
            // lbl_login
            // 
            lbl_login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.ForeColor = Color.White;
            lbl_login.Location = new Point(255, 9);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(203, 59);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "LOGIN";
            lbl_login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pic_logo
            // 
            pic_logo.Image = Properties.Resources.login_do_aplicativo__1_;
            pic_logo.Location = new Point(38, 156);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(169, 147);
            pic_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_logo.TabIndex = 3;
            pic_logo.TabStop = false;
            // 
            // lbl_num_conta
            // 
            lbl_num_conta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_num_conta.AutoSize = true;
            lbl_num_conta.Font = new Font("Verdana", 20.25F);
            lbl_num_conta.ForeColor = Color.DarkSlateGray;
            lbl_num_conta.Location = new Point(246, 167);
            lbl_num_conta.Name = "lbl_num_conta";
            lbl_num_conta.Size = new Size(164, 32);
            lbl_num_conta.TabIndex = 4;
            lbl_num_conta.Text = "Nº CONTA:";
            lbl_num_conta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_senha
            // 
            lbl_senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Verdana", 20.25F);
            lbl_senha.ForeColor = Color.DarkSlateGray;
            lbl_senha.Location = new Point(255, 254);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(73, 32);
            lbl_senha.TabIndex = 5;
            lbl_senha.Text = "PIN:";
            lbl_senha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSlateGray;
            btn_login.Cursor = Cursors.Hand;
            btn_login.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(496, 326);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(160, 46);
            btn_login.TabIndex = 8;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.UseWaitCursor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lbl_sign_up
            // 
            lbl_sign_up.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sign_up.AutoSize = true;
            lbl_sign_up.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sign_up.ForeColor = Color.DarkSlateGray;
            lbl_sign_up.Location = new Point(527, 386);
            lbl_sign_up.Name = "lbl_sign_up";
            lbl_sign_up.Size = new Size(92, 23);
            lbl_sign_up.TabIndex = 9;
            lbl_sign_up.Text = "SIGN UP";
            lbl_sign_up.TextAlign = ContentAlignment.MiddleCenter;
            lbl_sign_up.Click += lbl_sign_up_Click;
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
            // tb_num_conta
            // 
            tb_num_conta.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_num_conta.Location = new Point(447, 167);
            tb_num_conta.Mask = "00000";
            tb_num_conta.Name = "tb_num_conta";
            tb_num_conta.PromptChar = ' ';
            tb_num_conta.Size = new Size(251, 32);
            tb_num_conta.TabIndex = 40;
            tb_num_conta.ValidatingType = typeof(DateTime);
            // 
            // tb_senha
            // 
            tb_senha.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_senha.Location = new Point(447, 254);
            tb_senha.Mask = "00000";
            tb_senha.Name = "tb_senha";
            tb_senha.PromptChar = ' ';
            tb_senha.Size = new Size(251, 32);
            tb_senha.TabIndex = 41;
            tb_senha.ValidatingType = typeof(DateTime);
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(tb_senha);
            Controls.Add(tb_num_conta);
            Controls.Add(pn_bottom);
            Controls.Add(lbl_sign_up);
            Controls.Add(btn_login);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_num_conta);
            Controls.Add(pic_logo);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn_top;
        private Label lbl_login;
        private PictureBox pic_logo;
        private Label lbl_num_conta;
        private Label lbl_senha;
        private Button btn_login;
        private Label lbl_sign_up;
        private Label lbl_sair;
        private Panel pn_bottom;
        private MaskedTextBox tb_num_conta;
        private MaskedTextBox tb_senha;
    }
}