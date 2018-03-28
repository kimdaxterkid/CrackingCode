public static Node SumLists(Node list1, Node list2, int carry)
{
    if (list1 == null && list2 == null && carry == 0) { return null; }

    int value = carry;
    if (list1 != null) { value += list1.data; }
    if (list2 != null) { value += list2.data; }
    int remain = value % 10;
    Node result = new Node(remain);
    if (list1 != null || list2 != null)
    {
        Node nextNode = SumLists(list1 == null ? null : list1.next,
                                    list2 == null ? null : list2.next,
                                    value >= 10 ? 1 : 0);
        result.next = nextNode;
    }
    return result;
}