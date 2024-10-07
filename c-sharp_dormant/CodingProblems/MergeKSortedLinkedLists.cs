namespace CodingProblems;

public class LinkedListNode {
    public int value;
    public LinkedListNode? next;

    public LinkedListNode(int value) 
    {
        this.value = value;
        this.next = null;
    }
}

public static class MergeKSortedLinkedLists
{
    public static LinkedListNode? Execute(List<LinkedListNode> lists)
    {
        if (lists.Count == 0)
            return null;
            
        return Merge(lists, 0, lists.Count - 1);
    }

    public static LinkedListNode Merge(List<LinkedListNode> lists, int startIndex, int endIndex)
    {
        if (startIndex == endIndex)
            return lists[startIndex];
        
        var mid = (startIndex + endIndex) / 2;
        
        var first = Merge(lists, startIndex, mid);
        var second = Merge(lists, mid + 1, endIndex);
        
        LinkedListNode? head = null;
        LinkedListNode? curr = null;
        
        while ((first != null) && (second != null))
        {
            var minValue = 0;
            if (first.value <= second.value)
            {
                minValue = first.value;
                first = first.next;
            }
            else
            {
                minValue = second.value;
                second = second.next;
            }
            
            if (head == null)
            {
                head = new (minValue);
                curr = head;
            }
            else
            {
                LinkedListNode newNode = new (minValue);
                curr.next = newNode;
                curr = newNode;
            }
        }
        
        while (first != null)
        {
            var value = first.value;
            if (head == null)
            {
                head = new (value);
                curr = head;
            }
            else
            {
                LinkedListNode newNode = new (value);
                curr.next = newNode;
                curr = newNode;
            }
            first = first.next;
        }
        
        while (second != null)
        {
            var value = second.value;
            if (head == null)
            {
                head = new (value);
                curr = head;
            }
            else
            {
                LinkedListNode newNode = new (value);
                curr.next = newNode;
                curr = newNode;
            }
            second = second.next;
        }
        
        return head;
    }
}