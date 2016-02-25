using System;
using GameOfLife;
using System.Collections.Generic;
using System.Threading;

namespace GameOfLifeConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var initalLevel = new List<List<int>> {
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
                new List<int>{0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1},
                new List<int>{0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0},
                new List<int>{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1},
                new List<int>{0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                new List<int>{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1},
                new List<int>{0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
                new List<int>{0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0},
                new List<int>{0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0},
            };
            var level = Level.LoadLevel(initalLevel);
            var year = 1;
            DrawLevel(level.LevelMap, year);

            while (true)
            {
                Thread.Sleep(1000);

                year++;
                level.Next();
                Console.Clear();
                DrawLevel(level.LevelMap, year);
            }

        }

        private static void DrawLevel(List<List<int>> levelMap, int year)
        {
            Console.WriteLine("Year " + year);
            for (var x = 0; x < levelMap.Count; x++)
            {
                for (var y = 0; y < levelMap[0].Count; y++)
                {
                    var cell = levelMap[x][y] == 1 ? "X" : " ";
                    Console.Write(cell);
                }
                Console.WriteLine();
            }

        }
    }
}
