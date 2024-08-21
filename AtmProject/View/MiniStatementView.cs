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
    public partial class MiniStatementView : Form
    {
        private string _saldo;

        public MiniStatementView()
        {
            InitializeComponent();
        }
        private void Populate()
        {
            string sqlQuery = "Select * from Transactions t where t.AccNum = @NumConta";
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                cmd.Parameters.AddWithValue("@NumConta", LoginView.numConta);
                dt_extrato.DataSource = ContextDatabase.Instance.ReaderDataTable(cmd);
            }

        }
        private void miniStatement_Load(object sender, EventArgs e)
        {
            lb_numConta.Text = "Nº da conta:" + LoginView.numConta;
            try
            {
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
