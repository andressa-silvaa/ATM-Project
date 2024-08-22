using AtmProject.Banco;
using AtmProject.Repositorio;
using AtmProject.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmProject
{
    public partial class WithdrawalView : Form
    {
        private decimal _saldo;

        public WithdrawalView()
        {
            InitializeComponent();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            try
            {
                var value = Convert.ToDecimal("0" + tb_valor.Text);
                AccountService.Instance.Withdrawal(LoginView.numConta, value, "Saque");
                MessageBox.Show($"O valor {value:C2} foi sacado da conta {LoginView.numConta}");
                HomeView home = new HomeView();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void withdrawal_Load(object sender, EventArgs e)
        {
            lb_numConta.Text = "Nº da conta:" + LoginView.numConta;
            AccountRepository accountRepository = new AccountRepository();
            _saldo = accountRepository.GetBalance(LoginView.numConta);
            lbl_valor_real.Text = _saldo.ToString("C2");
        }
    }
}
