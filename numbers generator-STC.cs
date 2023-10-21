using System;
class Program {
    static void Main()
    {       
            Random random = new Random();
            string countryCode = "050";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("[+] 10");
            Console.WriteLine("[+] 50");
            Console.WriteLine("[+] 100");
            Console.WriteLine("[+] 500");
            Console.WriteLine("[+] 1000");
            Console.WriteLine("[+] 50000");
            Console.Write("Choose number : ");
            string input = Console.ReadLine();
            if (input == "10")
            {
                for (int i = 0; i < 10; i++)
                {
                    string phoneNumber = countryCode;
                    for (int j = 0; j < 7; j++)
                    {
                        phoneNumber += random.Next(0, 10).ToString();
                    }
                    Console.WriteLine(phoneNumber);
                }
            }
            if (input == "50")
            {
                for (int i = 0; i < 50; i++)
                {
                    string phoneNumber = countryCode;
                    for (int j = 0; j < 7; j++)
                    {
                        phoneNumber += random.Next(0, 10).ToString();
                    }
                    Console.WriteLine(phoneNumber);
                }
            }
            if (input == "100")
            {
                for (int i = 0; i < 100; i++)
                {
                    string phoneNumber = countryCode;

                    for (int j = 0; j < 7; j++)
                    {
                        phoneNumber += random.Next(0, 10).ToString();
                    }
                    Console.WriteLine(phoneNumber);
                }
            }
            if (input == "500")
            {
                for (int i = 0; i < 500; i++)
                {
                    string phoneNumber = countryCode;
                    for (int j = 0; j < 7; j++)
                    {
                        phoneNumber += random.Next(0, 10).ToString();
                    }
                    Console.WriteLine(phoneNumber);
                }
            }
            if (input == "1000")
            {
                for (int i = 0; i < 1000; i++)
                {
                    string phoneNumber = countryCode;
                    for (int j = 0; j < 7; j++)
                    {
                        phoneNumber += random.Next(0, 10).ToString();
                    }
                    Console.WriteLine(phoneNumber);
                }
            }
            if (input == "5000")
            {
                for (int i = 0; i < 5000; i++)
                {
                    string phoneNumber = countryCode;
                    for (int j = 0; j < 7; j++)
                    {
                        phoneNumber += random.Next(0, 10).ToString();
                    }
                    Console.WriteLine(phoneNumber);
                }
                Console.ResetColor();
            }
    }
}



