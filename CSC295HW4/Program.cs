using CSC295HW4.LinkedList;

namespace CSC295HW4
{
    internal class Program
    {
        // Linked List
        static void Main(string[] args)
        {
            Node nodeA = new Node();
            nodeA.Data = 165;

            Node nodeB = new Node();
            nodeB.Data = 435;

            Node nodeC = new Node();
            nodeC.Data = 196;

            Node nodeD = new Node();
            nodeD.Data = 951;

            // Make the arrow point to the next node
            // A linked list is an objectified array
            nodeA.Next = nodeB;
            nodeB.Next = nodeC;
            nodeC.Next = nodeD;
        }
    }

}
