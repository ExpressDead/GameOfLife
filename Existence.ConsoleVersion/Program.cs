using System;

namespace Existence.ConsoleVersion
{
	/// <summary>
    /// Down and dirty runner for Our Game of Life interpretation. Allows us something a little more fun that just the Test Runner. 
	/// NOTE: This version will keep running until the user stops the application. 
    /// </summary>
    class Program
    {
		//setup for the game
		static int Cols = 10, Rows = 10;
        static int[,] Seed = {
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 }};
		static Game game = new Game(Cols, Rows, Seed);  

        static void Main(string[] args)
		{
			Play();                     
        }

        /// <summary>
        /// Play this instance.
        /// </summary>
        public static void Play()
		{
			for (int i = 0; i < Cols; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    if (game.Grid[i, j] == 0)
                        Console.Write(" - ");
                    else
                        Console.Write(" x ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
			game.NextGeneration();
			System.Threading.Thread.Sleep(500);
			Play();
		}
    }
}
