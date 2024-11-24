using System;

namespace Snake_and_Ladder
{
    class GameManager
    {
        private Points[] _board = new Points[100];
        private int _size = 100;

        Random rand = new Random();

        public GameManager()
        {
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            _board[0] = 0;

            for (int i = 1; i < _size; i++)
            {
                _board[i] = (Points)rand.Next(7);
            }
        }

        public int Roll()
        {
            int roll = rand.Next(6);
            return roll + 1;
        }

        public void Play()
        {
            Console.Write("Enter name of Player1 : ");
            Players.Player1 = Console.ReadLine();

            Console.Write("Enter name of Player2 : ");
            Players.Player2 = Console.ReadLine();

            int toss = rand.Next(2);

            if (toss > 0)
            {
                Console.WriteLine($"\n{Players.Player2} won the toss....");

                while (true)
                {
                    Console.Write("\nLets roll Player2 (Y/N): ");
                    string player2Input = Console.ReadLine();

                    if (player2Input.ToLower() == "y")
                    {
                        CheckBox(ref Players.Score2, Players.Player2);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                    Console.Write("\nLets roll Player1 (Y/N): ");
                    string player1Input = Console.ReadLine();

                    if (player1Input.ToLower() == "y")
                    {
                        CheckBox(ref Players.Score1, Players.Player1);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine($"\n{Players.Player1} won the toss....");

                while (true)
                {
                    Console.Write("\nLets roll Player1 (Y/N): ");
                    string player1Input = Console.ReadLine();

                    if (player1Input.ToLower() == "y")
                    {
                        CheckBox(ref Players.Score1, Players.Player1);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }

                    Console.Write("\nLets roll Player2 (Y/N): ");
                    string player2Input = Console.ReadLine();

                    if (player2Input.ToLower() == "y")
                    {
                        CheckBox(ref Players.Score2, Players.Player2);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void CheckBox(ref int playerScore, string playerName)
        {
            int rolled = Roll();

            Console.WriteLine($"{playerName} rolled a {rolled}");

            playerScore += rolled;

            if (playerScore >= _size)
            {
                playerScore = _size;
                Console.WriteLine($"{playerName} reached position 100 and wins!");

                Environment.Exit(0);
            }

            while (true)
            {
                string check = _board[playerScore].ToString();
                Console.WriteLine($"Reached {playerScore} which is {_board[playerScore]}");

                if (check.Contains("Safe"))
                {
                    break;
                }
                else if (check.Contains("Ladder"))
                {
                    Console.WriteLine("You found a ladder! Climbing up...");

                    string value = check.Split('_')[1];
                    playerScore += int.Parse(value);

                    if (playerScore > _size)
                    {
                        playerScore = _size;
                    }
                    Console.WriteLine($"Now at position {playerScore}");
                }
                else if (check.Contains("Snake"))
                {
                    Console.WriteLine("Oh no! You hit a snake! Sliding down...");

                    string value = check.Split('_')[1];
                    playerScore -= int.Parse(value);

                    if (playerScore < 0)
                    {
                        playerScore = 0;
                    }
                    Console.WriteLine($"Now at position {playerScore}");
                }
            }
        }
    }
}
