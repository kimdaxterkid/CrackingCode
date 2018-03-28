public static bool Palindrome1(Node head)
{
    Node newHead = null;
    Node iteratorHead = head;
    while (iteratorHead != null)
    {
        Node tempNode = new Node(iteratorHead.data);
        tempNode.next = newHead;
        newHead = tempNode;
        iteratorHead = iteratorHead.next;
    }
    iteratorHead = head;
    while (newHead != null && iteratorHead != null)
    {
        if (newHead.data != iteratorHead.data)
        {
            return false;
        } else
        {
            newHead = newHead.next;
            iteratorHead = iteratorHead.next;
        }
    }
    return newHead == null && iteratorHead == null;
}

public static bool Palindrome2(Node head)
{
    if (head == null && head.next == null) { return false; }

    Node slow = head;
    Node fast = head;
    Stack<int> firstHalf = new Stack<int>();

    while (fast != null fast.next != null) 
    {
        firstHalf.Push(slow.data);
        slow = slow.next;
        fast = fast.next.next;
    }

    if (fast != null) { slow = slow.next; }

    while (slow != null)
    {
        if (slow.data != firstHalf.Pop()) { return false; }

        slow = slow.next;
    }

    return true;
}