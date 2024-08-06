using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW4.LinkedList.Tests
{
    [TestClass()]
    public class MyQueueTests
    {
        [TestMethod()]
        public void Enqueue_AddingSingleItem_ShouldAddItem()
        {
            // Arrange
            MyQueue queue = new MyQueue();

            // Act
            queue.Enqueue(5);

            // Assert
            Assert.IsTrue(queue.Peek() == 5);
        }

        [TestMethod()]
        public void Dequeue_ListHasASingleItem_ListShouldBeNull()
        {
            // Arrange
            MyQueue queue = new MyQueue();
            queue.Enqueue(5);

            // Act
            queue.Dequeue();

            // Assert
            Assert.IsTrue(queue.Peek().Equals(null));
        }

        [TestMethod()]
        public void Push_AddingSingleItem_ShouldAddItem()
        {
            // Arrange
            MyStack _stack = new MyStack();

            // Act
            _stack.Push(5);

            // Assert
            Assert.IsTrue(_stack.Peek() == 5);
        }

        [TestMethod()]
        public void Pop_ListHasASingleItem_ListShouldBeNull()
        {
            // Arrange
            MyStack _stack = new MyStack();
            _stack.Push(5);

            // Act
            _stack.Pop();

            // Assert
            Assert.IsTrue(_stack.Peek().Equals(null));
        }
    }
}