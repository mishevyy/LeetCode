namespace LeetCode.Tests
{

    public class RomainToIntTest
    {
        [Fact]
        public void RomainToInt_Test_X()
        {
            var solution = new RomainToIntSolution();
            var romainNumber = "X";
            var result = solution.RomanToInt(romainNumber);

            Assert.Equal(10, result);
        }        

        [Fact]
        public void RomainToInt_Test_III()
        {
            var solution = new RomainToIntSolution();
            var romainNumber = "III";
            var result = solution.RomanToInt(romainNumber);

            Assert.Equal(3, result);
        }

        [Fact]
        public void RomainToInt_Test_LVIII()
        {
            var solution = new RomainToIntSolution();
            var romainNumber = "LVIII";
            var result = solution.RomanToInt(romainNumber);

            Assert.Equal(58, result);
        }

        [Fact]
        public void RomainToInt_Test_MCMXCIV()
        {
            var solution = new RomainToIntSolution();
            var romainNumber = "MCMXCIV";
            var result = solution.RomanToInt(romainNumber);

            Assert.Equal(1994, result);
        }
    }
}
