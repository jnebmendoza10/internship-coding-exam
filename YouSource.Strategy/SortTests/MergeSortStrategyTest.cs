using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouSource.Strategy;

namespace YouSource.SortTests
{
    [TestClass]
    public class MergeSortStrategyTest
    {
        [TestMethod]
        public void MergeSortTest()
        {
            BubbleSortStrategy bubbleSort = new BubbleSortStrategy();
            string mockInput = "bernard";

            string actualResult = bubbleSort.sort(mockInput);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
