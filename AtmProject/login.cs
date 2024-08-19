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
    public partial class login : Form
    {
        public static string numConta;
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public login()
        {
            InitializeComponent();
        }

        private void lbl_sign_up_Click(object sender, EventArgs e)
        {
            account acc = new account();
            acc.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from Account where AccNum = @numConta and Pin = @Pin";
            using (conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@numConta", tb_num_conta.Text);
                cmd.Parameters.AddWithValue("@Pin", tb_senha.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    numConta = tb_num_conta.Text;
                    home home = new home(); 
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados incorretos.\nTente novamente!");
                }
            }
        }
    }
}
