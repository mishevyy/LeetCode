namespace LeetCode.Easy;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class MergeTwoSortedListsSolution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null) return null;
        else if (list1 != null && list2 == null)
        {
            return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
        }
        else if (list1 == null && list2 != null)
        {
            return new ListNode(list2.val, MergeTwoLists(list1, list2.next));
        }
        else
        {
            return list1.val < list2.val
                ? new ListNode(list1.val, MergeTwoLists(list1.next, list2))
                : new ListNode(list2.val, MergeTwoLists(list1, list2.next));
        }
    }
}
