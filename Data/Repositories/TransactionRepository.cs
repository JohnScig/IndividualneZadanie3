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

        public DataSet GetFilteredTransactions(List<string> filterCriteria)
        {
            DataSet datasetFilteredTransactions = new DataSet();


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
                    return datasetFilteredTransactions;
                }

                //tb_Iban.Text, transactionType, tb_AmountLowPoint.Text,tb_AmountHighPoint.Text,tb_EarliestDate.Text,tb_LatestDate.Text
                using (SqlCommand command = connection.CreateCommand())
                {
                    string query = "SELECT * from Transactions " +
                       "WHERE " +
                           "JS_TransactionTypeCondition AND " +
                           "JS_LowerThanCondition AND " +
                           "JS_HigherThanCondition AND " +
                           "JS_AfterCondition AND " +
                           "JS_BeforeCondition " +
                        "ORDER BY Timestamp;";

                    // Filtering by Transaction Type
                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                    if (filterCriteria[0].Length != 0)
                    {
                        if (filterCriteria[1] == "debit")
                        {
                            query = query.Replace("JS_TransactionTypeCondition", "FromAccount LIKE @Iban");
                            command.Parameters.Add("@Iban", SqlDbType.NVarChar).Value = "%" + filterCriteria[0] + "%";
                        }
                        else if (filterCriteria[1] == "credit")
                        {
                            query = query.Replace("JS_TransactionTypeCondition", "ToAccount LIKE @Iban");
                            command.Parameters.Add("@Iban", SqlDbType.NVarChar).Value = "%" + filterCriteria[0] + "%";
                        }
                        else
                        {
                            query = query.Replace("JS_TransactionTypeCondition", "(ToAccount LIKE @Iban OR FromAccount LIKE @Iban)");
                            command.Parameters.Add("@Iban", SqlDbType.NVarChar).Value = "%" + filterCriteria[0] + "%";
                        }
                    }
                    else
                    {
                        query = query.Replace("JS_TransactionTypeCondition", "1=1");
                    }



                    //Transfer-Higher-Than Condition
                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                    if (filterCriteria[2].Length != 0)
                    {
                        query = query.Replace("JS_LowerThanCondition", "Amount > @LowPoint");
                        command.Parameters.Add("@LowPoint", SqlDbType.Decimal).Value = Convert.ToDecimal(filterCriteria[2]);
                    }
                    else
                    {
                        query = query.Replace("JS_LowerThanCondition", "1=1");
                    }

                    //Account-Lower-Than Condition
                    if (filterCriteria[3].Length != 0)
                    {
                        query = query.Replace("JS_HigherThanCondition", "Amount < @HighPoint");
                        command.Parameters.Add("@HighPoint", SqlDbType.Decimal).Value = Convert.ToDecimal(filterCriteria[3]);
                    }
                    else
                    {
                        query = query.Replace("JS_HigherThanCondition", "1=1");
                    }



                    //Transfer-Created-After Condition
                    ///////////////////////////////////////////////////////////////////////////////////////////////////
                    if (filterCriteria[4].Length != 0)
                    {
                        query = query.Replace("JS_AfterCondition", "Timestamp > @EarlierPoint");
                        command.Parameters.Add("@EarlierPoint", SqlDbType.DateTime2).Value = InputChecker.ConvertToDate(filterCriteria[4]);
                    }
                    else
                    {
                        query = query.Replace("JS_AfterCondition", "1=1");
                    }

                    //Account-Created-Before Condition
                    if (filterCriteria[5].Length != 0)
                    {
                        query = query.Replace("JS_BeforeCondition", "Timestamp < @LaterPoint");
                        command.Parameters.Add("@LaterPoint", SqlDbType.DateTime2).Value = InputChecker.ConvertToDate(filterCriteria[5]);
                    }
                    else
                    {
                        query = query.Replace("JS_BeforeCondition", "1=1");
                    }


                    command.CommandText = query;

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(datasetFilteredTransactions, "FilteredTransactions");
                        return datasetFilteredTransactions;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return datasetFilteredTransactions;
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
                                                    "VALUES ((SELECT Card.AccountID FROM Card WHERE CardNumber = @CardNumber), @MasterAccount, @Amount, @Timestamp)";
                    command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;
                    command.Parameters.Add("@MasterAccount", SqlDbType.NVarChar).Value = ServerSettings.MasterAccount;
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
                                                    "VALUES (@FromAccount, @MasterAccount, @Amount, @Timestamp)";
                    command.Parameters.Add("@FromAccount", SqlDbType.NVarChar).Value = accountID;
                    command.Parameters.Add("@MasterAccount", SqlDbType.NVarChar).Value = ServerSettings.MasterAccount;
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
                                                    "VALUES (@MasterAccount, @ToAccount, @Amount, @Timestamp)";
                    command.Parameters.Add("@MasterAccount", SqlDbType.NVarChar).Value = ServerSettings.MasterAccount;
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

