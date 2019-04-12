﻿using System;
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
        public static string ServerName { get; set; } = @"TRANSFORMER10\SQLEXPRESS2017";
        public static string DatabaseName { get; set; } = "TransformerBank";
        public static string ConnString { get; set; } = $"Server={ServerName}; Database = {DatabaseName}; Trusted_Connection = True";

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
                            "AND Balance >= 500;";

                        command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                        command.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            using (SqlCommand commandTransaction = connection.CreateCommand())
                            {

                                commandTransaction.CommandText = "INSERT INTO Transactions (FromAccount, ToAccount, Amount, Timestamp) " +
                                                                "VALUES ((SELECT Card.AccountID FROM Card WHERE CardNumber = @CardNumber), @ToAccount, @Amount, @Timestamp)";
                                commandTransaction.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = cardNumber;
                                commandTransaction.Parameters.Add("@ToAccount", SqlDbType.NVarChar).Value = "SK8699990000009999999999";
                                commandTransaction.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                                commandTransaction.Parameters.Add("@Timestamp", SqlDbType.DateTime2).Value = DateTime.Now;
                                commandTransaction.ExecuteNonQuery();
                            }
                            return true;
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
    }
}
    