namespace LeetCode.Easy;

public class RomainToIntSolution
{
    public int RomanToInt(string s)
    {
        var romain = new Dictionary<string, int>
        {
            ["I"] = 1,
            ["V"] = 5,
            ["X"] = 10,
            ["L"] = 50,
            ["C"] = 100,
            ["D"] = 500,
            ["M"] = 1000,
            ["IV"] = 4,
            ["IX"] = 9,
            ["XL"] = 40,
            ["XC"] = 90,
            ["CD"] = 400,
            ["CM"] = 900,
        };

        int sum = 0;

        for (int i = 0; i < s.Length;)
        {
            if (i + 1 < s.Length)
            {
                int current = romain[s[i].ToString()];
                int next = romain[s[i + 1].ToString()];
                if (current < next)
                {
                    if (romain.TryGetValue(s[i].ToString() + s[i + 1].ToString(), out int h))
                    {
                        sum += h;
                        i += 2;
                    }
                    else
                    {
                        sum += current;
                        i++;
                    }
                }
                else
                {
                    sum += current;
                    i++;
                }
            }
            else
            {
                sum += romain[s[i].ToString()];
                i++;
            }
        }

        return sum;
    }
}
