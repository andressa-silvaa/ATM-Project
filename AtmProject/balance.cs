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
    public partial class balance : Form
    {
        private decimal _saldo;

        public balance()
        {
            InitializeComponent();
            this._saldo = this.GetSaldo(login.numConta);
        }

        public decimal GetSaldo(string numConta)
        {
            string query = "select balance from Account where AccNum = @numConta";
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@numConta", login.numConta);

                decimal result = ContextDatabase.Instance.ExecuteScalar<decimal?>(cmd).GetValueOrDefault();

                return result;
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void balance_Load(object sender, EventArgs e)
        {
            lbl_num_conta_real.Text = login.numConta;
            lbl_saldo_real.Text = this._saldo.ToString("C2");

        }
    }
}
