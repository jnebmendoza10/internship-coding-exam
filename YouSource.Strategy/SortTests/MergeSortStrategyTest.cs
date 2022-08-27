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
            MergeSortStrategy mergeSort = new MergeSortStrategy();
            string mockInput = "bernard";

            string actualResult = mergeSort.sort(mockInput);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
