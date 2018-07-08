using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Existence.Test
{
	[TestClass]
	public class RulesOfLifeTests
	{
		/// <summary>
        /// Whens the next generation is called future generation is returned.
        /// </summary>
		[TestMethod] 
		public void When_NextGenerationIsCalled_FutureGenerationIsReturned()
		{
			//Arange 
			int[,] seed = { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
			var game = new Game(3, 3, seed);

			//Act
			game.NextGeneration();

			//Assert
			Assert.AreNotEqual(seed, game.Grid);

		}

        /// <summary>
        /// Whens the live cell has less than 2 live neighbors the cell dies.
        /// </summary>
		[TestMethod] //Rule 1 "Under Population"
		public void When_LiveCellHasLessThan2LiveNeighbors_TheCellDies()
		{
			//Arange 
			int[,] seed = { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
			var game = new Game(3, 3, seed);

			//Act
			game.NextGeneration();

			//Assert
			CollectionAssert.AreEqual(new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }, game.Grid);
	    }

        /// <summary>
        /// Whens the live cell has 2 live neighbors the cell lives.
        /// </summary>
        [TestMethod] //Rule 2 
        public void When_LiveCellHas2LiveNeighbors_TheCellLives()
		{
			//Arange 
            int[,] seed = { { 0, 0, 1 }, { 0, 1, 0 }, { 1, 0, 0 } };
            var game = new Game(3, 3, seed);
            
            //Act
            game.NextGeneration();
            
            //Assert
            CollectionAssert.AreEqual(new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0} }, game.Grid);
		}
        
        /// <summary>
        /// Whens the live cell has 3 live neighbors the cell lives.
        /// </summary>
        [TestMethod] //Rule 2
		public void When_LiveCellHas3LiveNeighbors_TheCellLives()
		{
            //Arange 
            int[,] seed = { { 0, 0, 0 }, { 1, 1, 0 }, { 1, 1, 0 } };
            var game = new Game(3, 3, seed);

            //Act
            game.NextGeneration();

            //Assert
            CollectionAssert.AreEqual(new int[,] { { 0, 0, 0 }, { 1, 1, 0 }, { 1, 1, 0 } }, game.Grid);
		}

        /// <summary>
        /// Whens the live cell has more than 3 neighbors the cell dies.
        /// </summary>
        [TestMethod] //Rule 3 "Overpopulation"
        public void When_LiveCellHasMoreThan3Neighbors_TheCellDies()
		{
            //Arange 
            int[,] seed = { { 1, 1, 1 }, { 1, 1, 0 }, { 0, 0, 1 } };
            var game = new Game(3, 3, seed);
            
            //Act
            game.NextGeneration();

            //Assert
            CollectionAssert.AreEqual(new int[,] { { 1, 0, 1 }, { 1, 0, 0 }, { 0, 1, 0 } }, game.Grid);
		}

        /// <summary>
        /// Whens the dead cell has exactly 3 neighbors the cell lives.
        /// </summary>
        [TestMethod] //Rule 4 "Reproduction"
        public void When_DeadCellHasExactly3Neighbors_TheCellLives()
		{
            //Arange 
            int[,] seed = { { 1, 0, 1 }, { 0, 0, 0 }, { 0, 1, 0 } };
            var game = new Game(3, 3, seed);

            //Act
            game.NextGeneration();

            //Assert
            CollectionAssert.AreEqual(new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } }, game.Grid);
		}
    }
}
