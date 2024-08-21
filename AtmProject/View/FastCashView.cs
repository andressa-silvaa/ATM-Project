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
    public partial class FastCashView : Form
    {
        private decimal _saldo;

        public FastCashView()
        {
            InitializeComponent();
            AccountRepository accountRepository = new AccountRepository();
            _saldo = accountRepository.GetBalance(LoginView.numConta);
        }



        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fastCash_Load(object sender, EventArgs e)
        {
            lb_saldo.Text = this._saldo.ToString("C2");
            lb_numConta.Text = "Nº da conta:" + LoginView.numConta;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        public string Sacar(decimal value)
        {
            try
            {
                AccountRepository accountRepository = new AccountRepository();
                if (value > accountRepository.GetBalance(LoginView.numConta))
                {
                    return "Saldo insuficiente.";
                }

                accountRepository.Withdrawal(LoginView.numConta, value, "Caixa Rápido");
                return $"O valor R${value} foi sacado da conta {LoginView.numConta}";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(100m);
            MessageBox.Show(resposta);
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(200m);
            MessageBox.Show(resposta);
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btn_400_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(400m);
            MessageBox.Show(resposta);
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(500m);
            MessageBox.Show(resposta);
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(1000m);
            MessageBox.Show(resposta);
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btn_800_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(800m);
            MessageBox.Show(resposta);
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

    }
}
