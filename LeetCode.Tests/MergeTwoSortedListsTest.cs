using LeetCodeSolutions.Easy;

namespace LeetCode.Tests
{
    public class MergeTwoSortedListsTest
    {
        [Fact]
        public void MergeTwoLists_Test()
        {
            var solution = new MergeTwoSortedListsSolution();
            var list1 = new ListNode(1);
            var list2 = new ListNode(2);
            var result = solution.MergeTwoLists(list1, list2);

            Assert.NotNull(result);
        }
    }
}
