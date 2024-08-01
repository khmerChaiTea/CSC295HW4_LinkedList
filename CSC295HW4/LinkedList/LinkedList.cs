﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW4.LinkedList
{
    public class LinkedList
    {
        public Node? First { get; set; }
        public Node? Last { get; set; }

        public void InsertFirst(int data)
        {
            // Create the node
            Node newNode = new Node();

            // Put the data in the node
            newNode.Data = data;

            // Put the old node in next
            newNode.Next = First;

            // Make the first the new node
            First = newNode;

            if (First.Next == null) Last = newNode;
        }

        public Node DeleteFirst()
        {
            if (First == null)
            {
                Last = null;
                throw new InvalidOperationException("Cannot delete from an empty list.");
            }
            Node temp = First;
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating thru list...");
            Node? current = First;
            while (current != null) 
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

			if (First == null)
			{
				// If the list is empty, set the new node as the first node
				First = newNode;
				Last = newNode; // Set the Last pointer
			}
			else
			{
				Node currentLastNode = Last;
				// If the list is not empty, append the new node at the end
				currentLastNode.Next = newNode; // Last points to the new node
				Last = newNode; // Update Last to be the new node
			}
		}

    }
}
