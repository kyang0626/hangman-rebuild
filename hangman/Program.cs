using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are playing Hangman!\nPress 'p' to play!");
            string userInput = Console.ReadLine();

            if (userInput == "p")
                playGame();
        }

        public static void playGame()
        {
            // the avengers
            int pointsOut = 7;
            int winningPoints = 0;
            List<string>lettersGuessed = new List<string>();
            bool playing = true;

            Console.WriteLine("\nhint: Fictional team of superheroes appearing in limited series comic books\npublished by Marvel Comics.\n");
            StringBuilder line1 = new StringBuilder("    _____   ");
            StringBuilder line2 = new StringBuilder("   |        ");
            StringBuilder line3 = new StringBuilder("   |        ");
            StringBuilder line4 = new StringBuilder("   |        ");
            StringBuilder line5 = new StringBuilder("   |        ");
            StringBuilder line6 = new StringBuilder("   |        ");
            StringBuilder line7 = new StringBuilder("   |        ");
            StringBuilder line8 = new StringBuilder("___|____    ");
            StringBuilder line9 = new StringBuilder("t__ a_______ ");
            
            while (playing == true)
            {
                Console.WriteLine(line1 + "\n" + line2 + "\n" + line3 + "\n" + line4 + "\n" + line5 + "\n" + line6 + "\n" + line7 + "\n" + line8 + "\n\n" + line9 + "\n");
                Console.WriteLine("winningPoint: " + winningPoints);
                Console.WriteLine("chancesLeft: " + pointsOut + "\n");
                Console.WriteLine("Pick a letter");
                string userInput = Console.ReadLine();
                if (userInput == "v" || userInput == "e" || userInput == "n" || userInput == "g" || userInput == "s" || userInput == "h" || userInput == "r")
                {
                    if (userInput == "h")
                    {
                        line9.Remove(1, 1);
                        line9.Insert(1, "h");

                        Console.WriteLine("\n" + line9);
                    }
                    else if (userInput == "e")
                    {
                        line9.Remove(2, 1);
                        line9.Remove(7, 1);
                        line9.Remove(9, 1);

                        line9.Insert(2, "e");
                        line9.Insert(6, "e");
                        line9.Insert(9, "e");

                        Console.WriteLine("\n" + line9);
                    }
                    else if (userInput == "v")
                    {
                        line9.Remove(5, 1);
                        line9.Insert(5, "v");

                        Console.WriteLine("\n" + line9);
                    }
                    else if (userInput == "n")
                    {
                        line9.Remove(7, 1);
                        line9.Insert(7, "n");

                        Console.WriteLine("\n" + line9);
                    }
                    else if (userInput == "g")
                    {
                        line9.Remove(8, 1);
                        line9.Insert(8, "g");

                        Console.WriteLine("\n" + line9);
                    }
                    else if (userInput == "r")
                    {
                        line9.Remove(10, 1);
                        line9.Insert(10, "r");

                        Console.WriteLine("\n" + line9);
                    }
                    else if (userInput == "s")
                    {
                        line9.Remove(11, 1);
                        line9.Insert(11, "s");

                        Console.WriteLine("\n" + line9);
                    }

                    Console.WriteLine("You have guessed the right letter!\n");
                    lettersGuessed.Add(userInput);
                    winningPoints += 1;

                    if (winningPoints == 7)
                    {
                        Console.WriteLine(line1 + "\n" + line2 + "\n" + line3 + "\n" + line4 + "\n" + line5 + "\n" + line6 + "\n" + line7 + "\n" + line8 + "\n\n" + line9 + "\n");
                        Console.WriteLine("CONGRATULATIONS!!!!! YOU WON!!");
                        Console.WriteLine("Press 'e' to exit");
                        string exit = Console.ReadLine();
                        if (exit == "e")
                        {
                            playing = false;
                        }
                    }

                }               
                else if (userInput == "t" || userInput == "a")
                {
                    Console.WriteLine("That letter was given. Please re-enter a new letter!\n");   
                }
                else if (userInput != "v" || userInput != "e" || userInput != "n" || userInput != "g" || userInput != "s" || userInput != "h" || userInput != "r")
                {
                    lettersGuessed.Add(userInput);
                    pointsOut-= 1;
                    Console.WriteLine("\nWrong letter! You have chosen " + userInput);
                    Console.WriteLine("You have " + pointsOut + " guesses left.\n");

                    if (pointsOut == 6)
                    {
                        line2.Insert(8, "O");
                    }
                    else if (pointsOut == 5)
                    {
                        line3.Insert(8, "|");
                    }
                    else if (pointsOut == 4)
                    {
                        line3.Insert(9, "/");
                    }
                    else if (pointsOut == 3)
                    {
                        line3.Insert(7, @"\");
                        line3.Remove(8, 1);
                    }
                    else if (pointsOut == 2)
                    {
                        line4.Insert(8, "|");
                    }
                    else if (pointsOut == 1)
                    {
                        line5.Insert(9, @"\");
                        Console.WriteLine("*****WARNING!!!!! YOU HAVE 1 MORE CHANCE LEFT****");
                    }
                    else if (pointsOut == 0)
                    {
                        line5.Insert(8, "/");
                        line5.Remove(8, 1);
                    }

                    if (pointsOut == 0)
                    {
                        Console.WriteLine(line1 + "\n" + line2 + "\n" + line3 + "\n" + line4 + "\n" + line5 + "\n" + line6 + "\n" + line7 + "\n" + line8 + "\n\n" + line9 + "\n");
                        Console.WriteLine("OH NO!!!! You lost!\nThe game is over!");
                        Console.WriteLine("Press 'e' to exit");
                        string exit = Console.ReadLine();
                        if (exit == "e")
                        {
                            playing = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again!");
                }               

            }
        }

       
    }
}