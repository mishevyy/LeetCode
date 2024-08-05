using LeetCodeSolutions.Easy;

namespace LeetCode.Tests
{

    public class RomainToIntTest
    {
        [Fact]
        public void RomainToInt_Test()
        {
            var solution = new RomainToIntSolution();
            var romainNumber = "X";
            var result = solution.RomanToInt(romainNumber);

            Assert.Equal(10, result);
        }
    }
}
