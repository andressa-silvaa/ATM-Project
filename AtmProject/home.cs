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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            deposit deposito = new deposit();
            deposito.Show();
            this.Hide();
        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            fastCash fastCash = new fastCash();
            fastCash.Show();
            this.Hide();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            changePin pin = new changePin();
            pin.Show();
            this.Hide();
        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            withdrawal withdrawal = new withdrawal();
            withdrawal.Show();
            this.Hide();
        }

        private void btn_extrato_Click(object sender, EventArgs e)
        {
            miniStatement miniStatement = new miniStatement();
            miniStatement.Show();
            this.Hide();
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            balance balance = new balance();
            balance.Show();
            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {
            lbl_valor.Text = "Nº da conta:" + login.numConta;
        }
    }
}
