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
    public partial class ChangePinView : Form
    {
        public ChangePinView()
        {
            InitializeComponent();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            try
            {
                var newPin = Convert.ToInt32("0" + tb_pin.Text);
                var confirmPin = Convert.ToInt32("0" + tb_confirma_pin.Text);
                AccountService.Instance.UpdatePin(LoginView.numConta, newPin, confirmPin);
                MessageBox.Show("O pin foi atualizado com sucesso!");
                HomeView home = new HomeView();
                home.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changePin_Load(object sender, EventArgs e)
        {
            lbl_valor.Text = "Nº da conta:" + LoginView.numConta;
        }
    }
}
