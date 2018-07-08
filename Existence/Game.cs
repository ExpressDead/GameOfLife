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
			int[,] result = new int[Columns, Rows];

            //have a peek at every cell
			for (int row = 1; row < Rows - 1; row++)
			{
				for (int col = 1; col < Columns - 1; col++)
				{
					//check the neighborhood population
					int livingInTheArea = 0;
					for (int i = -1; i <= 1; i++)
						for (int j = -1; j <= 1; j++)
							livingInTheArea += Grid[row + i, col + j];
					//make sure that our current cell is correctly accounted for
					livingInTheArea -= Grid[row, col];
                    
					//cell doesn't have a chance alone
					if ((Grid[row, col] == 1) && (livingInTheArea < 2))
						result[row, col] = 0;
					//to many living cells in the area kills one
					else if ((result[row, col] == 1) && (livingInTheArea > 3))
						result[row, col] = 0;
				}
			}
			Grid = result;
		}
    }
}