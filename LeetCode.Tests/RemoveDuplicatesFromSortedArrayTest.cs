namespace LeetCode.Tests
{
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [Fact]
        public void TwoSum_Test()
        {
            var solution = new RemoveDuplicatesFromSortedArray();
            var numes = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var target = 9;

            var result = solution.RemoveDuplicates(numes);

            Assert.Equal(5, result);
        }
    }
}
