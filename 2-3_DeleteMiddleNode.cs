public void DeleteMiddleNode(Node target)
{
    if (target == null || target.next == null) { return; }

    Node nextNode = target.next;
    target.data = nextNode.data;
    target.next = nextNode.next;
    return;
}