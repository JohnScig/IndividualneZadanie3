using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Controls;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    /// <summary>
    /// Class for generating a randomized person as a ClientModel
    /// </summary>
    public class ClientGenerator
    {
        /// <summary>
        /// This method returns a randomized person as a ClientModel. It uses the random generators of people and addresses from the Support DLL.
        /// Date of Birth is correctly parsed into a DateTime type.
        /// </summary>
        /// <returns>An object of ClientModel type representing a random person</returns>
        public ClientModel GeneratePerson()
        {
            string generatedClient = new Generator().GetRandomPeople(1).ToList()[0];
            string generatedAddress = new Generator().GetRandomAddresses(1).ToList()[0];

            string[] parsedPerson = generatedClient.Split(';');
            string[] parsedAddress = generatedAddress.Split(';');

            string[] parsedDate = parsedPerson[2].Split('.');
            DateTime myDateOfBirth = new DateTime(Convert.ToInt32(parsedDate[2]), Convert.ToInt32(parsedDate[1]), Convert.ToInt32(parsedDate[0]));

            ClientModel clientModel = new ClientModel()
            {
                LastName = parsedPerson[0],
                FirstName = parsedPerson[1],
                DateOfBirth = myDateOfBirth,
                PersonalID = parsedPerson[3].Replace(" ", String.Empty),
                PhoneNumber = parsedPerson[4].Replace(" ", String.Empty),
                Email = parsedPerson[5],
                Street = parsedAddress[0],
                PostalCode = parsedAddress[1].Replace(" ", String.Empty),
                City = parsedAddress[2]
            };
            return clientModel;
        }
    }
}
