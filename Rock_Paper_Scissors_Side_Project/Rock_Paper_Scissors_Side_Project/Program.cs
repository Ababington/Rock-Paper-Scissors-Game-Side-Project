using System;
using System.IO;

namespace Rock_Paper_Scissors_Side_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerOne;
            string playerCpu;

            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int playerScore = 0;
                int cpuScore = 0;
                Console.WriteLine("    ***ROCK, PAPER, SCISSORS*** ");
                Console.WriteLine("====================================");
                Console.WriteLine("      -best to 3 points wins-");
                Console.WriteLine("====================================");
                while (playerScore < 3 && cpuScore < 3)
                {
                    try
                    {
                       
                        Console.WriteLine("  Choose ROCK, PAPER, or SCISSORS: ");
                        Console.WriteLine();
                        playerOne = Console.ReadLine();
                        playerOne = playerOne.ToUpper();
                        Console.WriteLine();

                        Random random = new Random();
                        randomInt = random.Next(1, 4);

                        switch (randomInt)
                        {
                            case 1:
                                playerCpu = "ROCK";
                                Console.WriteLine("Computer chose ROCK");
                                Console.WriteLine();
                                if (playerOne == "ROCK")
                                {
                                    Console.WriteLine("-DRAW-");
                                }
                                else if (playerOne == "PAPER")
                                {
                                    Console.WriteLine("-Player One WINS-");
                                    playerScore++;
                                }
                                else if (playerOne == "SCISSORS")
                                {
                                    Console.WriteLine("-Computer WINS-");
                                    cpuScore++;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                                break;

                            case 2:
                                playerCpu = "PAPER";
                                Console.WriteLine("Computer chose PAPER");
                                Console.WriteLine();
                                if (playerOne == "PAPER")
                                {
                                    Console.WriteLine("-DRAW-");
                                }
                                else if (playerOne == "SCISSORS")
                                {
                                    Console.WriteLine("-Player One WINS-");
                                    playerScore++;
                                }
                                else if (playerOne == "ROCK")
                                {
                                    Console.WriteLine("-Computer WINS-");
                                    cpuScore++;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                                break;

                            case 3:
                                playerCpu = "SCISSORS";
                                Console.WriteLine("Computer chose SCISSORS");
                                Console.WriteLine();
                                if (playerOne == "SCISSORS")
                                {
                                    Console.WriteLine("-DRAW-");
                                }
                                else if (playerOne == "ROCK")
                                {
                                    Console.WriteLine("-Player One WINS-");
                                    playerScore++;
                                }
                                else if (playerOne == "PAPER")
                                {
                                    Console.WriteLine("-Computer WINS-");
                                    cpuScore++;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                                break;

                            default:
                                Console.WriteLine("*** Please enter valid choice! ROCK, PAPER, or SCISSORS:  ");
                                Console.WriteLine();
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("*** Please enter valid choice! ROCK, PAPER, or SCISSORS: ");
                        Console.WriteLine();
                    }
                    Console.WriteLine("==================================");
                    Console.WriteLine($"SCORES: PLAYER ONE: {playerScore} COMPUTER: {cpuScore}");
                    Console.WriteLine("==================================");
                    Console.WriteLine();

                }

                if (playerScore == 3)
                {
                    Console.WriteLine("*** YOU WON ***");
                    Console.WriteLine();
                }
                else if (cpuScore == 3)
                {
                    Console.WriteLine("*** COMPUTER WON ***");
                    Console.WriteLine();
                }

                Console.WriteLine("Play Again? (y/n): ");
                string choice = Console.ReadLine();
                choice = choice.ToLower();
                if (choice == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (choice == "n")
                {
                    playAgain = false;
                }
            }

        }
    }
}
