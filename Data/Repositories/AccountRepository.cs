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
                    command.CommandText = "select C.LastName, C.FirstName,  A.* from Client AS C LEFT JOIN Account AS A ON C.Client_ID = A.OwnerID ORDER BY C.LastName, C.FirstName";
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
    }
}
