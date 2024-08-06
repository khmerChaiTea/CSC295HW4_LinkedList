using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSC295HW4.LinkedList
{
    public class MyQueue
    {
        private LinkedList queue = new LinkedList();

        public void Enqueue(int data)
        {
            queue.InsertLast(data);
        }

        public void Dequeue()
        {
            queue.DeleteFirst();
        }

        public int Peek()
        {
            if (queue.First == null)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return queue.First.Data;
        }
    }
}
