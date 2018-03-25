public static Node ReturnKthToLast(Node head, int k)
{
    Node kNode = head;
    Node tempNode = head;
    int count = 0;
    while(tempNode.next != null)
    {
        if(count == k)
        {
            kNode = kNode.next;
        }
        else
        {
            count += 1;
        }
        tempNode = tempNode.next;

    }
    return kNode;
}