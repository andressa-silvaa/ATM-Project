using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AtmProject.Banco;
using AtmProject.Entidades;
namespace AtmProject
{
    public partial class AccountView : Form
    {
        public AccountView()
        {
            InitializeComponent();

        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account();

                // Adiciona os parâmetros ao comando
                account.AccNum = Convert.ToInt32("0" + tb_num_conta.Text);
                account.Name = tb_nome.Text;
                account.Phone = tb_telefone.Text;
                account.Address = tb_endereco.Text;
                account.Education = cb_educacao.SelectedItem.ToString();
                account.Dob = dt_nascimento.Value;
                account.Pin = Convert.ToInt32("0" + tb_pin.Text);

                Servicos.AccountService.Instance.RegisterAccount(account);

                MessageBox.Show("Sua conta foi criada com sucesso!");
                LoginView log = new LoginView();
                log.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void account_Load(object sender, EventArgs e)
        {
            cb_educacao.SelectedIndex = 0;

        }
    }
}