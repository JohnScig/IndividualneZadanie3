using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repositories
{
    public class ClientRepository
    {
        //public static string ServerName { get; set; } = ServerSettings.ServerName;
        //public static string DatabaseName { get; set; } = ServerSettings.DatabaseName;
        public static string ConnString { get; set; } = $"Server={ServerSettings.ServerName}; Database = {ServerSettings.DatabaseName}; Trusted_Connection = True";

        public int AddClient(ClientModel clientModel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO Client (LastName,FirstName,DateOfBirth,PersonalID,PhoneNumber,Email,StreetName,PostalCode,City) " +
                            "VALUES (@LastName,@FirstName,@DateOfBirth,@PersonalID,@PhoneNumber,@Email,@StreetName,@PostalCode,@City)";
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = clientModel.LastName;
                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = clientModel.FirstName;
                        command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime2).Value = clientModel.DateOfBirth;
                        command.Parameters.Add("@PersonalID", SqlDbType.NVarChar).Value = clientModel.PersonalID;
                        command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = clientModel.PhoneNumber;
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = clientModel.Email;
                        command.Parameters.Add("@StreetName", SqlDbType.NVarChar).Value = clientModel.Street;
                        command.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = clientModel.PostalCode;
                        command.Parameters.Add("@City", SqlDbType.NVarChar).Value = clientModel.City;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            Debug.WriteLine("Person Added");
                            using (SqlCommand command2 = connection.CreateCommand())
                            {
                                command2.CommandText = "SELECT @@Identity";
                                return Convert.ToInt32(command2.ExecuteScalar());
                            }
                        }
                    }
                }
                return 0;
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.ToString());
                return 0;
            }
        }

        public bool EditClient(string personalID, ClientModel clientModel)
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
                    command.CommandText = "UPDATE Client " +
                        "SET " +
                        "FirstName = @FirstName," +
                        "LastName = @LastName," +
                        " DateOfBirth = @DateOfBirth," +
                        "PersonalID = @PersonalID," +
                        "PhoneNumber = @PhoneNumber," +
                        "Email = @Email," +
                        "StreetName = @StreetName," +
                        "PostalCode = @PostalCode," +
                        "City = @City " +
                        "WHERE PersonalID = @IDToEdit; ";
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = clientModel.LastName;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = clientModel.FirstName;
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime2).Value = clientModel.DateOfBirth;
                    command.Parameters.Add("@PersonalID", SqlDbType.NVarChar).Value = clientModel.PersonalID;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = clientModel.PhoneNumber;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = clientModel.Email;
                    command.Parameters.Add("@StreetName", SqlDbType.NVarChar).Value = clientModel.Street;
                    command.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = clientModel.PostalCode;
                    command.Parameters.Add("@City", SqlDbType.NVarChar).Value = clientModel.City;
                    command.Parameters.Add("@IDToEdit", SqlDbType.NVarChar).Value = personalID;

                    try
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            Debug.WriteLine("Person edited");
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

        public int CheckClientExistence(string personalID)
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
                    return 0;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Client_ID FROM Client WHERE Client.PersonalID = @PersonalID";
                    command.Parameters.Add("@PersonalID", SqlDbType.NVarChar).Value = personalID;

                    try
                    {
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return 0;
                    }


                }
            }
        }

        public List<string> GetBasicInfo(string personalID)
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
                    command.CommandText = "SELECT Client_ID,FirstName,LastName,DateOfBirth FROM Client WHERE PersonalID=@PersonalID";
                    command.Parameters.Add("@personalID", SqlDbType.NVarChar).Value = personalID;

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                basicInfo.Add(reader.GetInt32(0).ToString());
                                basicInfo.Add(reader.GetString(1));
                                basicInfo.Add(reader.GetString(2));
                                basicInfo.Add(personalID);
                                basicInfo.Add(reader.GetDateTime(3).Year.ToString() + '.' + reader.GetDateTime(3).Month.ToString() + '.' + reader.GetDateTime(3).Day.ToString());
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

        public ClientModel GetClient(string personalID)
        {
            ClientModel client = new ClientModel();
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
                    return client;
                }

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM Client WHERE PersonalID=@PersonalID";
                    command.Parameters.Add("@personalID", SqlDbType.NVarChar).Value = personalID;

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                client.LastName = reader.GetString(1);
                                client.FirstName = reader.GetString(2);
                                client.DateOfBirth = reader.GetDateTime(3);
                                client.PersonalID = reader.GetString(4);
                                client.PhoneNumber = reader.GetString(5);
                                client.Email = reader.GetString(6);
                                client.Street = reader.GetString(7);
                                client.PostalCode = reader.GetString(8);
                                client.City = reader.GetString(9);
                            }
                            return client;

                        }
                    }
                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return client;
                    }


                }
            }
        }
    }
}


