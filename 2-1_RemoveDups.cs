public Node RemoveDups(Node head)
{
    if (head == null || head.next == null) { return head; }

    Node left = head;
    Node rightBefore = head;
    Node right = head.next;
    while (left.next != null)
    {
        if (right.data == left.data)
        {
            rightBefore.next = right.next;
            right = right.next;
        }
        else
        {
            rightBefore = right;
            right = right.next;
        }
        if (right == null)
        {
            left = left.next;
            rightBefore = left;
            right = left.next;
        }
    }
    return head;
}

public Node RemoveDups2(Node head)
{
    if (head == null || head.next == null) { return head; }
    HashSet<int> datas = new HashSet<int>();
    Node traveler = head;
    Node before = null;
    while (traveler != null)
    {
        if (datas.Contains(traveler.data))
        {
            before.next = traveler.next;
        }
        else
        {
            datas.Add(traveler.data);
            before = traveler;
        }
        traveler = traveler.next;
    }
    return head;
}