public Node Partition(Node node, int x)
{
    Node head = node;
    Node tail = node;
    while (node != null)
    {
        Node nextNode = node.next;
        if (node.data < x)
        {
            node.next = head;
            head = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }

        node = nextNode;
    }
    head.next = tail;
    return head;
}