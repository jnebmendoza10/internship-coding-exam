using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouSource.Strategy;

namespace YouSource.SortTests
{  
    [TestClass]
    public class QuickSortStrategyTest
    {
        [TestMethod]
        public void QuickSortTest()
        {
            QuickSortStrategy quickSort = new QuickSortStrategy();
            string mockInput = "bernard";

            string actualResult = quickSort.sort(mockInput);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
