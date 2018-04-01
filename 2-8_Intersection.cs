public class Result {    
    Node tail;
    int size;
    public Result(Node tail, int size)
    {
        this.tail = tail;
        this.size = size;
    }
}

public Node Intersection(Node list1, Node list2)
{
    if (list1 == null || list2 == null) { return null; }
    
    Result r1 = getTailAndSize(list1);
    Result r2 = getTailAndSize(list2);
    if (r1.tail != r2.tail) { return null; }

    Node longer = r1.size > r2.size ? r1 : r2;
    Node shorter = r1.size > r2.size ? r2 : r1;

    longer = getKthNode(longer, Math.Abs(r1 - r2));

    while (longer != shorter)
    {
        longer = longer.next;
        shorter = shorter.next;
    }
    return longer;

}

public Result getTailAndSize(Node list)
{
    int size = 1;
    Node currentNode = list;
    while (currentNode.next != null)
    {
        size += 1;
        currentNode = currentNode.next;
    }
    return new Result(currentNode, size);
}

public Node getKthNode(Node node, int difference)
{
    Node currentNode = node;
    int diff = difference;
    while (diff > 0) 
    {
        currentNode = currentNode.next;
        diff -= 1;
    }
    return currentNode;
}