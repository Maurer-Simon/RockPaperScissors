using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to rock, paper, scissors!");

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or 's' for scissors!");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player won!");
                            playerScore++;
                            break;
                        case "s":
                            Console.WriteLine("Enemy won!");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy won!");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");;
                            break;
                        case "s":
                            Console.WriteLine("Player won!");
                            playerScore++;
                            break;
                    }
                }
                else if (enemyChoice == 2)
                {
                    Console.WriteLine("Enemy chooses scissors.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player won!");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy won!");
                            enemyScore++;
                            break;
                        case "s":
                            Console.WriteLine("Tie!");
                            break;
                    } 
                }
            }
            if (playerScore == 3)
            {
                Console.WriteLine("\nPlayer score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("You won the game!");
            }
            else 
            {
                Console.WriteLine("\nPlayer score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("Enemy won the game!");
            }
            Console.ReadKey();
        }
    }
}
