using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Security.Policy;

namespace AtmProject.Banco
{
    public class ContextDatabase
    {
        #region Fields
        protected readonly SqlConnection _connection;
        #endregion

        #region Properties

        #endregion

        #region Constructor
        private ContextDatabase(string connectionString)
        {
            this._connection = new SqlConnection(connectionString);
            this._connection.Open();
        }
        #endregion

        #region Singleton Pattern
        private static ContextDatabase instance;
        public static ContextDatabase Instance
        {
            get
            {
                return instance ?? (instance = new ContextDatabase("Data Source=DESKTOP-NBJ41R8;Initial Catalog=ATM;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"));
            }
        }
        #endregion


        #region Methods
        public bool ExecuteNonQuery(SqlCommand cmd)
        {
            return this.ExecuteNonQuery(new List<SqlCommand> { cmd });
        }
        public bool ExecuteNonQuery(List<SqlCommand> cmds)
        {
            SqlTransaction trans = _connection.BeginTransaction();
            try
            {
                int rowsAffected = 0;
                foreach (var cmd in cmds)
                {
                    cmd.Connection = _connection;
                    cmd.Transaction = trans;
                    rowsAffected += cmd.ExecuteNonQuery();
                }
                trans.Commit();
                return rowsAffected != 0;
            }
            catch (Exception)
            {
                trans.Rollback();
                throw;
            }
        }
        public T? ExecuteScalar<T>(SqlCommand cmd)
        {
            cmd.Connection = _connection;
            var obj = (T)cmd.ExecuteScalar();
            return (obj == null || DBNull.Value.Equals(obj)) ? default : (T)obj;
        }


        //Dapper (orm) resolve esse problema de uma forma mais simples.
        public List<T> ReaderClassList<T>(SqlCommand cmd)
        {
            using (DataTable dt = new DataTable())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                cmd.Connection = _connection;

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
                var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToList();

                var objectProperties = typeof(T).GetProperties(flags);
                var targetList = dt.AsEnumerable().Select(dataRow =>
                {
                    var instanceOfT = Activator.CreateInstance<T>();
                    foreach (var item in objectProperties)
                    {
                        string colName = item.Name;
                        if (columnNames.Contains(colName) && dataRow[colName] != DBNull.Value)
                            item.SetValue(instanceOfT, dataRow[colName], null);
                    }
                    return instanceOfT;
                }).ToList();
                return targetList;
            }
        }

        public DataTable ReaderDataTable(SqlCommand cmd)
        {
            using (DataTable dt = new DataTable())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                cmd.Connection = _connection;
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                return dt;
            }
        }
        #endregion

    }
}
