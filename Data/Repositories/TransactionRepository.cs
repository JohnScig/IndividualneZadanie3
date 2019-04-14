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

        public bool NewATMWithdrawal(decimal amount, string cardNumber)
        {

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
                    return false;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Transactions (FromAccount, ToAccount, Amount, Timestamp) " +
                                                    "VALUES ((SELECT Card.AccountID FROM Card WHERE CardNumber = @CardNumber), @ToAccount, @Amount, @Timestamp)";
                    command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;
                    command.Parameters.Add("@ToAccount", SqlDbType.NVarChar).Value = "SK8699990000009999999999";
                    command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                    command.Parameters.Add("@Timestamp", SqlDbType.DateTime2).Value = DateTime.Now;

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return false;
                    }
                }
            }
            return false;
        }

        public bool NewBankWithdrawal(decimal amount, string accountID)
        {

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
                    return false;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Transactions (FromAccount, ToAccount, Amount, Timestamp) " +
                                                    "VALUES (@FromAccount, @ToAccount, @Amount, @Timestamp)";
                    command.Parameters.Add("@FromAccount", SqlDbType.NVarChar).Value = accountID;
                    command.Parameters.Add("@ToAccount", SqlDbType.NVarChar).Value = "SK8699990000009999999999";
                    command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                    command.Parameters.Add("@Timestamp", SqlDbType.DateTime2).Value = DateTime.Now;

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return false;
                    }
                }
            }
            return false;
        }

        public bool NewBankDeposit(decimal amount, string accountID)
        {

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
                    return false;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO Transactions (FromAccount, ToAccount, Amount, Timestamp) " +
                                                    "VALUES (@FromAccount, @ToAccount, @Amount, @Timestamp)";
                    command.Parameters.Add("@FromAccount", SqlDbType.NVarChar).Value = "SK8699990000009999999999";
                    command.Parameters.Add("@ToAccount", SqlDbType.NVarChar).Value = accountID;
                    command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                    command.Parameters.Add("@Timestamp", SqlDbType.DateTime2).Value = DateTime.Now;

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return false;
                    }
                }
            }
            return false;
        }

        public bool NewTransfer(string senderIBAN, string receiverIBAN, decimal amount, string variable, string specific, string constant, string message)
        {
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
                    return false;
                }
                try
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Transactions Values(@FromAccount,@ToAccount,@Amount,@VariableSymbol,@SpecificSymbol,@ConstantSymbol,@Message,@Timestamp)";
                        command.Parameters.Add("@FromAccount", SqlDbType.NVarChar).Value = senderIBAN;
                        command.Parameters.Add("@ToAccount", SqlDbType.NVarChar).Value = receiverIBAN;
                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@VariableSymbol", SqlDbType.NVarChar).Value = variable;
                        command.Parameters.Add("@SpecificSymbol", SqlDbType.NVarChar).Value = specific;
                        command.Parameters.Add("@ConstantSymbol", SqlDbType.NVarChar).Value = constant;
                        command.Parameters.Add("@Message", SqlDbType.NVarChar).Value = message;
                        command.Parameters.Add("@Timestamp", SqlDbType.DateTime2).Value = DateTime.Now;

                        if (command.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                    }
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return false;
                }
            }
            return false;
        }

    }
}

