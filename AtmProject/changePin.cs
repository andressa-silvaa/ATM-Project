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
    public partial class changePin : Form
    {
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public changePin()
        {
            InitializeComponent();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            if (tb_pin.Text == "" || tb_confirma_pin.Text == "")
            {
                MessageBox.Show("Preencha os campos!");
            }
            else if (tb_confirma_pin.Text != tb_pin.Text)
            {
                MessageBox.Show("Os campos devem ser iguais!");
            }
            else
            {
                try
                {
                    string query = "update Account set Pin = @Valor where Account.AccNum = @NumConta";
                    using (conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Valor ", tb_pin.Text);
                        cmd.Parameters.AddWithValue("@numConta", login.numConta);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("O pin foi atualizado com sucesso!");
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

        private void changePin_Load(object sender, EventArgs e)
        {
            lbl_valor.Text = "Nº da conta:" + login.numConta;
        }
    }
}
