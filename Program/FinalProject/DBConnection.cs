using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    class DBConnection
    {
        public DBConnection()
        {
            dbConnectionSingleton = this;
            strCon = Properties.Settings.Default.DatabaseConnectionString;
        }

        // DBConnection class is used to create the connection between the program and the database

        // Create singleton object of the database connection
        public static DBConnection dbConnectionSingleton = new DBConnection();

        // Create a Connection string
        private static string strCon;

        // Create a SqlConnection object
        public SqlConnection sqlConn;

        // Get the Instance if it doesn't exist create a new one if it exists use that one (singleton pattern)
        //public static DBConnection Instance
        //{
        //    get
        //    {
        //        // check if the object was created
        //        if (dbConnectionSingleton == null)
        //        {
        //            //create the object
        //            dbConnectionSingleton = new DBConnection();

        //            // set the connection string
        //            strCon = Properties.Settings.Default.DatabaseConnectionString;

        //        }
        //        return dbConnectionSingleton;
        //    }
        //}

        // Connection String
        public string ConnectionString
        {
            set { strCon = value; }
        }

        // Open Connection method
        public void openConnection()
        {
            sqlConn = new SqlConnection(strCon);

            sqlConn.Open();
        }

        // Close Connection method
        public void closeConnection()
        {
            sqlConn.Close();
        }

        // DataSet method
        private DataSet MyDataSet(string sqlStatement)
        {
            // Create the DataSet object
            DataSet dataSet = new DataSet();

            // Open DBConnection
            openConnection();

            // Create SqlDataAdapter object
            SqlDataAdapter da1 = new SqlDataAdapter(sqlStatement, strCon);

            // Fill the SqlDataAdapter with the dataSet
            da1.Fill(dataSet);

            // Close the connection
            closeConnection();

            return dataSet;
        }

        // Method to record values on the database
        public void recordInDB(string firstName, string lastName, string age, string gender, string height, string weight, int diMin, int diMax, int syMin, int syMax, int prMin, int prMax, int brMin, int brMax, int tpMin, int tpMax, int bedNumber)
        {
            try
            {
                // Object of SqlCommand
                SqlCommand command = new SqlCommand();

                // Set its properties
                command.CommandType = CommandType.Text;

                // Insert the data to the database
                command.CommandText = Query.Insert;

                // Add firstName to @FirstName and so on
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

                // Open the connection
                openConnection();

                // Set the SqlCommand Connection to sqlConn
                command.Connection = sqlConn;

                // Execute NonQuery to get the number of rows
                int noRows = command.ExecuteNonQuery();

                // Close the connection
                closeConnection();
            }
            catch(Exception error)
            {
                MessageBox.Show("ERROR! \n Error Message: " + error.Message + ". \n Please try again!", "Error");
            }
        }
    }
}