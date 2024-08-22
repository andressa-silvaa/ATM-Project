using AtmProject.Banco;
using AtmProject.Repositorio;
using AtmProject.Servicos;
using Microsoft.VisualBasic.Logging;
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
    public partial class LoginView : Form
    {
        public static int numConta;
        public LoginView()
        {
            InitializeComponent();
        }

        private void lbl_sign_up_Click(object sender, EventArgs e)
        {
            AccountView acc = new AccountView();
            acc.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                var accNum = Convert.ToInt32("0" + tb_num_conta.Text);
                var pin = Convert.ToInt32("0" + tb_senha.Text);
                var isValid = AccountService.Instance.Login(accNum, pin);


                if (isValid)
                {
                    numConta = Convert.ToInt32(tb_num_conta.Text);
                    HomeView home = new HomeView();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados incorretos.\nTente novamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

