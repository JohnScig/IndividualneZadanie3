using System;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;


namespace Data.Repositories
{
    public class AccountRepository
    {
        /// <summary>
        /// Connection string for the database
        /// </summary>
        public static string ConnString { get; set; } = $"Server={ServerSettings.ServerName}; Database = {ServerSettings.DatabaseName}; Trusted_Connection = True";

        /// <summary>
        /// Method that adds a new account based on the owner's ID. 
        /// This method is called after creating a new client -> at this point, his ID is returned, which makes it simpler to create the account directly with his ID
        /// </summary>
        /// <param name="accountModel">account model to be written into the database</param>
        /// <param name="ownerID">Owner's ID</param>
        /// <returns>returns true if the account is written into the database successfully</returns>
        public bool AddAccount(AccountModel accountModel, int ownerID)
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
                    command.CommandText = "INSERT INTO Account (IBAN,OwnerID,BankID,OpenDate) " +
                        "VALUES (@IBAN,@OwnerID,@BankID,@OpenDate)";
                    command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = accountModel.IBAN;
                    command.Parameters.Add("@OwnerID", SqlDbType.Int).Value = ownerID;
                    command.Parameters.Add("@BankID", SqlDbType.NVarChar).Value = accountModel.BankID;
                    command.Parameters.Add("@OpenDate", SqlDbType.DateTime2).Value = accountModel.OpenDate;

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            Debug.WriteLine("Account Added");
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

        /// <summary>
        /// Method that adds a new account based on the owner's ID Card. 
        /// This method is called when an owner already exists
        /// </summary>
        /// <param name="accountModel">account model to be written into the database</param>
        /// <param name="personalID">Owner's ID Card Number</param>
        /// <returns>returns true if the account is written into the database successfully</returns>
        public bool AddAccount(AccountModel accountModel, string personalID)
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
                    command.CommandText = "INSERT INTO Account (IBAN,OwnerID,BankID,OpenDate) " +
                        "VALUES (@IBAN,(SELECT Client_ID FROM Client WHERE PersonalID = @PersonalID),@BankID,@OpenDate)";
                    command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = accountModel.IBAN;
                    command.Parameters.Add("@PersonalID", SqlDbType.NVarChar).Value = personalID;
                    command.Parameters.Add("@BankID", SqlDbType.NVarChar).Value = accountModel.BankID;
                    command.Parameters.Add("@OpenDate", SqlDbType.DateTime2).Value = accountModel.OpenDate;

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            Debug.WriteLine("Account Added");
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

        /// <summary>
        /// Method which closes an account (gives it a CloseDate value in the database)
        /// </summary>
        /// <param name="iban">Iban number of the account to be closed</param>
        /// <returns>Returns true if the account is closed successfully</returns>
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

        /// <summary>
        /// Checks whether a client has an existing account
        /// </summary>
        /// <param name="clientID">Client's ID Card Number</param>
        /// <returns>return true if the client has an account</returns>
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

        /// <summary>
        /// Returns basic information about the client and his account in a list of strings.
        /// </summary>
        /// <param name="clientID">Client's ID card based on which the data is fetched</param>
        /// <returns>a list of strings with basic information on the client and his account</returns>
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

        /// <summary>
        /// Method for getting all accounts in the database.
        /// </summary>
        /// <returns>A dataset of all existing accounts</returns>
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

