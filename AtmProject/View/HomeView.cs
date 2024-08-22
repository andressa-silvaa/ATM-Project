using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmProject
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            LoginView log = new LoginView();
            log.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            DepositView deposito = new DepositView();
            deposito.Show();
            this.Hide();
        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            FastCashView fastCash = new FastCashView();
            fastCash.Show();
            this.Hide();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            ChangePinView pin = new ChangePinView();
            pin.Show();
            this.Hide();
        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            WithdrawalView withdrawal = new WithdrawalView();
            withdrawal.Show();
            this.Hide();
        }

        private void btn_extrato_Click(object sender, EventArgs e)
        {
            MiniStatementView miniStatement = new MiniStatementView();
            miniStatement.Show();
            this.Hide();
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            BalanceView balance = new BalanceView();
            balance.Show();
            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {
            lbl_valor.Text = "Nº da conta:" + LoginView.numConta;
        }
    }
}
