using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW4.LinkedList
{
    public class MyStack
    {
        private LinkedList _stack = new LinkedList();

        public LinkedList Stack { get { return _stack; } }

        public void Push(int value)
        {
            _stack.InsertFirst(value);
        }

        public Node Pop()
        {
            return _stack.DeleteFirst();
        }
    }
}
