using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Game
    {
        private int CountNeighbor(int x, int y, int[,] arrayer)
        {

            int count = 0;

            try
            {
                if (arrayer[x - 1, y - 1] == 1)
                {
                    count++;

                }

            }
            catch
            {


            }
            try
            {
                if (arrayer[x, y - 1] == 1)

                {
                    count++;
                }
            }
            catch
            {


            }

            try
            {
                if (arrayer[y + 1, x] == 1)
                {
                    count++;
                }
            }
            catch
            {


            }
            try
            {
                if (arrayer[x, y + 1] == 1)
                {
                    count++;
                }
            }
            catch
            {

            }
            try
            {
                if (arrayer[x + 1, y + 1] == 1)
                {
                    count++;
                }
            }
            catch
            {


            }
            try
            {
                if (arrayer[x + 1, y] == 1)
                {
                    count++;
                }
            }
            catch
            {


            }
            try
            {
                if (arrayer[y - 1, x + 1] == 1)
                {
                    count++;
                }
            }
            catch
            {


            }
            try
            {
                if (arrayer[y - 1, x] == 1)
                {
                    count++;
                }
            }
            catch
            {


            }

            return count;
        }


        public void PrintVisual(int[,] arrayer)
        {


            for (int i = 0; i < arrayer.GetLength(0); i++)
            {
                for (int j = 0; j < arrayer.GetLength(1); j++)
                {


                    if (arrayer[i, j] == 0)
                    {
                        Console.Write(" ");


                    }
                    if (arrayer[i, j] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                }
                Console.WriteLine();
            }
        } //Method to write the cells out depending if live or not

        public void ProcessGame(int[,] arrayer)
        {
            var SnapShot = new int[arrayer.GetLength(0), arrayer.GetLength(1)];

            for (int x = 0; x < arrayer.GetLength(0); x++)
            {
                for (int y = 0; y < arrayer.GetLength(1); y++)
                {
                    SnapShot[x, y] = arrayer[x, y];
                }
            }
            for (int x = 0; x < arrayer.GetLength(0); x++)
            {
                for (int y = 0; y < arrayer.GetLength(1); y++)
                {
                    if (arrayer[x, y] == 1 && CountNeighbor(x, y, SnapShot) < 2)
                    {

                        arrayer[x, y] = 0; //cell = dead
                    }
                    if (arrayer[x, y] == 1 && CountNeighbor(x, y, SnapShot) > 3)
                    {
                        arrayer[x, y] = 0; //cell = dead
                    }
                    if (arrayer[x, y] == 1 && CountNeighbor(x, y, SnapShot) == 2 || CountNeighbor(x, y, SnapShot) == 3)
                    {
                        arrayer[x, y] = 1; //cell = alive
                    }
                    if (arrayer[x, y] == 0 && CountNeighbor(x, y, SnapShot) == 3)
                    {
                        arrayer[x, y] = 1; //cell alive
                    }

                }



            }


        } //Method with an action to check neighboor and decides if cell lives on or not

    }
}

