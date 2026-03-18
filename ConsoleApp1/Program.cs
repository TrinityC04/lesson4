using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }



            //2.
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //3.
            string? userInput = null;
            while (string.IsNullOrWhiteSpace(userInput))
            {
                Console.Write("Enter username: ");
                userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput)) {
                    Console.WriteLine("Username is required!");
                }

            }
            Console.WriteLine($"Welcome: {userInput}");


            //4
            string? choice;

            do
            {
                Console.WriteLine("(P)lay \n (S)etting \n (Q)uit \n Choose: ");
                choice = Console.ReadLine()?.Trim().ToUpper();

                if (choice == "P")
                {
                    Console.WriteLine("Starting game...");
                }
                else if (choice == "S")
                {
                    Console.WriteLine("Opening settings...");
                }
                else if (choice == "Q")
                {
                    Console.WriteLine("Exiting...");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
            while (choice != "Q");

            //5
            int total = 0;
            int value;

            while (true)
            {
                value = ReadInt("Enter a number (0 to stop): ");

                if (value == 0)
                    break;

                total += value;
            }

            Console.WriteLine($"Total = {total}");

        }
        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                    return result;

                Console.WriteLine("Invalid integer. Try again...");
            }
        }

    }

}
