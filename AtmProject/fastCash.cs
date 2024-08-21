using AtmProject.Banco;
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
    public partial class fastCash : Form
    {
        private decimal _saldo;

        public fastCash()
        {
            InitializeComponent();
            balance balance = new balance();
            _saldo = balance.GetSaldo(login.numConta);
        }

        public void AddTransacao(string type, decimal amount)
        {
            string sqlQuery = "INSERT INTO Transactions (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                cmd.Parameters.AddWithValue("@AccNum", login.numConta);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
                ContextDatabase.Instance.ExecuteNonQuery(cmd);
            }
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fastCash_Load(object sender, EventArgs e)
        {
            lb_saldo.Text = this._saldo.ToString("C2");
            lb_numConta.Text = "Nº da conta:" + login.numConta;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        public string Sacar(decimal valor)
        {
            try
            {
                if (Convert.ToDecimal(valor) > _saldo)
                {
                    return "Saldo insuficiente.";
                }
                string query = "update Account set Balance = @Valor where Account.AccNum = @NumConta";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@Valor ", _saldo - Convert.ToDecimal(valor));
                    cmd.Parameters.AddWithValue("@numConta", login.numConta);
                    ContextDatabase.Instance.ExecuteNonQuery(cmd);
                    this.AddTransacao("Caixa Rápido", valor);
                    return $"O valor R${valor} foi sacado da conta {login.numConta}";
                }

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
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(200m);
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_400_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(400m);
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(500m);
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(1000m);
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_800_Click(object sender, EventArgs e)
        {
            string resposta = this.Sacar(800m);
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

    }
}
