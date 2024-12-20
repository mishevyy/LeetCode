﻿namespace LeetCode.Easy;

// Дан массив целых чисел, и искомое число
// найти два таких числа которые в сумме будут давать искомое число
// и верните их индексы
// Нельзя использовать один индекс дважды

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (result.ContainsKey(target - nums[i]))
            {
                return new int[] { result[target - nums[i]], i };
            }
            result.TryAdd(nums[i], i);
        }

        return Array.Empty<int>();
    }
}

// nums = [2,7,11,15], target = 9
// 1. Создаем словарь ключ - значение массива, значение - индекс, по которому хранится значение в массиве
// 2. В цикле проверяем есть ли в словаре ключ, который равен целевое значение минус текущее значение из массива
// 3. Если такой ключ есть возвращаем значение этого ключа, и текущий индекс проверяемого массива
// 4. Иначе добавляем в словарь новую пару ключ - значение