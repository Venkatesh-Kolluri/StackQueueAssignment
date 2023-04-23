using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class PeekPop
    {
        private Node top;
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
        }
        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            int data = top.data;
            top = top.next;
            return data;
        }
        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Empty Stack");
            }
            return top.data;
        }
        public bool IsEmpty()
        {
            return top == null;
        }

    }

}
