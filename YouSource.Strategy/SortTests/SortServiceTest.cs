using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouSource.Strategy;

namespace YouSource.SortTests
{
    [TestClass]
    public class SortServiceTest
    {
        [TestMethod]
        public void BubbleSortServiceTest()
        {
            BubbleSortStrategy bubbleSort = new BubbleSortStrategy();
            SortService sortService = new SortService(bubbleSort);
            string mockInputValue = "bernard";

            string actualResult = sortService.executeSortingMethod(mockInputValue);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void QuickSortServiceTest()
        {
            QuickSortStrategy quickSort = new QuickSortStrategy();
            SortService sortService = new SortService(quickSort);
            string mockInputValue = "bernard";

            string actualResult = sortService.executeSortingMethod(mockInputValue);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MergeSortServiceTest()
        {
            MergeSortStrategy mergeSort = new MergeSortStrategy();
            SortService sortService = new SortService(mergeSort);
            string mockInputValue = "bernard";

            string actualResult = sortService.executeSortingMethod(mockInputValue);

            string expectedResult = "abdenrr";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
