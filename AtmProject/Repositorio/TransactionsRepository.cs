using AtmProject.Banco;
using AtmProject.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace AtmProject.Repositorio
{
    public class TransactionsRepository
    {
        public bool Create(int accNum, decimal amount, string description)
        {
            using (SqlCommand cmd = this.CreateTransactionCommand(accNum, amount, description))
            {
                return ContextDatabase.Instance.ExecuteNonQuery(cmd);
            }
        }

        public SqlCommand CreateTransactionCommand(int accNum, decimal amount, string description)
        {
            string sqlQuery = "INSERT INTO Transactions (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@AccNum", accNum);
            cmd.Parameters.AddWithValue("@Amount", amount);
            cmd.Parameters.AddWithValue("@Type", description);
            cmd.Parameters.AddWithValue("@TDate", DateTime.Now);
            return cmd;
        }

        public DataTable GetAllTransactionsDataSource(int accNum)
        {
            string sqlQuery = "Select * from Transactions t where t.AccNum = @NumConta";
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                cmd.Parameters.AddWithValue("@NumConta", accNum);
                return ContextDatabase.Instance.ReaderDataTable(cmd);
            }
        }
        public List<Transaction> GetAllTransactions(int accNum)
        {
            string sqlQuery = "Select * from Transactions t where t.AccNum = @NumConta";
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                cmd.Parameters.AddWithValue("@NumConta", accNum);
                return ContextDatabase.Instance.ReaderClassList<Transaction>(cmd);
            }
        }
    }
}
