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
    public partial class withdrawal : Form
    {
        private string _saldo;
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public withdrawal()
        {
            InitializeComponent();
        }

        public void addTransacao(string type)
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
                        cmd.Parameters.AddWithValue("@Amount", tb_valor.Text);
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

        private void lbl_back_Click(object sender, EventArgs e)
        {
            home home = new home();
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
            else if (Convert.ToInt32(tb_valor.Text) > Convert.ToInt32(_saldo))
            {
                MessageBox.Show("Insira um valor menor ou igual ao seu saldo.");
                return;
            }
            else
            {
                try
                {
                    string query = "update Account set Balance = @Valor where Account.AccNum = @NumConta";
                    using (conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Valor ", Convert.ToInt32(_saldo) - Convert.ToInt32(tb_valor.Text));
                        cmd.Parameters.AddWithValue("@numConta", login.numConta);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        addTransacao("Saque");
                        MessageBox.Show($"O valor R${tb_valor.Text} foi sacado da conta {login.numConta}");
                        home home = new home();
                        home.Show();
                        this.Hide();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void withdrawal_Load(object sender, EventArgs e)
        {
            lb_numConta.Text = "Nº da conta:" + login.numConta;
            balance balance = new balance();
            _saldo = balance.getSaldo(login.numConta);
            lbl_valor_real.Text = "R$ " + balance.getSaldo(login.numConta);
        }
    }
}
