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
    }
}

/*
        public static void AddPerson(string title, string firstName, string middleName, string lastName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnString))
                {
                    
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"INSERT INTO Person.BusinessEntity (rowguid,ModifiedDate) VALUES (@myGuid,@ModifiedDate)";
                        command.Parameters.Add("@myGuid", SqlDbType.UniqueIdentifier).Value = myGuid;
                        command.Parameters.Add("@ModifiedDate", SqlDbType.DateTime).Value = modifiedDate;
                        command.ExecuteNonQuery();
                        MessageBox.Show("success");

                    }

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"SELECT MAX(BusinessEntityID) FROM Person.BusinessEntity";
                        newID = Convert.ToInt32(command.ExecuteScalar());
                        MessageBox.Show(newID.ToString());
                    }

                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"INSERT INTO Person.Person (BusinessEntityID, PersonType, NameStyle, Title, FirstName, MiddleName, LastName, EmailPromotion, rowguid, ModifiedDate) " +
                            $"VALUES (@businessEntityID, @personType, @nameStyle, @title, @firstName, @middleName, @lastName, @emailPromotion, @rowguid, @modifiedDate)";
                        command.Parameters.Add("@businessEntityID", SqlDbType.Int).Value = newID;
                        command.Parameters.Add("@personType", SqlDbType.NVarChar).Value = "EM";
                        command.Parameters.Add("@nameStyle", SqlDbType.Bit).Value = 0;
                        command.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
                        command.Parameters.Add("@firstName", SqlDbType.NVarChar).Value = firstName;
                        command.Parameters.Add("@middleName", SqlDbType.NVarChar).Value = middleName;
                        command.Parameters.Add("@lastName", SqlDbType.NVarChar).Value = lastName;
                        command.Parameters.Add("@emailPromotion", SqlDbType.Int).Value = 0;
                        command.Parameters.Add("@rowguid", SqlDbType.UniqueIdentifier).Value = myGuid;
                        command.Parameters.Add("@modifiedDate", SqlDbType.Date).Value = modifiedDate;

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("BIG SUCCESS");
                        }
                        else
                        {
                            MessageBox.Show("shit's all fucked up brah");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
 * */
