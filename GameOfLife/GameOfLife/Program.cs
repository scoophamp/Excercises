using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Game game = new Game();

            int[,] arr = new int[20, 20];

            Random R = new Random();


            for (int i = 0; i < 80; i++)
            {
                int x = R.Next(20);
                int y = R.Next(20);
                arr[x, y] = 1;
            }
            while (true)
            {
                Console.Clear();


                game.PrintVisual(arr);
                game.ProcessGame(arr);
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}
