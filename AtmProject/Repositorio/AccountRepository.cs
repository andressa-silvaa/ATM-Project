using AtmProject.Banco;
using AtmProject.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace AtmProject.Repositorio
{
    public class AccountRepository
    {
        protected readonly TransactionsRepository _transactionsRepository;
        public AccountRepository()
        {
            this._transactionsRepository = new TransactionsRepository();
        }

        public bool Create(Account account)
        {
            string sqlQuery = "INSERT INTO Account (AccNum, Name, Phone, Address, Education, Dob, Pin, Balance) VALUES (@AccNum, @Name, @Phone, @Address, @Education, @Dob, @Pin, @Balance)";
            using (SqlCommand cmd = new SqlCommand(sqlQuery))
            {
                // Adiciona os parâmetros ao comando
                cmd.Parameters.AddWithValue("@AccNum", account.AccNum);
                cmd.Parameters.AddWithValue("@Name", account.Name);
                cmd.Parameters.AddWithValue("@Phone", account.Phone);
                cmd.Parameters.AddWithValue("@Address", account.Address);
                cmd.Parameters.AddWithValue("@Education", account.Education);
                cmd.Parameters.AddWithValue("@Dob", account.Dob);
                cmd.Parameters.AddWithValue("@Pin", account.Pin);
                cmd.Parameters.AddWithValue("@Balance", decimal.Zero);//Cria a conta sem saldo inicial.

                return ContextDatabase.Instance.ExecuteNonQuery(cmd);
            }
        }

        public decimal GetBalance(int accNum)
        {
            string query = "select balance from Account where AccNum = @numConta";
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@numConta", accNum);

                decimal result = ContextDatabase.Instance.ExecuteScalar<decimal?>(cmd).GetValueOrDefault();

                return result;
            }
        }
        public bool UpdatePin(int accNum, int newPin)
        {
            string query = "update Account set Pin = @Valor where Account.AccNum = @NumConta";
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@Valor ", newPin);
                cmd.Parameters.AddWithValue("@numConta", accNum);

                return ContextDatabase.Instance.ExecuteNonQuery(cmd);
            }
        }

        public bool Login(int accNum, int pin)
        {
            string query = "select count(*) from Account where AccNum = @numConta and Pin = @Pin";
            using (SqlCommand cmd = new SqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@numConta", accNum);
                cmd.Parameters.AddWithValue("@Pin", pin);
                return ContextDatabase.Instance.ReaderDataTable(cmd).Rows.Count != 0;
            }
        }

        public bool Deposit(int accNum, decimal value, string? description = null)
        {
            var positiveValue = Math.Abs(value);
            return this.SetBalance(accNum, positiveValue, description ?? "Depósito");
        }
        public bool Withdrawal(int accNum, decimal value, string? description = null)
        {
            var negativeValue = Math.Abs(value) * -1;
            return this.SetBalance(accNum, negativeValue, description ?? "Saque");

        }
        private bool SetBalance(int accNum, decimal value, string description)
        {
            string query = "update Account set Balance = Balance + @Valor where Account.AccNum = @NumConta";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@Valor ", value);
            cmd.Parameters.AddWithValue("@numConta", accNum);

            SqlCommand cmd2 = _transactionsRepository.CreateTransactionCommand(accNum, Math.Abs(value), description);

            //execute transaction
            return ContextDatabase.Instance.ExecuteNonQuery(new List<SqlCommand>() { cmd, cmd2 });
        }


    }
}
