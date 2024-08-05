namespace LeetCodeSolutions.Easy
{
    public class PalindromNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            string stringNumber = x.ToString();

            for(int i = 0; i < stringNumber.Length / 2; i++)
            {
                if (!stringNumber[i].Equals(stringNumber[stringNumber.Length - i - 1]))
                    return false;
            }

            return true;
        }
    }
}
