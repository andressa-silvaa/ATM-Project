using AtmProject.Banco;
using AtmProject.Repositorio;
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
            if (tb_valor.Text == "")
            {
                MessageBox.Show("Preencha o valor!");
            }
            else if (!Util.ValidateInteger(tb_valor.Text))
            {
                MessageBox.Show("Necessário informar um valor válido!");
                return;
            }
            else if (Convert.ToInt32(tb_valor.Text) <= 0)
            {
                MessageBox.Show("Entre com um valor válido!");
                return;
            }
            else if (Convert.ToDecimal(tb_valor.Text) > Convert.ToDecimal(_saldo))
            {
                MessageBox.Show("Insira um valor menor ou igual ao seu saldo.");
                return;
            }
            else
            {
                try
                {
                    var value = Convert.ToDecimal(tb_valor.Text);

                    AccountRepository accountRepository = new AccountRepository();
                    accountRepository.Withdrawal(LoginView.numConta, value, "Saque");

                    HomeView home = new HomeView();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
