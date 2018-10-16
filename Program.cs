using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GuessTheNumberGame

{
    class Program
    {
        static void Main()
        {
            int playerGuess;
            string playerInput;
            bool isNumberGuessed = false;
            int theAnswer;
            int firstRun = 0;
            int textColour = 0;
            Random rng = new Random();
            theAnswer = rng.Next(1, 21);

            do
            {
                if (textColour == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else if (textColour == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                else if (textColour == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (textColour == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (textColour == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (textColour == 5)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (textColour == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (textColour == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (textColour == 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (textColour == 9)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (textColour == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (textColour == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (textColour == 11)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (textColour == 12)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                if (firstRun == 0 && isNumberGuessed == false)
                {
                    Console.WriteLine("Welcome to the magical guessing game!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Guess the number between 0 and 20");
                    firstRun = 1;
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write("Enter your guess: ");
                    playerInput = Console.ReadLine();

                    playerGuess = int.Parse(playerInput);

                    if (playerGuess == theAnswer)
                    {
                        Console.Clear();

                        Console.WriteLine("");
                        Console.Write("You got it ");
                        Console.Write(playerGuess);
                        Console.Write(" is correct!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Press the 'Any' key to start again");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ReadKey();
                        firstRun = 0;
                        textColour = 0;

                        Console.Clear();

                    }

                    else
                    {
                        if (playerGuess > 20)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Guess between 0 and 20 remember?");
                            textColour = textColour + 1;
                        }

                        else if (playerGuess > theAnswer && theAnswer < 21)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Too high!");
                            textColour = textColour + 1;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Too low!");
                            textColour = textColour + 1;
                        }
                    }

                }
            }

            while (!isNumberGuessed);
            {
            }
        }
    }
}