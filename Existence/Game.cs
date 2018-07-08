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
			for (int c = 1; c < Columns - 1; c++)
			{
				for (int r = 1; r < Rows - 1; r++)
				{
					//check the neighborhood population
					int livingInTheArea = 0;
					for (int i = -1; i <= 1; i++)
						for (int j = -1; j <= 1; j++)
							livingInTheArea += Grid[c + i, r + j];
					//make sure that our current cell is correctly accounted for
					livingInTheArea -= Grid[c, r];

					//cell doesn't have a chance alone
					if ((Grid[c, r] == 1) && (livingInTheArea < 2))
						result[c, r] = 0;
					//to many living cells in the area kills one
					else if ((result[c, r] == 1) && (livingInTheArea > 3))
						result[c, r] = 0;
				}
			}
			Grid = result;
		}
    }
}