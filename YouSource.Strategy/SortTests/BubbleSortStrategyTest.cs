using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouSource.Strategy;

namespace YouSource.SortTests
{
    [TestClass]
    public class BubbleSortStrategyTest
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            BubbleSortStrategy bubbleSort = new BubbleSortStrategy();
            string mockInput = "bernard";

            string actualResult = bubbleSort.sort(mockInput);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
