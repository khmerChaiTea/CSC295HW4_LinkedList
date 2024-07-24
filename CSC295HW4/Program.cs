// Linked List
using CSC295HW4.LinkedList;

class Program
{
    static void Main()
    {
        LinkedList linkedList = new LinkedList();
        linkedList.InsertFirst(1);
        linkedList.InsertFirst(2);
        linkedList.InsertFirst(3);
        linkedList.InsertFirst(4);

        linkedList.DeleteFirst(1);
        linkedList.DeleteFirst(2);

        linkedList.InsertLast(926);
        linkedList.InsertLast(348);

        linkedList.DisplayList();
    }
}
