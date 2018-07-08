using System;

namespace Existence
{
    public class Game
    {
		//Basic components for the game. Defines the size of the world and holds the current generation.
		public int Columns { get; } 
        public int Rows { get; }
		public int[,] Grid { get; set; }

		public Game(int cols, int rows, int[,] grid)
		{
			Columns = cols;
			Rows = rows;
			Grid = grid;
		}
        
        public void NextGeneration()
		{
			//intialize the next generation
			var nextGeneration = new int[Rows,Columns];

            //have a peek at every cell
			for (int row = 0; row < Rows; row++)
			{
				for (int col = 0; col < Columns; col++)
				{
					//check the neighborhood population
					int livingNeighborsInTheArea = 0;
					for (int i = -1; i <= 1; i++)
					{
						for (int j = -1; j <= 1; j++)
						{
							if ((i + row < 0) || (i + row > Rows - 1) || (j + col < 0) || (j + col > Columns - 1))
								continue;
							livingNeighborsInTheArea += Grid[row + i, col + j];
						}
					}
					//make sure that our current cell is correctly accounted for
					livingNeighborsInTheArea -= Grid[row, col];

					//loneliness can kill | underpopulation (living cell w/ less than 2 neighbors)
					if ((Grid[row, col] == 1) && (livingNeighborsInTheArea < 2))
						nextGeneration[row, col] = 0;
					//life as ordinary | (live cell w/ 2 or 3 living neighbors)
					else if ((Grid[row, col] == 1) && ((livingNeighborsInTheArea == 2) || (livingNeighborsInTheArea == 3)))
						nextGeneration[row, col] = 1;
					//sometimes conditions are perfect for expansion | reproduction | (dead cell w/ exactly 3 neighbors)
					else if ((Grid[row, col] == 0) && (livingNeighborsInTheArea == 3))
						nextGeneration[row, col] = 1;
					//other scenarios | includes overpopulation | (more than 3 neighbors)
					else
						nextGeneration[row, col] = 0;

				}
			}
			Grid = nextGeneration;
		}
    }
}