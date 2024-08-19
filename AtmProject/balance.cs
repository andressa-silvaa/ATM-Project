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
        private string _saldo;
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public balance()
        {
            InitializeComponent();
            this._saldo = getSaldo(login.numConta);
        }

        public string getSaldo(string numConta)
        {
            try
            {

                string query = "select balance from Account where AccNum = @numConta";
                using (conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@numConta", login.numConta);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "R$ 0";
                    }
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
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
            lbl_saldo_real.Text = "R$ " + (!string.IsNullOrEmpty(_saldo) ? _saldo : "0");

        }
    }
}
