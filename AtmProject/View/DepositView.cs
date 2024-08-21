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

    public partial class DepositView : Form
    {
        public DepositView()
        {
            InitializeComponent();
        }

        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            try
            {
                var depositValue = Convert.ToDecimal("0" + tb_valor.Text);
                AccountService.Instance.Deposit(LoginView.numConta, depositValue, "Depósito");

                MessageBox.Show($"O valor {depositValue:C2} foi depositado na conta {LoginView.numConta}");
                HomeView home = new HomeView();
                home.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deposit_Load(object sender, EventArgs e)
        {
            lb_numConta.Text = "Nº da conta:" + LoginView.numConta;
        }
    }
}
