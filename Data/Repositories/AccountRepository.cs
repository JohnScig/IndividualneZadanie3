using Data.Models;
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
    public class AccountRepository
    {
        //public static string ServerName { get; set; } = ServerSettings.ServerName;
        //public static string DatabaseName { get; set; } = ServerSettings.DatabaseName;
        //public static string ConnString { get; set; } = $"Server={ServerName}; Database = {DatabaseName}; Trusted_Connection = True";
        public static string ConnString { get; set; } = $"Server={ServerSettings.ServerName}; Database = {ServerSettings.DatabaseName}; Trusted_Connection = True";

        public bool AddAccount(AccountModel accountModel, int ownerID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Account (IBAN,OwnerID,BankID,OpenDate) " +
                            "VALUES (@IBAN,@OwnerID,@BankID,@OpenDate)";
                        command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = accountModel.IBAN;
                        command.Parameters.Add("@OwnerID", SqlDbType.Int).Value = ownerID;
                        command.Parameters.Add("@BankID", SqlDbType.NVarChar).Value = accountModel.BankID;
                        command.Parameters.Add("@OpenDate", SqlDbType.DateTime2).Value = accountModel.OpenDate;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            Debug.WriteLine("Account Added");
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool AddAccount(AccountModel accountModel, string personalID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Account (IBAN,OwnerID,BankID,OpenDate) " +
                            "VALUES (@IBAN,(SELECT Client_ID FROM Client WHERE PersonalID = @PersonalID),@BankID,@OpenDate)";
                        command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = accountModel.IBAN;
                        command.Parameters.Add("@PersonalID", SqlDbType.NVarChar).Value = personalID;
                        command.Parameters.Add("@BankID", SqlDbType.NVarChar).Value = accountModel.BankID;
                        command.Parameters.Add("@OpenDate", SqlDbType.DateTime2).Value = accountModel.OpenDate;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            Debug.WriteLine("Account Added");
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public bool CloseAccount(string iban)
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
                        command.CommandText = "UPDATE Account SET CloseDate = GETDATE() WHERE IBAN = @Iban";

                        command.Parameters.Add("@Iban", SqlDbType.NVarChar).Value = iban;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }

                        return false;
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

        public bool CheckAccountExistence(int clientID)
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
                    command.CommandText = "SELECT CASE WHEN EXISTS (SELECT * FROM Account WHERE OwnerID=@ClientID) THEN 1 ELSE 0 END";
                    command.Parameters.Add("@ClientID", SqlDbType.NVarChar).Value = clientID;

                    try
                    {
                        return Convert.ToBoolean(command.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return false;
                    }


                }
            }
        }

        public List<string> GetBasicInfo(string clientID)
        {
            List<string> basicInfo = new List<string>();
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
                    return basicInfo;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT IBAN,Balance,DebtLimit FROM Account WHERE OwnerID=@ClientID";
                    command.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientID;

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                basicInfo.Add(reader.GetString(0));
                                basicInfo.Add(reader.GetDecimal(1).ToString());
                                basicInfo.Add(reader.GetDecimal(2).ToString());
                            }

                            return basicInfo;

                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return basicInfo;
                    }


                }
            }
        }

        public DataSet GetAllAccounts()
        {
            DataSet datasetAllAccount = new DataSet();


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
                    return datasetAllAccount;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select C.LastName, C.FirstName, C.PersonalID,  A.IBAN,A.Balance,A.DebtLimit,A.BankID,A.OpenDate,A.CloseDate FROM Client AS C INNER JOIN Account AS A ON C.Client_ID = A.OwnerID ORDER BY C.LastName, C.FirstName";
                    //command.Parameters.Add("@accountID", SqlDbType.NVarChar).Value = accountID;


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(datasetAllAccount, "AllAccounts");
                        return datasetAllAccount;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return datasetAllAccount;
                    }

                }
            }
        }

        public List<AccountModel> GetAllAccounts(string personalID)
        {
            List<AccountModel> allAccounts = new List<AccountModel>();


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
                    return allAccounts;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT A.* FROM Account AS A LEFT JOIN Client AS C ON A.OwnerID=C.Client_ID WHERE C.PersonalID = @PersonalID";
                    command.Parameters.Add("@PersonalID", SqlDbType.NVarChar).Value = personalID;
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                allAccounts.Add(new AccountModel()
                                {
                                    IBAN = reader.GetString(0),
                                    Balance = reader.GetDecimal(1),
                                    DebtLimit = reader.GetDecimal(2),
                                    OwnerID = reader.GetInt32(3),
                                    BankID = reader.GetString(4),
                                    OpenDate = reader.GetDateTime(5),
                                    CloseDate = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                                });
                            }
                        }

                        return allAccounts;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return allAccounts;
                    }

                }
            }
        }

        public bool Withdraw(decimal amount, string accountID)
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
                        command.CommandText = "UPDATE Account SET Balance=Balance-@Amount " +
                            "WHERE IBAN = @AccountID " +
                            "AND Balance >= @Amount;";

                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@AccountID", SqlDbType.NVarChar).Value = accountID;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            return (new TransactionRepository().NewBankWithdrawal(amount, accountID));
                        }

                        return false;
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

        public bool Deposit(decimal amount, string accountID)
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
                        command.CommandText = "UPDATE Account SET Balance=Balance+@Amount " +
                            "WHERE IBAN = @AccountID;";

                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@AccountID", SqlDbType.NVarChar).Value = accountID;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            return (new TransactionRepository().NewBankDeposit(amount, accountID));
                        }

                        return false;
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

        public static bool TransferMoney(string senderIBAN, string receiverIBAN, decimal amount, string variable, string specific, string constant, string message)
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
                        command.CommandText = "UPDATE Account SET Balance = Balance - @Amount WHERE IBAN = @SenderIBAN; " +
                                              "UPDATE Account SET Balance = Balance + @Amount WHERE IBAN = @ReceiverIBAN; ";

                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@SenderIBAN", SqlDbType.NVarChar).Value = senderIBAN;
                        command.Parameters.Add("@ReceiverIBAN", SqlDbType.NVarChar).Value = receiverIBAN;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            return (new TransactionRepository().NewTransfer(senderIBAN, receiverIBAN, amount, variable, specific, constant, message));
                        }

                        return false;
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
    }
}
