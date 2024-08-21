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
    public partial class ChangePinView : Form
    {
        public ChangePinView()
        {
            InitializeComponent();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
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
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@Valor ", tb_pin.Text);
                        cmd.Parameters.AddWithValue("@numConta", LoginView.numConta);

                        ContextDatabase.Instance.ExecuteNonQuery(cmd);
                        MessageBox.Show("O pin foi atualizado com sucesso!");
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

        private void changePin_Load(object sender, EventArgs e)
        {
            lbl_valor.Text = "Nº da conta:" + LoginView.numConta;
        }
    }
}
