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
    public class CardRepository
    {
        //public static string ServerName { get; set; } = ServerSettings.ServerName;
        //public static string DatabaseName { get; set; } = ServerSettings.DatabaseName;
        //public static string ConnString { get; set; } = $"Server={ServerName}; Database = {DatabaseName}; Trusted_Connection = True";

        /// <summary>
        /// Connection String
        /// </summary>
        public static string ConnString { get; set; } = $"Server={ServerSettings.ServerName}; Database = {ServerSettings.DatabaseName}; Trusted_Connection = True";

        /// <summary>
        /// Checks whether the card is blocked.
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        /// <returns>Returns true if the card is blocked</returns>
        public bool CheckBlockedCard(string cardNumber)
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
                    command.CommandText = "SELECT Blocked FROM Card WHERE CardNumber = @CardNumber";
                    command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;

                    try
                    {
                        return (Convert.ToBoolean(command.ExecuteScalar()));
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
        /// Removes wrong tries on the card if the last mistake happened more than 30 minutes ago.
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        public void RemoveOldPinMistakes(string cardNumber)
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
                }

                bool removeBadTries = false;

                using (SqlCommand commandGetDateTimeMistake = connection.CreateCommand())
                {
                    commandGetDateTimeMistake.CommandText = "SELECT " +
                        "CASE " +
                            "WHEN (SELECT DATEDIFF(MINUTE, (SELECT LastWrongTry FROM Card WHERE CardNumber = @cardNumber), GETDATE())) > 30 THEN 1 " +
                            "ELSE 0 " +
                        "END";

                    commandGetDateTimeMistake.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;

                    try
                    {
                        removeBadTries = (Convert.ToBoolean(commandGetDateTimeMistake.ExecuteScalar()));
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                    }

                    if (removeBadTries)
                    {
                        using (SqlCommand commandRemoveOldMistakes = connection.CreateCommand())
                        {
                            commandRemoveOldMistakes.CommandText = "UPDATE Card SET Tries = 0 WHERE CardNumber = @CardNumber";
                            commandRemoveOldMistakes.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;

                            try
                            {
                                commandRemoveOldMistakes.ExecuteScalar();
                            }
                            catch (SqlException e)
                            {
                                Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                                Debug.WriteLine(e.ToString());
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method that checks how many wrong PIN tries the user has had with his card
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        /// <returns></returns>
        public int CheckTries(string cardNumber)
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
                    return -1;
                }

                using (SqlCommand commandUpdate = connection.CreateCommand())
                {
                    commandUpdate.CommandText = "UPDATE Card SET Tries = (Tries+1) WHERE CardNumber = @cardNumber " +
                                                "UPDATE Card SET LastWrongTry = GETDATE() WHERE CardNumber = @cardNumber ";
                    commandUpdate.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;

                    try
                    {
                        commandUpdate.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return -1;
                    }

                    using (SqlCommand commandReturnValue = connection.CreateCommand())
                    {
                        commandReturnValue.CommandText = "SELECT Tries FROM Card WHERE CardNumber = @CardNumber";
                        commandReturnValue.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;

                        try
                        {
                            return (Convert.ToInt32(commandReturnValue.ExecuteScalar()));
                        }
                        catch (SqlException e)
                        {
                            Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                            Debug.WriteLine(e.ToString());
                            return -2;
                        }

                    }

                }



            }
        }

        /// <summary>
        /// Validates the card - checks whether it is valid, whether the PIN matches and if the card is blocked
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        /// <param name="hashedPin">The MD5 hashed version of the PIN code</param>
        /// <returns>Returns true if the card passes all checks</returns>
        public bool CheckCard(string cardNumber, string hashedPin)
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
                    command.CommandText = "SELECT " +
                        "(CASE " +
                        "WHEN PinHash = @PinHash " +
                        "THEN 1 " +
                        "ELSE 0 " +
                        "END) " +
                        "FROM Card " +
                        "WHERE CardNumber = @CardNumber " +
                        "AND GETDATE() > Card.ValidFrom " +
                        "AND GETDATE() < Card.ValidUntil " +
                        "AND Card.Blocked = 0";

                    command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;
                    command.Parameters.Add("@PinHash", SqlDbType.NVarChar).Value = hashedPin;

                    try
                    {
                        int resultOfQuery = Convert.ToInt32(command.ExecuteScalar());

                        if (resultOfQuery == 1)
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

        /// <summary>
        /// Function for adding new cards to the database.
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        /// <param name="hashedPin">The MD5 hashed PIN number</param>
        /// <param name="pin">The plaintext pin number >>>>>>THIS NEEDS TO BE REMOVED AFTER TESTING IS DONE <<<<<< </param>
        /// <param name="accountID">The IBAN identifier of the account to which the card will belong </param>
        /// <returns>Returns true if the card has been added successfully</returns>
        public bool AddCard(string cardNumber, string hashedPin, string pin, string accountID)
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
                    command.CommandText = "INSERT INTO Card " +
                        "VALUES (@cardNumber,@hashedPin,GETDATE(),(SELECT DATEADD(YEAR,3,GETDATE())),0,@accountID,@pin,0,GETDATE())";
                    command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;
                    command.Parameters.Add("@hashedPin", SqlDbType.NVarChar).Value = hashedPin;
                    command.Parameters.Add("@accountID", SqlDbType.NVarChar).Value = accountID;
                    command.Parameters.Add("@pin", SqlDbType.NVarChar).Value = pin;


                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
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

        /// <summary>
        /// Function for getting all cards connected to a given account
        /// </summary>
        /// <param name="iban">IBAN of the account</param>
        /// <returns>DataSet with cards belonging to the account</returns>
        public DataSet GetCards(string iban)
        {
            DataSet datasetCards = new DataSet();


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
                    return datasetCards;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT CardNumber,ValidUntil,Blocked FROM Card WHERE AccountID = @IBAN";
                    command.Parameters.Add("@IBAN", SqlDbType.NVarChar).Value = iban;


                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(datasetCards, "Cards");
                        return datasetCards;
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return datasetCards;
                    }

                }
            }
        }

        /// <summary>
        /// Function for checking how much money is in the account which the card is connected to
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        /// <returns>A sum of money at the client's disposal</returns>
        public decimal CheckBalance(string cardNumber)
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
                    return -99999;
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Balance " +
                        "FROM Card as C " +
                        "LEFT JOIN Account as A ON C.AccountID = A.IBAN " +
                        "WHERE CardNumber = @CardNumber;";

                    command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;

                    try
                    {
                        return Convert.ToDecimal(command.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return -99999;
                    }


                }
            }
        }

        /// <summary>
        /// Function for withdrawing money from the account connected to this card.
        /// </summary>
        /// <param name="amount">Ammount to be withdrawn</param>
        /// <param name="cardNumber">The number of the card</param>
        /// <returns>True if the withdrawal goes through successfully</returns>
        public bool Withdraw(decimal amount, string cardNumber)
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
                    command.CommandText =
                        "UPDATE Account SET Balance=Balance-@Amount " +
                        "WHERE IBAN =(" +
                            "SELECT Card.AccountID " +
                            "FROM Card " +
                            "WHERE CardNumber = @CardNumber) " +
                        "AND Balance+DebtLimit >= @Amount; "; // +

                    //"UPDATE Account SET Balance=Balance+@Amount " +
                    //"WHERE IBAN = @MasterAccount;";

                    command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                    command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;
                    //command.Parameters.Add("@MasterAccount", SqlDbType.NVarChar).Value = ServerSettings.MasterAccount;

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            using (SqlCommand command2 = connection.CreateCommand())
                            {
                                command2.CommandText = "UPDATE Account SET Balance=Balance+@Amount " +
                                "WHERE IBAN = @MasterAccount;";

                                command2.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                                command.Parameters.Add("@MasterAccount", SqlDbType.NVarChar).Value = ServerSettings.MasterAccount;
                                if (command.ExecuteNonQuery() > 0)
                                {
                                    return (new TransactionRepository().NewATMWithdrawal(amount, cardNumber));
                                }
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return false;
                    }

                    return false;
                }
            }
        }

        /// <summary>
        /// Function for setting the new pin code
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        /// <param name="hashedPin">New MD5 hashed version of the new PIN number</param>
        /// <param name="newPin">The plaintext pin number >>>>>>THIS NEEDS TO BE REMOVED AFTER TESTING IS DONE <<<<<<</param>
        /// <returns>True if the new pin was set successfully</returns>
        public bool SetNewPin(string cardNumber, string hashedPin, string newPin)
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
                    command.CommandText = "UPDATE Card SET PINHash = @HashedPin, Hint = @Pin WHERE CardNumber = @CardNumber";
                    command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;
                    command.Parameters.Add("@hashedPin", SqlDbType.NVarChar).Value = hashedPin;
                    command.Parameters.Add("@pin", SqlDbType.NVarChar).Value = newPin;

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
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

        /// <summary>
        /// Function that blocks the card
        /// </summary>
        /// <param name="cardNumber">The number of the card</param>
        /// <returns>True if the card was blocked</returns>
        public bool BlockCard(string cardNumber)
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
                    command.CommandText = "UPDATE Card SET Blocked = 1 WHERE CardNumber = @CardNumber";
                    command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
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

        /// <summary>
        /// Function to block all cards related to the given account
        /// </summary>
        /// <param name="iban">IBAN of the account</param>
        /// <returns>Returns true if all cards were blocked successfully</returns>
        public bool BlockAllCards(string iban)
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
                    command.CommandText = "UPDATE Card SET Blocked = 1 WHERE AccountID = @AccountID";
                    command.Parameters.Add("@AccountID", SqlDbType.NVarChar).Value = iban;

                    try
                    {
                        if (command.ExecuteNonQuery() >= 0)
                        {
                            return true;
                        }
                        else
                        {
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

        /// <summary>
        /// Function to unblock a card
        /// </summary>
        /// <param name="cardNumber">Card number</param>
        /// <returns>Returns true if the card was unblocked successfully</returns>
        public bool UnblockCard(string cardNumber)
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
                    command.CommandText = "UPDATE Card SET Blocked = 0 WHERE CardNumber = @CardNumber " +
                                          "UPDATE Card SET Tries = 0 WHERE CardNumber = @CardNumber; ";
                    command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
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
}

