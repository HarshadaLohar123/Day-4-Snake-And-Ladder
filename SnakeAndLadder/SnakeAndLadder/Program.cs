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
        static void Main(string[] args)
        {
            SnakeAndLadder.Uc_1_SinglePlayer();
            SnakeAndLadder.UC_2_PlayerRollDie();
        }
    }
}
