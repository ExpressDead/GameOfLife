using System;

namespace Existence
{
    public class Game
    {
		//Basic components for the game. Defines the size of the world and holds the current generation.
		public int Columns { get; } 
        public int Rows { get; }
		public int[,] Grid { get; }

		public Game(int cols, int rows, int[,] grid)
		{
			Columns = cols;
			Rows = rows;
			Grid = grid;
		}

        public void NextGeneration()
		{
			
		}
    }
}
