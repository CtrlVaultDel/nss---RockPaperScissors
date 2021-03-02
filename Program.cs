using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            // Variable initialization
            int playerScore = 0;
            int computerScore = 0;
            int userThrow;
            int computerThrow;
            Random rand = new Random();

            // ASCII art for Rock
            void Rock()
            {
                Console.WriteLine(@"
                  ----ROCK----
                        _______
                    ---'   ____)
                        (_____)
                        (_____)
                        (____)
                    ---._(___)
                ");
            }

            // ASCII art for Paper
            void Paper()
            {
                Console.WriteLine(@"
                  ----PAPER----
                        _______
                    ---'   ____)__
                            ______)
                            _______)
                            _______)
                    ---.__________)
                ");
            }

            // ASCII art for Scissors
            void Scissors()
            {
                Console.WriteLine(@"
                  ----SCISSORS----
                        _______
                    ---'   ____)__
                            ______)
                        __________)
                        (____)
                    ---.__(___)
                ");
            }

            // Converts number to ASCII image (Rock, Paper, Scissors)
            void TranslateThrow(int throwNumber)
            {
                switch (throwNumber)
                {
                    case 1:
                        Rock();
                        break;
                    case 2:
                        Paper();
                        break;
                    case 3:
                        Scissors();
                        break;
                }
            }

            // Called when the human wins a round
            void PlayerWin()
            {
                Console.WriteLine("Player Wins!");
                playerScore++;
            }

            // Called when the computer wins a round
            void ComputerWin()
            {
                Console.WriteLine("Computer Wins!");
                computerScore++;
            }

            while (playerScore != 4 && computerScore != 4)
            {
                // Computer's next throw
                computerThrow = rand.Next(1, 4);

                // Basic scores message
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"| Player: {playerScore}  |  Computer: {computerScore} |");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("What would you like to throw?");
                Console.WriteLine("1) Rock");
                Console.WriteLine("2) Paper");
                Console.WriteLine("3) Scissors");

                // Capture user's throw
                string response = Console.ReadLine();

                bool properNumber = Int32.TryParse(response, out userThrow);
                if (properNumber && userThrow >= 1 && userThrow <= 3)
                {
                    Console.WriteLine("                     (You)");
                    TranslateThrow(userThrow);
                    Console.WriteLine("VS");
                    Console.WriteLine("                   (Computer)");
                    TranslateThrow(computerThrow);

                    // Test to see if the Player and Computer chose the same option
                    if (userThrow == computerThrow)
                    {
                        Console.WriteLine("Tie!");
                    }

                    // If it was not a tie, see who won
                    else
                    {
                        switch (userThrow)
                        {
                            case 1:
                                // Player: Rock && Computer: Paper
                                if (computerThrow == 2)
                                {
                                    ComputerWin();
                                }

                                // Player: Rock && Computer: Scissors
                                else
                                {
                                    PlayerWin();
                                }
                                break;
                            case 2:
                                // Player: Paper && Computer: Rock
                                if (computerThrow == 1)
                                {
                                    PlayerWin();
                                }

                                // Player: Paper && Computer: Scissors
                                else
                                {
                                    ComputerWin();
                                }
                                break;
                            case 3:
                                // Player: Scissors && Computer: Rock
                                if (computerThrow == 1)
                                {
                                    ComputerWin();
                                }

                                // Player: Scissors && Computer: Paper
                                else
                                {
                                    PlayerWin();
                                }
                                break;
                        }
                    }
                    // Let user see the outcome and click enter to continue
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please enter a proper number [1-3]");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (playerScore == 4)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Try again?");
            }
        }
    }
}
