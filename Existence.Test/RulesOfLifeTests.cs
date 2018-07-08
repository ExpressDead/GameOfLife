using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Existence.Test
{
	[TestClass]
	public class RulesOfLifeTests
	{
		[TestMethod] //Rule 1 "Under Population"
		public void When_LiveCellHasLessThan2LiveNeighbors_TheCellDies()
		{
			         
	    }
        [TestMethod] //Rule 2 
        public void When_LiveCellHas2LiveNeighbors_TheCellLives()
		{
			
		}

        [TestMethod] //Rule 2
		public void When_LiveCellHas3LiveNeighbors_TheCellLives()
		{
			
		}

        [TestMethod] //Rule 3 "Overpopulation"
        public void When_LiveCellHasMoreThan3Neighbors_TheCellDies()
		{
			
		}

        [TestMethod] //Rule 4 "Reproduction"
        public void Whne_DeadCellHasExactly3Neighbors_TheCellLives()
		{
			
		}
    }
}
