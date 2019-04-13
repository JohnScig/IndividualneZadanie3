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
        public static string ConnString { get; set; } = $"Server={ServerSettings.ServerName}; Database = {ServerSettings.DatabaseName}; Trusted_Connection = True";


        //private CardModel cardModel = new CardModel();

        public bool CheckCard(string cardNumber, string hashedPin)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    connection.Open();

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

                        int resultOfQuery = Convert.ToInt32(command.ExecuteScalar());

                        if (resultOfQuery == 1)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

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
                        "VALUES (@cardNumber,@hashedPin,GETDATE(),(SELECT DATEADD(YEAR,3,GETDATE())),0,@accountID,@pin)";
                    command.Parameters.Add("@cardNumber", SqlDbType.NVarChar).Value = cardNumber;
                    command.Parameters.Add("@hashedPin", SqlDbType.NVarChar).Value = hashedPin;
                    command.Parameters.Add("@accountID", SqlDbType.NVarChar).Value = accountID;
                    command.Parameters.Add("@pin", SqlDbType.NVarChar).Value = pin;


                    try
                    {
                        if (command.ExecuteNonQuery()>0)
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

        public decimal CheckBalance(string cardNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT Balance " +
                            "FROM Card as C " +
                            "LEFT JOIN Account as A ON C.AccountID = A.IBAN " +
                            "WHERE CardNumber = @CardNumber;";

                        command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;

                        return Convert.ToDecimal(command.ExecuteScalar());

                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return 0;
            }
        }

        public bool Withdraw(decimal amount, string cardNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    connection.Open();

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "UPDATE Account SET Balance=Balance-@Amount " +
                            "WHERE IBAN =(" +
                                "SELECT Card.AccountID " +
                                "FROM Card " +
                                "WHERE CardNumber = @CardNumber) " +
                            "AND Balance >= @Amount;";

                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;

                        if (command.ExecuteNonQuery() > 0)
                        {

                            return (new TransactionRepository().NewATMWithdrawal(amount, cardNumber));
                        }

                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
        }

        public bool SetNewPin(string cardNumber,string hashedPin, string newPin)
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
                    command.CommandText = "UPDATE Card SET Blocked = 0 WHERE CardNumber = @CardNumber";
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

