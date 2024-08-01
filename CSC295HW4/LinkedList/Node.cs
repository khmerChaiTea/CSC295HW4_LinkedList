using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW4.LinkedList
{
    public class Node
    {
        // These two are the important part
        // Can store int or string
        public int Data { get; set; }
        // Node? Next is going to point to the next bucket and so on until Null
        public Node? Next { get; set; }

        // This should only be used with Doubly Linked Lists
        public Node? Previous { get; set; }

        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
