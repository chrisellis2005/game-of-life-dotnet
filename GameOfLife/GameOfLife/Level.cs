using System;
using System.Collections.Generic;

namespace GameOfLife
{
    public class Level
    {
        public List<List<int>> LevelMap
        {
            get;
            private set;
        }

        public static Level LoadLevel(List<List<int>> level)
        {
            return new Level
            {
                LevelMap = level
            };
        }

        public void Next()
        {
            var newLevelMap = new List<List<int>>();

            for (var x = 0; x < LevelMap.Count; x++)
            {
                var currentRow = new List<int>();
                newLevelMap.Add(currentRow);
                for (var y = 0; y < LevelMap[0].Count; y++)
                {
                    var currentAlive = IsCellAlive(x, y);
                    var neighbourCount = GetNeighbourCount(x, y);

                    /*
                    Console.Write("X: " + x);
                    Console.Write(" y: " + y);
                    Console.Write(" alive: " + currentAlive);
                    Console.WriteLine(" neighbours: " + neighbourCount);
                    */

                    var newAlive = 0;

                    if (currentAlive == 1 &&
                        (neighbourCount == 2 ||
                            neighbourCount == 3))
                        newAlive = 1;

                    if (currentAlive == 0 &&
                        neighbourCount == 3)
                        newAlive = 1;

                    currentRow.Add(newAlive); //currentRow.Add(1);
                }
            }

            LevelMap = newLevelMap;
        }

        private int GetNeighbourCount(int x, int y)
        {
            var neighbours = 0;

            neighbours += IsCellAlive(x-1, y-1); // NW 
            neighbours += IsCellAlive(x, y-1); //N
            neighbours += IsCellAlive(x+1, y-1); //NE
            neighbours += IsCellAlive(x - 1, y); //E
            neighbours += IsCellAlive(x + 1, y); //W
            neighbours += IsCellAlive(x - 1, y + 1); //SW
            neighbours += IsCellAlive(x, y + 1); //S
            neighbours += IsCellAlive(x + 1, y + 1); //SE

            return neighbours;
        }

        private int IsCellAlive(int x, int y)
        {
            try
            {
                return LevelMap[x][y];
            }
            catch 
            {
                return 0;
            }
        }

        private void ReverseCell(int x, int y)
        {
            if (LevelMap[x][y] == 0)
            {
                LevelMap[x][y] = 1;
            }
            else
            {
                LevelMap[x][y] = 0;
            }
        }
    }
}

