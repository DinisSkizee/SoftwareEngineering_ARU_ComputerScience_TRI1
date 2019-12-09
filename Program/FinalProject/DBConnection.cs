using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    class DBConnection
    {
        public static DBConnection dbConnectionSingleton;

        private static string strCon;

        private SqlConnection sqlConn;

        public static DBConnection Instance
        {
            get
            {
                // check if the object was created
                if (dbConnectionSingleton == null)
                {
                    //create the object
                    dbConnectionSingleton = new DBConnection();

                    // set the connection string
                    strCon = Properties.Settings.Default.DatabaseConnectionString;

                }
                return dbConnectionSingleton;
            }
        }

        // Connection String
        public string ConnectionString
        {
            set { strCon = value; }
        }

        public void openConnection()
        {
            sqlConn = new SqlConnection(strCon);

            sqlConn.Open();
        }

        public void closeConnection()
        {
            sqlConn.Close();
        }

        private DataSet MyDataSet(string sqlStatement)
        {
            DataSet dataSet = new DataSet();
            openConnection();


            SqlDataAdapter da1 = new SqlDataAdapter(sqlStatement, strCon);

            da1.Fill(dataSet);

            closeConnection();
            return dataSet;
        }

        public void recordInDB(string firstName, string lastName, string age, string gender, string height, string weight, int diMin, int diMax, int syMin, int syMax, int prMin, int prMax, int brMin, int brMax, int tpMin, int tpMax, int bedNumber)
        {
            // Object of SQLCommand
            SqlCommand command = new SqlCommand();

            //Set its properties
            command.CommandType = CommandType.Text;
            command.CommandText = Query.Insert;
            command.Parameters.Add(new SqlParameter("@FirstName", firstName));
            command.Parameters.Add(new SqlParameter("@LastName", lastName));
            command.Parameters.Add(new SqlParameter("@Age", age));
            command.Parameters.Add(new SqlParameter("@Gender", gender));
            command.Parameters.Add(new SqlParameter("@Height", height));
            command.Parameters.Add(new SqlParameter("@Weight", weight));
            command.Parameters.Add(new SqlParameter("@DiMin", diMin));
            command.Parameters.Add(new SqlParameter("@DiMax", diMax));
            command.Parameters.Add(new SqlParameter("@SyMin", syMin));
            command.Parameters.Add(new SqlParameter("@SyMax", syMax));
            command.Parameters.Add(new SqlParameter("@PrMin", prMin));
            command.Parameters.Add(new SqlParameter("@PrMax", prMax));
            command.Parameters.Add(new SqlParameter("@BrMin", brMin));
            command.Parameters.Add(new SqlParameter("@BrMax", brMax));
            command.Parameters.Add(new SqlParameter("@TpMin", tpMin));
            command.Parameters.Add(new SqlParameter("@TpMax", tpMax));
            command.Parameters.Add(new SqlParameter("@BedNumber", bedNumber));

            openConnection();
            command.Connection = sqlConn;

            int noRows = command.ExecuteNonQuery();

            closeConnection();
        }
    }
}