        /// <summary>
        /// Returns accounts filtered based on the criteria. These can be combines into multiple filters.
        /// </summary>
        /// <param name="filterCriteria">List of string containing the parameters for filtering</param>
        /// <returns>Datased of filtered accounts</returns>
        public DataSet GetFilteredAccounts(List<string> filterCriteria)
        {
            DataSet datasetFilteredAccount = new DataSet();


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
                    return datasetFilteredAccount;
                }
                //{  tb_LastName.Text, tb_FirstName.Text, tb_PersonalID.Text, tb_Iban.Text, accountStatus, tb_EarliestDate.Text, tb_LatestDate.Text };
                using (SqlCommand command = connection.CreateCommand())
                {
                    string query = "SELECT C.LastName, C.FirstName, C.PersonalID, A.IBAN,A.Balance,A.DebtLimit,A.BankID,A.OpenDate,A.CloseDate " +
                       "FROM Client AS C INNER JOIN Account AS A ON C.Client_ID = A.OwnerID " +
                       "WHERE " +
                           "JS_LastNameCondition AND " +
                           "JS_FirstNameCondition AND " +
                           "JS_PersonalIDCondition AND " +
                           "JS_IBANCondition AND " +
                           "JS_StatusCondition AND " +
                           "JS_AfterCondition AND " +
                           "JS_BeforeCondition " +
                       "ORDER BY C.LastName, C.FirstName";


                    //Last Name Condition
                    if (filterCriteria[0].Length != 0)
                    {
                        query = query.Replace("JS_LastNameCondition", "C.LastName LIKE @LastName");
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = "%" + filterCriteria[0] + "%";
                    }
                    else
                    {
                        query = query.Replace("JS_LastNameCondition", "1=1");
                    }


                    //First Name Condition
                    if (filterCriteria[1].Length != 0)
                    {
                        query = query.Replace("JS_FirstNameCondition", "C.FirstName LIKE @FirstName");
                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = "%" + filterCriteria[1] + "%";
                    }
                    else
                    {
                        query = query.Replace("JS_FirstNameCondition", "1=1");
                    }


                    //Personal ID Condition
                    if (filterCriteria[2].Length != 0)
                    {
                        query = query.Replace("JS_PersonalIDCondition", "C.PersonalID LIKE @PersonalID");
                        command.Parameters.Add("@PersonalID", SqlDbType.NVarChar).Value = "%" + filterCriteria[2] + "%";
                    }
                    else
                    {
                        query = query.Replace("JS_PersonalIDCondition", "1=1");
                    }


                    //IBAN Condition
                    if (filterCriteria[3].Length != 0)
                    {
                        query = query.Replace("JS_IBANCondition", "A.IBAN LIKE @IBAN");
                        command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = "%" + filterCriteria[3] + "%";
                    }
                    else
                    {
                        query = query.Replace("JS_IBANCondition", "1=1");
                    }

                    // filter open/closed/all accounts
                    if (filterCriteria[4] == "open")
                    {
                        query = query.Replace("JS_StatusCondition", "A.CloseDate IS NULL");
                    }
                    else if (filterCriteria[4] == "closed")
                    {
                        query = query.Replace("JS_StatusCondition", "A.CloseDate IS NOT NULL");
                    }
                    else
                    {
                        query = query.Replace("JS_StatusCondition", "1=1");
                    }

                    //Account-Created-After Condition
                    if (filterCriteria[5].Length != 0)
                    {
                        query = query.Replace("JS_AfterCondition", "A.OpenDate > @EarlierPoint");
                        command.Parameters.Add("@EarlierPoint", SqlDbType.DateTime2).Value = InputChecker.ConvertToDate(filterCriteria[5]);
                    }
                    else
                    {
                        query = query.Replace("JS_AfterCondition", "1=1");
                    }

                    //Account-Created-Before Condition
                    if (filterCriteria[6].Length != 0)
                    {
                        query = query.Replace("JS_BeforeCondition", "A.OpenDate < @LaterPoint");
                        command.Parameters.Add("@LaterPoint", SqlDbType.DateTime2).Value = InputChecker.ConvertToDate(filterCriteria[6]);
                    }
                    else
                    {
                        query = query.Replace("JS_BeforeCondition", "1=1");
                    }


                    command.CommandText = query;

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(datasetFilteredAccount, "FilteredAccounts");
                        return datasetFilteredAccount;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return datasetFilteredAccount;
                    }

                }
            }
        }

        /// <summary>
        /// Method for getting all accounts for a certain client identified by his personal ID.
        /// </summary>
        /// <param name="personalID">Client's ID card number</param>
        /// <returns>List of AccountModel entities belonging to one client</returns>
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

        /// <summary>
        /// Function for adjusting the overdraw debit limit on the account
        /// </summary>
        /// <param name="iban">Identifier of the account - IBAN</param>
        /// <param name="newDebitLimit">New value for the debit limti</param>
        /// <returns>returns true if the new value was set in the database</returns>
        public bool AdjustDebit(string iban, decimal newDebitLimit)
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
                    command.CommandText = "UPDATE Account SET DebtLimit = @NewDebitLimit WHERE IBAN = @Iban";
                    command.Parameters.Add("@NewDebitLimit", SqlDbType.NVarChar).Value = newDebitLimit;
                    command.Parameters.Add("@Iban", SqlDbType.NVarChar).Value = iban;

                    try
                    {
                        return Convert.ToBoolean(command.ExecuteNonQuery());
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

        /// <summary>
        /// Function for handling withdrawal of money from the bank.
        /// </summary>
        /// <param name="amount">Amount to be withdrawn</param>
        /// <param name="accountID">ID number of the account - IBAN</param>
        /// <returns>Returns true if the withdrawal was successful</returns>
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
                            "AND Balance+DebtLimit >= @Amount; ";


                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@AccountID", SqlDbType.NVarChar).Value = accountID;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            using (SqlCommand command2 = connection.CreateCommand())
                            {
                                command2.CommandText = "UPDATE Account SET Balance=Balance+@Amount " +
                                                       "WHERE IBAN = @MasterAccount;";
                                command2.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                                command2.Parameters.Add("@MasterAccount", SqlDbType.NVarChar).Value = ServerSettings.MasterAccount;

                                if (command2.ExecuteNonQuery() > 0)
                                {
                                    return (new TransactionRepository().NewBankWithdrawal(amount, accountID));
                                }
                            }
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

        /// <summary>
        /// Function for handling deposit of money to the bank.
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        /// <param name="accountID">ID number of the account - IBAN</param>
        /// <returns>Returns true if the deposit was successful</returns>
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
                            "WHERE IBAN = @AccountID; " +
                            "UPDATE Account SET Balance=Balance-@Amount " +
                            "WHERE IBAN = @MasterAccount;";

                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@AccountID", SqlDbType.NVarChar).Value = accountID;
                        command.Parameters.Add("@MasterAccount", SqlDbType.NVarChar).Value = ServerSettings.MasterAccount;

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

        /// <summary>
        /// Function for handling transaction of money between two accounts.
        /// </summary>
        /// <param name="senderIBAN">Identification of the sender</param>
        /// <param name="receiverIBAN">Identification of the receiver</param>
        /// <param name="amount">Amount to be transfered</param>
        /// <param name="variable">Variable Symbol</param>
        /// <param name="specific">Specific Symbol</param>
        /// <param name="constant">Constant Symbol</param>
        /// <param name="message">Message for the receiver</param>
        /// <returns>Returns true if the transaction went smoothly, amounts were subtracted/added to their respective account and the transaction was put into the database</returns>
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

        /// <summary>
        /// Function for selecting top 10 clients - they have more than 3 active accounts
        /// </summary>
        /// <returns>A Dataset of 10 clients with more than 3 accounts</returns>
        public DataSet GetTopClients()
        {

            DataSet topClients = new DataSet();


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
                    return topClients;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP 10 C.FirstName, C.LastName, Count(A.IBAN) AS 'Number Of Accounts' " +
                                    "FROM Account AS A LEFT JOIN Client AS C ON A.OwnerID = C.Client_ID " +
                                    "GROUP BY A.OwnerID, C.FirstName, C.LastName " +
                                    "HAVING COUNT(A.IBAN) >= 3 " +
                                    "ORDER BY COUNT(A.IBAN) DESC";
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(topClients, "TopClients");
                        return topClients;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return topClients;
                    }

                }
            }

        }

        /// <summary>
        /// Function for retrieving the amount of money the bank has in all accounts
        /// </summary>
        /// <returns>Dataset with the numeric information</returns>
        public DataSet GetBankAssets()
        {
            DataSet bankAssets = new DataSet();


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
                    return bankAssets;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT SUM(Balance) AS 'Total Bank Assets' FROM Account WHERE OwnerID <> 1";
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(bankAssets, "BankAssets");
                        return bankAssets;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return bankAssets;
                    }

                }
            }
        }

        /// <summary>
        /// unction for retrieving the number of active accounts
        /// </summary>
        /// <returns>Dataset with the relevant information</returns>
        public DataSet GetNumberOfAccounts()
        {
            DataSet numberOfAccounts = new DataSet();


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
                    return numberOfAccounts;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT (*) AS 'Total Number Of Accounts' FROM Account WHERE OwnerID <> 1 AND CloseDate IS NULL;";
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(numberOfAccounts, "NumberOfAccounts");
                        return numberOfAccounts;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return numberOfAccounts;
                    }

                }
            }
        }

        /// <summary>
        /// Function which calculates how many accounts there are per person on average
        /// </summary>
        /// <returns>Dataset with the relevant information</returns>
        public DataSet GetAverageAccountPerPerson()
        {
            DataSet averageAccountPerPerson = new DataSet();


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
                    return averageAccountPerPerson;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT " +
                        "((SELECT COUNT(*)-1.0 FROM Account WHERE CloseDate IS NULL) " +
                        "/ " +
                        "(SELECT COUNT (DISTINCT Client_ID) -1 FROM Client AS C LEFT JOIN Account AS A ON C.Client_ID = A.OwnerID WHERE IBAN IS NOT NULL)) " +
                        "AS 'Number of Accounts Per Person'";
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(averageAccountPerPerson, "AverageAccountPerPerson");
                        return averageAccountPerPerson;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return averageAccountPerPerson;
                    }

                }
            }
        }

        /// <summary>
        /// Function for retrieving top 10 accounts with the most money in them.
        /// </summary>
        /// <returns>Dataset with the relevant information</returns>
        public DataSet GetTopAccounts()
        {
            DataSet topAccounts = new DataSet();


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
                    return topAccounts;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT TOP 10 IBAN, Balance, OpenDate FROM Account WHERE OwnerID<>1 AND CloseDate IS NULL ORDER BY Balance DESC;";
                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(topAccounts, "TopAccounts");
                        return topAccounts;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return topAccounts;
                    }

                }
            }

        }

        /// <summary>
        /// Returns a summary of accounts created within the past 6 months per month.
        /// </summary>
        /// <returns>Dataset with the relevant information</returns>
        public DataSet GetAccountsByMonths()
        {
            DataSet accountsByMonth = new DataSet();


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
                    return accountsByMonth;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @" SELECT COUNT (IBAN) AS 'Number of Accounts', CONCAT (DATEPART(YEAR,OpenDate), ' ',
                                             Format(OpenDate,'MMMM')) AS 'Date of Creation'
                                             FROM Account 
                                              WHERE DATEDIFF(MONTH,OpenDate,GETDATE()) < 6
                                             GROUP BY DATEPART(YEAR,OpenDate), Format(OpenDate,'MMMM') 
                                             ORDER BY DATEPART(YEAR,opendate) DESC, Format(OpenDate,'MMMM') DESC";

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(accountsByMonth, "AccountsByMonth");
                        return accountsByMonth;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return accountsByMonth;
                    }

                }
            }
        }


    }
}