// Linked List
using CSC295HW4.LinkedList;

class Program
{
    static void Main()
    {
        DoublyLinkedList linkedList = new DoublyLinkedList();
        linkedList.InsertFirst(1);
        linkedList.InsertFirst(2);
        linkedList.InsertFirst(3);
        linkedList.InsertFirst(4);

        linkedList.DeleteFirst();
        linkedList.DeleteFirst();

        linkedList.InsertLast(926);
        linkedList.InsertLast(348);

        linkedList.DisplayList();
    }
}
