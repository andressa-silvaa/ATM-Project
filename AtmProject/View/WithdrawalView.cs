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
    public partial class WithdrawalView : Form
    {
        private decimal _saldo;

        public WithdrawalView()
        {
            InitializeComponent();
        }

        public void AddTransacao(string type, decimal amount)
        {
            string sqlQuery = "INSERT INTO Transactions (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                cmd.Parameters.AddWithValue("@AccNum", LoginView.numConta);
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

        private void lbl_back_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
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
                    var amountWithdrawal = Convert.ToDecimal(tb_valor.Text);
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@Valor ", _saldo - amountWithdrawal);
                        cmd.Parameters.AddWithValue("@numConta", LoginView.numConta);


                        ContextDatabase.Instance.ExecuteNonQuery(cmd);
                        this.AddTransacao("Saque", amountWithdrawal);
                        MessageBox.Show($"O valor {amountWithdrawal:C2} foi sacado da conta {LoginView.numConta}");
                        HomeView home = new HomeView();
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
            lb_numConta.Text = "Nº da conta:" + LoginView.numConta;
            BalanceView balance = new BalanceView();
            _saldo = balance.GetSaldo(LoginView.numConta);
            lbl_valor_real.Text = _saldo.ToString("C2");
        }
    }
}
