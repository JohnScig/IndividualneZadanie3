using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TransactionRepository
    {
        public static string ConnString { get; set; } = $"Server={ServerSettings.ServerName}; Database = {ServerSettings.DatabaseName}; Trusted_Connection = True";

        public DataSet GetTransactions(string accountID)
        {
            DataSet datasetTransactions = new DataSet();


            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return datasetTransactions;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * from Transactions WHERE FromAccount = @accountID OR ToAccount = @accountID ORDER BY Timestamp;";
                    command.Parameters.Add("@accountID", SqlDbType.NVarChar).Value = accountID;


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(datasetTransactions, "Transactions");
                        return datasetTransactions;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return datasetTransactions;
                    }

                }
            }
        }

        public DataSet GetTransactions()
        {
            DataSet datasetTransactions = new DataSet();


            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return datasetTransactions;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * from Transactions ORDER BY Timestamp;";
                    //command.Parameters.Add("@accountID", SqlDbType.NVarChar).Value = accountID;


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(datasetTransactions, "AllTransactions");
                        return datasetTransactions;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return datasetTransactions;
                    }

                }
            }
        }
    }
}
