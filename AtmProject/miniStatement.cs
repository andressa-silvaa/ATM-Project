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
    public partial class miniStatement : Form
    {
        private string _saldo;
        SqlConnection conn;
        string connectionString = "Data Source=DESKTOP-DHI9FTI\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public miniStatement()
        {
            InitializeComponent();
        }
        private void populate()
        {
            using (conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sqlQuery = "Select * from Transactions t where t.AccNum = @NumConta";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@NumConta", login.numConta);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
                        var ds = new DataSet();
                        adapter.Fill(ds);
                        dt_extrato.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        }
        private void miniStatement_Load(object sender, EventArgs e)
        {
            lb_numConta.Text = "Nº da conta:" + login.numConta;
            try
            {
                populate();
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
            home home = new home();
            home.Show();
            this.Hide();
           
        }
    }
}
