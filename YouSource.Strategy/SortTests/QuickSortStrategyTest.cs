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
            BubbleSortStrategy bubbleSort = new BubbleSortStrategy();
            string mockInput = "bernard";

            string actualResult = bubbleSort.sort(mockInput);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
