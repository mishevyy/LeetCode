

namespace LeetCodeTests
{
    public class TwoSumTest
    {
        private TwoSumSolution twoSumSolution;

        [SetUp]
        public void Setup()
        {
            twoSumSolution = new TwoSumSolution();
        }

        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 2, 7, 11, 15 }, 5, ExpectedResult = new int[] { })]
        [TestCase(new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] Test(int[] nums, int target)
        {
            return twoSumSolution.TwoSum(nums, target);
        }

    }
}
