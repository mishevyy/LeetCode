namespace LeetCode.Easy;

public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        int duplicated = nums[0];
        int insertedIndex = 1;

        for (int i = 1; i < nums.Length;)
        {
            if (nums[i] == duplicated) i++;
            else
            {
                nums[insertedIndex] = nums[i];
                duplicated = nums[i];
                insertedIndex++;
                i++;
            }
        }

        return insertedIndex;
    }
}
