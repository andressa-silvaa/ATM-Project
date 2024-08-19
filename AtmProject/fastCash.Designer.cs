namespace AtmProject
{
    partial class fastCash
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
            lbl_caixa = new Label();
            pn_bottom = new Panel();
            btn_100 = new Button();
            btn_200 = new Button();
            btn_400 = new Button();
            btn_800 = new Button();
            btn_1000 = new Button();
            btn_500 = new Button();
            lbl_back = new Label();
            lb_numConta = new Label();
            lb_saldo = new Label();
            pn_top.SuspendLayout();
            SuspendLayout();
            // 
            // pn_top
            // 
            pn_top.BackColor = Color.DarkSlateGray;
            pn_top.Controls.Add(lbl_sair);
            pn_top.Controls.Add(lbl_caixa);
            pn_top.Dock = DockStyle.Top;
            pn_top.Location = new Point(0, 0);
            pn_top.Name = "pn_top";
            pn_top.Size = new Size(720, 90);
            pn_top.TabIndex = 17;
            // 
            // lbl_sair
            // 
            lbl_sair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_sair.AutoSize = true;
            lbl_sair.Font = new Font("Verdana", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sair.ForeColor = Color.White;
            lbl_sair.Location = new Point(673, 2);
            lbl_sair.Name = "lbl_sair";
            lbl_sair.Size = new Size(42, 42);
            lbl_sair.TabIndex = 12;
            lbl_sair.Text = "X";
            lbl_sair.TextAlign = ContentAlignment.MiddleCenter;
            lbl_sair.Click += lbl_sair_Click;
            // 
            // lbl_caixa
            // 
            lbl_caixa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_caixa.AutoSize = true;
            lbl_caixa.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_caixa.ForeColor = Color.White;
            lbl_caixa.Location = new Point(192, 9);
            lbl_caixa.Name = "lbl_caixa";
            lbl_caixa.Size = new Size(333, 45);
            lbl_caixa.TabIndex = 2;
            lbl_caixa.Text = "CAIXA RÁPIDO";
            lbl_caixa.TextAlign = ContentAlignment.MiddleCenter;
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
            // btn_100
            // 
            btn_100.BackColor = Color.DarkSlateGray;
            btn_100.Cursor = Cursors.Hand;
            btn_100.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_100.ForeColor = Color.White;
            btn_100.Location = new Point(57, 127);
            btn_100.Name = "btn_100";
            btn_100.Size = new Size(177, 51);
            btn_100.TabIndex = 39;
            btn_100.Text = "R$100,00";
            btn_100.UseVisualStyleBackColor = false;
            btn_100.UseWaitCursor = true;
            btn_100.Click += btn_100_Click;
            // 
            // btn_200
            // 
            btn_200.BackColor = Color.DarkSlateGray;
            btn_200.Cursor = Cursors.Hand;
            btn_200.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_200.ForeColor = Color.White;
            btn_200.Location = new Point(57, 211);
            btn_200.Name = "btn_200";
            btn_200.Size = new Size(177, 51);
            btn_200.TabIndex = 40;
            btn_200.Text = "R$200,00";
            btn_200.UseVisualStyleBackColor = false;
            btn_200.UseWaitCursor = true;
            btn_200.Click += btn_200_Click;
            // 
            // btn_400
            // 
            btn_400.BackColor = Color.DarkSlateGray;
            btn_400.Cursor = Cursors.Hand;
            btn_400.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_400.ForeColor = Color.White;
            btn_400.Location = new Point(57, 292);
            btn_400.Name = "btn_400";
            btn_400.Size = new Size(177, 51);
            btn_400.TabIndex = 41;
            btn_400.Text = "R$400,00";
            btn_400.UseVisualStyleBackColor = false;
            btn_400.UseWaitCursor = true;
            btn_400.Click += btn_400_Click;
            // 
            // btn_800
            // 
            btn_800.BackColor = Color.DarkSlateGray;
            btn_800.Cursor = Cursors.Hand;
            btn_800.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_800.ForeColor = Color.White;
            btn_800.Location = new Point(476, 292);
            btn_800.Name = "btn_800";
            btn_800.Size = new Size(177, 51);
            btn_800.TabIndex = 44;
            btn_800.Text = "R$800,00";
            btn_800.UseVisualStyleBackColor = false;
            btn_800.UseWaitCursor = true;
            btn_800.Click += btn_800_Click;
            // 
            // btn_1000
            // 
            btn_1000.BackColor = Color.DarkSlateGray;
            btn_1000.Cursor = Cursors.Hand;
            btn_1000.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_1000.ForeColor = Color.White;
            btn_1000.Location = new Point(476, 211);
            btn_1000.Name = "btn_1000";
            btn_1000.Size = new Size(177, 51);
            btn_1000.TabIndex = 43;
            btn_1000.Text = "R$1.000,00";
            btn_1000.UseVisualStyleBackColor = false;
            btn_1000.UseWaitCursor = true;
            btn_1000.Click += btn_1000_Click;
            // 
            // btn_500
            // 
            btn_500.BackColor = Color.DarkSlateGray;
            btn_500.Cursor = Cursors.Hand;
            btn_500.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_500.ForeColor = Color.White;
            btn_500.Location = new Point(476, 127);
            btn_500.Name = "btn_500";
            btn_500.Size = new Size(177, 51);
            btn_500.TabIndex = 42;
            btn_500.Text = "R$500,00";
            btn_500.UseVisualStyleBackColor = false;
            btn_500.UseWaitCursor = true;
            btn_500.Click += btn_500_Click;
            // 
            // lbl_back
            // 
            lbl_back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_back.AutoSize = true;
            lbl_back.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_back.ForeColor = Color.DarkSlateGray;
            lbl_back.Location = new Point(315, 394);
            lbl_back.Name = "lbl_back";
            lbl_back.Size = new Size(70, 25);
            lbl_back.TabIndex = 45;
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
            lb_numConta.TabIndex = 46;
            lb_numConta.Text = "Nº da conta:";
            lb_numConta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_saldo
            // 
            lb_saldo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_saldo.AutoSize = true;
            lb_saldo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_saldo.ForeColor = Color.DarkSlateGray;
            lb_saldo.Location = new Point(0, 93);
            lb_saldo.Name = "lb_saldo";
            lb_saldo.Size = new Size(60, 18);
            lb_saldo.TabIndex = 47;
            lb_saldo.Text = "Saldo:";
            lb_saldo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fastCash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 443);
            Controls.Add(lb_saldo);
            Controls.Add(lb_numConta);
            Controls.Add(lbl_back);
            Controls.Add(btn_800);
            Controls.Add(btn_1000);
            Controls.Add(btn_500);
            Controls.Add(btn_400);
            Controls.Add(btn_200);
            Controls.Add(btn_100);
            Controls.Add(pn_bottom);
            Controls.Add(pn_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fastCash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fastCash";
            Load += fastCash_Load;
            pn_top.ResumeLayout(false);
            pn_top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pn_top;
        private Label lbl_caixa;
        private Panel pn_bottom;
        private Label lbl_sair;
        private Button btn_100;
        private Button btn_200;
        private Button btn_400;
        private Button btn_800;
        private Button btn_1000;
        private Button btn_500;
        private Label lbl_back;
        private Label lb_numConta;
        private Label lb_saldo;
    }
}