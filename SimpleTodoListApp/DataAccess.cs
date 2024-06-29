using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SimpleTodoListApp
{
    public class DataAccess
    {
        private SqlConnection sqlConnector;

        public DataAccess()
        {
            sqlConnector = new SqlConnection(@"Server=.\; Database=TODOLIST_DB; Integrated Security=true");
        }

        public void openConnection()
        {
            if (sqlConnector.State != ConnectionState.Open)
                sqlConnector.Open();
        }

        public void closeConnection()
        {
            if (sqlConnector.State != ConnectionState.Closed)
                sqlConnector.Close();
        }

        public DataTable selectData(string commandText)
        {
            SqlCommand command = new SqlCommand(commandText, sqlConnector);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void executeCommand(string commandText, SqlParameter[] sqlParams)
        {
            SqlCommand command = new SqlCommand(commandText, sqlConnector);
            if (sqlParams != null)
                command.Parameters.AddRange(sqlParams);
            command.ExecuteNonQuery();
        }
    }
}
