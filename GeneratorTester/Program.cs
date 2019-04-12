using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorTester
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPeopleGenerator();

            TestBankGenerator();

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
            foreach (string s in new Generator().GetRandomBanks(5))
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
    }
}
