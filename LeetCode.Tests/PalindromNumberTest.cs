using LeetCodeSolutions.Easy;

namespace LeetCode.Tests
{
    public class PalindromNumberTest
    {
        [Fact]
        public void PalindromNumber_Test()
        {
            var solution = new PalindromNumberSolution();
            var number = 121;
            var result = solution.IsPalindrome(number);

            Assert.True(result);
        }
    }
}
