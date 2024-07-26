namespace LeetCode.Tests
{
    public class TwoSumTest
    {
        [Fact]
        public void TwoSum_Test()
        {
            var solution = new TwoSumSolution();
            var numes = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var result = solution.TwoSum(numes, target);

            Assert.Equal([0, 1], result);
        }
    }
}
