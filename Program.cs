using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable initialization
            int PlayerScore = 0;
            int ComputerScore = 0;
            Random rand = new Random();

            // Computer's next throw
            rand.Next(1, 4);

            // Basic scores message
            Console.WriteLine("-----------------------------");
            Console.WriteLine($" | Player: {PlayerScore}  |  Computer: {ComputerScore} |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");

            // Capture user's throw
            string Response = Console.ReadLine();
        }

        // ASCII art for Rock
        public void Rock()
        {
            Console.WriteLine(@"
                    _______
                ---'   ____)
                    (_____)
                    (_____)
                    (____)
                ---._(___)
            ");
        }

        // ASCII art for Paper
        public void Paper()
        {
            Console.WriteLine(@"
                    _______
                ---'   ____)__
                        ______)
                        _______)
                        _______)
                ---.__________)
            ");
        }

        // ASCII art for Scissors
        public void Scissors()
        {
            Console.WriteLine(@"
                    _______
                ---'   ____)__
                        ______)
                      __________)
                    (____)
                ---.__(___)
            ");
        }
    }
}
