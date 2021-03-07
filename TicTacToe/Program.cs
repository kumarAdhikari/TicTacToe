using System;

namespace TicTacToe
{
    class Program
    {
            static bool playAgain = false;

            static bool draw = false;
            static bool winner = false;
            static int playCount = 0;
            static char[] j = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            static void Main(string[] args)
            {

                Program check = new Program();
                
                Console.WriteLine("Welcome to Tic-Tac-Toe App:");
                Console.WriteLine("Player One will be 'X' and Player Two will be 'O'");
                Console.WriteLine("Let's Start");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("____|____|____");
                Console.WriteLine("____|____|____");
                Console.WriteLine("    |    |    ");
            

               
                do
                {
                    bool playerone = false;
                    bool playertwo = false;
                    while (playerone == false)
                    {
                        Console.WriteLine("Player One, where do you want to place your 'X' (Enter number 0-8): ");
                        int i = Convert.ToInt32(Console.ReadLine());
                        if (j[i] == ' ')
                        {
                            j[i] = 'X';
                            playerone = true;
                        }
                        else
                        {
                            playerone = false;
                            Console.WriteLine("IT's Already taken Please Select another slot");
                        }
                    }
                    bord();
                    if (check.isWinner())
                    {
                        break;
                    }
                    while (playertwo == false)
                    {
                        Console.WriteLine("\nPlayer Two, where do you want to place your 'O' (Enter number 0-8): ");
                        int two = Convert.ToInt32(Console.ReadLine());

                        if (j[two] == ' ')
                        {
                            j[two] = 'O';
                            playertwo = true;
                        }
                        else
                        {

                            Console.WriteLine("IT's Already taken Please Select another slot");
                            playertwo = false;
                        }
                    }
                    bord();
                    if (check.isWinner())
                    {
                        break;
                    }
                } while (winner == false || draw == false);
            Console.WriteLine("<><><><>PRESS ANY KEY TO CLOSE APPLICATION<><><><>");
            Console.ReadKey();
            }

            public bool isWinner()
            {
                playCount++;
                if (j[0] == j[1] && j[1] == j[2] && j[0] != ' ' ||
                        j[3] == j[4] && j[4] == j[5] && j[3] != ' ' ||
                        j[6] == j[7] && j[7] == j[8] && j[6] != ' ' ||
                        j[0] == j[3] && j[3] == j[6] && j[0] != ' ' ||
                        j[1] == j[4] && j[4] == j[7] && j[1] != ' ' ||
                        j[2] == j[5] && j[5] == j[8] && j[2] != ' ' ||
                        j[0] == j[4] && j[4] == j[8] && j[0] != ' ' ||
                        j[2] == j[4] && j[4] == j[6] && j[2] != ' ')
                {
                    winner = true;
                    Console.WriteLine("You Won the Game  ******#######********");
                    Console.WriteLine( "Thank You For Playing");
                    return winner;
                }
                if (playCount == 9)
                {
                    draw = true;
                    Console.WriteLine("Game Draw...............");
                    Console.WriteLine("Thank You For Playing");
            }
                return winner||draw;
            }

            public static void bord()
            {
                Console.WriteLine($"__{j[0]}__|__{j[1]}__|_{j[2]}___");
                Console.WriteLine($"__{j[3]}__|__{j[4]}__|_{j[5]}___");
                Console.WriteLine($"__{j[6]}__|__{j[7]}__|_{j[8]}___");
            }
        }
    }
