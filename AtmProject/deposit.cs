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

    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }
        public void AddTransacao(string type)
        {
            string sqlQuery = "INSERT INTO Transactions (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                cmd.Parameters.AddWithValue("@AccNum", login.numConta);
                cmd.Parameters.AddWithValue("@Amount", tb_valor.Text);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
                ContextDatabase.Instance.ExecuteNonQuery(cmd);
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
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@Valor ", balance.GetSaldo(login.numConta) + Convert.ToDecimal(tb_valor.Text));
                        cmd.Parameters.AddWithValue("@numConta", login.numConta);

                        ContextDatabase.Instance.ExecuteNonQuery(cmd);
                        this.AddTransacao("Depósito");
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
