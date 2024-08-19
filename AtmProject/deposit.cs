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

    public partial class deposit : Form
    {
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public deposit()
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
        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            if (!Util.ValidateInteger(tb_valor.Text))
            {
                MessageBox.Show("Necessário informar um valor válido!");
                return;
            }
            if (tb_valor.Text == "" || Convert.ToInt32(tb_valor.Text) <= 0)
            {
                MessageBox.Show("Necessário informar um valor válido!");
                return;
            }
            else
            {
                try

                {
                    balance balance = new balance();
                    string query = "update Account set Balance = @Valor where Account.AccNum = @NumConta";
                    using (conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Valor ", Convert.ToInt32(balance.getSaldo(login.numConta)) + Convert.ToInt32(tb_valor.Text));
                        cmd.Parameters.AddWithValue("@numConta", login.numConta);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        addTransacao("Depósito");
                        MessageBox.Show($"O valor R${tb_valor.Text} foi depositado na conta {login.numConta}");
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

        private void deposit_Load(object sender, EventArgs e)
        {
            lb_numConta.Text = "Nº da conta:" + login.numConta;
        }
    }
}
