using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AtmProject
{
    public partial class account : Form
    {
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public account()
        {
            InitializeComponent();

        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            int bal = 0; // Inicialize a variável bal conforme necessário
                         // Verificações individuais de cada campo


            if (string.IsNullOrWhiteSpace(tb_num_conta.Text) ||
                string.IsNullOrWhiteSpace(tb_pin.Text) ||
                string.IsNullOrWhiteSpace(tb_endereco.Text) ||
                string.IsNullOrWhiteSpace(tb_nome.Text) ||
                string.IsNullOrWhiteSpace(tb_telefone.Text) ||
                cb_educacao.SelectedItem == null ||
                string.IsNullOrWhiteSpace(dt_nascimento.Value.ToString("yyyy-MM-dd")))
            {
                MessageBox.Show("Preencha o formulário.");
                return;
            }
            if (!Util.ValidateAccountNumber(tb_num_conta.Text))
            {
                MessageBox.Show("Número da conta inválido. Deve conter exatamente 5 dígitos.");
                return;
            }

            if (!Util.ValidatePin(tb_pin.Text))
            {
                MessageBox.Show("PIN inválido. Deve conter exatamente 5 dígitos.");
                return;
            }

            if (!Util.ValidateName(tb_nome.Text))
            {
                MessageBox.Show("Nome inválido. Deve conter apenas letras.");
                return;
            }

            if (!Util.ValidatePhoneNumber(tb_telefone.Text))
            {
                MessageBox.Show("Número de telefone inválido. ");
                return;
            }

            if (!Util.ValidateAddress(tb_endereco.Text))
            {
                MessageBox.Show("Endereço não pode estar vazio.");
                return;
            }

            if (!Util.ValidateEducation(cb_educacao.SelectedItem.ToString()))
            {
                MessageBox.Show("Educação inválida. Selecione uma opção.");
                return;
            }

            if (!Util.ValidateBirthDate(dt_nascimento.Value))
            {
                MessageBox.Show("Data de nascimento inválida.");
                return;
            }

            if (!Util.IsOver18YearsOld(dt_nascimento.Value))
            {
                MessageBox.Show("Você deve ter 18 anos ou mais para se cadastrar.");
                return;
            }

            using (conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "INSERT INTO Account (AccNum, Name, Phone, Address, Education, Dob, Pin, Balance) VALUES (@AccNum, @Name, @Phone, @Address, @Education, @Dob, @Pin, @Balance)";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        // Adiciona os parâmetros ao comando
                        cmd.Parameters.AddWithValue("@AccNum", tb_num_conta.Text);
                        cmd.Parameters.AddWithValue("@Name", tb_nome.Text);
                        cmd.Parameters.AddWithValue("@Phone", tb_telefone.Text);
                        cmd.Parameters.AddWithValue("@Address", tb_endereco.Text);
                        cmd.Parameters.AddWithValue("@Education", cb_educacao.SelectedItem.ToString()); // Aqui, SelectedItem já é garantido que não é null
                        cmd.Parameters.AddWithValue("@Dob", dt_nascimento.Value.ToString("yyyy-MM-dd")); // Formata a data corretamente
                        cmd.Parameters.AddWithValue("@Pin", tb_pin.Text);
                        cmd.Parameters.AddWithValue("@Balance", bal);

                        // Executa a consulta
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sua conta foi criada com sucesso!");
                        login log = new login();
                        log.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbl_log_out_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void lbl_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_Load(object sender, EventArgs e)
        {
            cb_educacao.SelectedIndex = 0;

        }
    }
}