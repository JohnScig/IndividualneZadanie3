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
        public static string ServerName { get; set; } = @"TRANSFORMER10\SQLEXPRESS2017";
        public static string DatabaseName { get; set; } = "TransformerBank";
        public static string ConnString { get; set; } = $"Server={ServerName}; Database = {DatabaseName}; Trusted_Connection = True";

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
