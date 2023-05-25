using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowBook.Clases
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        //Conexión a base de datos sql
        public ConnectionToSql()
        {
            connectionString = "Server=localhost;DataBase= BorrowBook; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
