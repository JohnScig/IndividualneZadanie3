using Controls;
using Data.Repositories;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorTester
{
    class GeneratorTester
    {
        static void Main(string[] args)
        {
            //new GeneratorTester().TestAddingPeople();
            TestPeopleGenerator();
            TestAddressGenerator();
            

        }

        public static void TestPeopleGenerator()
        {
            foreach (string s in new Generator().GetRandomPeople(5))
            {
                Console.WriteLine(s);

            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void TestBankGenerator()
        {
            foreach (string s in new Generator().GetRandomBanks(50))
            {
                Console.WriteLine(s);

            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void TestAddressGenerator()
        {
            foreach (string s in new Generator().GetRandomAddresses(5))
            {
                Console.WriteLine(s);

            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public void TestAddingPeople()
        {
            ClientRepository clientRepository = new ClientRepository();

            string generatedClient = new Generator().GetRandomPeople(1).ToList()[0];
            string generatedAddress = new Generator().GetRandomAddresses(1).ToList()[0];


            string[] parsedPerson = generatedClient.Split(';');
            string[] parsedAddress = generatedAddress.Split(';');

            //string[] parsedDate = parsedPerson[2].Split('.');
            //DateTime myDateOfBirth = new DateTime(Convert.ToInt32(parsedDate[2]), Convert.ToInt32(parsedDate[1]), Convert.ToInt32(parsedDate[0]));

            ClientModel clientModel = new ClientModel()
            {
                LastName = parsedPerson[0],
                FirstName = parsedPerson[1],
                //DateOfBirth = myDateOfBirth,
                PersonalID = parsedPerson[3].Replace(" ", String.Empty),
                PhoneNumber = parsedPerson[4].Replace(" ", String.Empty),
                Email = parsedPerson[5],
                Street = parsedAddress[0],
                PostalCode = parsedAddress[1].Replace(" ", String.Empty),
                City = parsedAddress[2]
            };
            clientRepository.AddClient(clientModel);
        }

 



    }



}


/*
 *  Vnímavý;Ernest;21.05.1988;KE 447 753;0905 801 012;Vnimavy_Ernest@seznam.cz
    Gaštanová 92;023 11;U Kordišov
 * */
