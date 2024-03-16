using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace MailingListDapp
{
    public class DataAccess
    {
        private string connectionString = "YourConnectionString";

        public void InsertData(string name, string email)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO YourTable (Name, Email) VALUES (@Name, @Email)";
                connection.Execute(query, new { Name = name, Email = email });
            }
        }
    }
}
