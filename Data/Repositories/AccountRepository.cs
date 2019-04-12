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
        public static string ServerName { get; set; } = @"TRANSFORMER10\SQLEXPRESS2017";
        public static string DatabaseName { get; set; } = "TransformerBank";
        public static string ConnString { get; set; } = $"Server={ServerName}; Database = {DatabaseName}; Trusted_Connection = True";

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
                            Debug.WriteLine("Person Added");
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
    }
}
