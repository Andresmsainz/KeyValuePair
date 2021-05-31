using System;
using System.Collections.Generic;


namespace KeyValuePairApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Key Value Pairs!");

            Console.WriteLine("Creating");
            var capitals = new List<KeyValuePair<string,string>>();
            Console.WriteLine("--------");

            Console.WriteLine("Adding");
            capitals.Add(new KeyValuePair<string, string>("Russia", "Moscow"));
            capitals.Add(new KeyValuePair<string, string>("Sweden", "Stockholm"));
            capitals.Add(new KeyValuePair<string, string>("Portugal", "Lisbon"));
            capitals.Add(new KeyValuePair<string, string>("Japan", "Tokyo"));
            Console.WriteLine("--------");

            foreach (var item in capitals)
            {
                Console.WriteLine("Item = " + item);
            }
            Console.WriteLine("Removing Index 1 (Sweden)");
            capitals.RemoveAt(1);

            foreach (var item in capitals)
            {
                Console.WriteLine("Item = " + item);
            }
            Console.WriteLine("--------");

            Console.WriteLine("Calling GetFirstAndLastName Function");
            Console.WriteLine("Name = " + GetFirstAndLastName());
            Console.WriteLine("--------");
        }

        public static KeyValuePair<string,string> GetFirstAndLastName()
        {
            string firstName = "Ahmad";
            string lastName = "Mohey";

            return new KeyValuePair<string, string>(firstName,lastName);
        }
    }
}
