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
        private string _saldo;
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public fastCash()
        {
            InitializeComponent();
            balance balance = new balance();
            _saldo = balance.getSaldo(login.numConta);
        }
        private void popular()
        {

        }
        public void addTransacao(string type, string amount)
        {
            using (conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "INSERT INTO Transactions (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@AccNum", login.numConta);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fastCash_Load(object sender, EventArgs e)
        {
            lb_saldo.Text = "R$ " + _saldo;
            lb_numConta.Text = "Nº da conta:" + login.numConta;
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        public string sacar(string valor)
        {
            try
            {
                if (Convert.ToInt32(valor) > Convert.ToInt32(_saldo))
                {
                    return "Saldo insuficiente.";
                }
                string query = "update Account set Balance = @Valor where Account.AccNum = @NumConta";
                using (conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Valor ", Convert.ToInt32(_saldo) - Convert.ToInt32(valor));
                    cmd.Parameters.AddWithValue("@numConta", login.numConta);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    addTransacao("Caixa Rápido" , valor);
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
            string resposta = this.sacar("100");
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            string resposta = this.sacar("200");
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_400_Click(object sender, EventArgs e)
        {
            string resposta = this.sacar("400");
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            string resposta = this.sacar("500");
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            string resposta = this.sacar("1000");
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_800_Click(object sender, EventArgs e)
        {
            string resposta = this.sacar("800");
            MessageBox.Show(resposta);
            home home = new home();
            home.Show();
            this.Hide();
        }

    }
}
