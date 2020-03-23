using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            string[] input = new string[n];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }

            foreach (var item in input)
            {
                item.Split(Convert.ToChar(" "));
            }





            foreach (KeyValuePair<string, string> entry in phoneBook)
            {
                
            }

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string phoneNumber = Console.ReadLine();

                phoneBook.Add(name, phoneNumber);
            }

            while (true)
            {
                var s = Console.ReadLine();
                foreach (KeyValuePair<string, string> entry in phoneBook)
                {
                    if (phoneBook.ContainsKey(s))
                    {
                        Console.WriteLine(entry.Key + "=" + entry.Value);
                    }
                    else
                    {
                        Console.WriteLine("Not found");
                    }
                }
            }






        }
    }
}


