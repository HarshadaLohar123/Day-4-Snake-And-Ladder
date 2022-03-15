using System;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public static void Uc_1_SinglePlayer()
        {
            Console.WriteLine("Welcome To Snake And Ladde Problem");
            Console.WriteLine("Snake and Ladder game played with single player start at zaro");
        }
        public static void UC_2_PlayerRollDie()
        {
            Console.WriteLine("Welcome to UC-2 program");
            Random rnd = new Random();
            int num = rnd.Next(1, 7);
            Console.WriteLine("The Random Dice Number is: " + num);

        }
        public static void UC_3_PlayGame()
        {
            int ladder = 1, ldice;
            int snake = 2, sdice;
            Console.WriteLine("Welcome to UC_3");
            Random random = new Random();
            int randomCheck = random.Next(3);

            switch (randomCheck)
            {
                case 1:
                    {
                        Random rnd = new Random();
                        ldice = rnd.Next(1, 7);
                        Console.WriteLine("Got Ladder");
                        break;
                    }
                case 2:
                    {
                        Random sran = new Random();
                        sdice = sran.Next(1, 7);
                        Console.WriteLine("Got snake");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No play, Stay at base");
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            SnakeAndLadder.Uc_1_SinglePlayer();
            SnakeAndLadder.UC_2_PlayerRollDie();
            SnakeAndLadder.UC_3_PlayGame();
        }
    }
}

