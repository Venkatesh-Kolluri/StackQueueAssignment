using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class DequeueStack
    {
        private Node front;
        private Node rear;
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

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            int value = front.data;
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
            return value;
        }

        public int Peek()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            return front.data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void DequeueFromBeginning()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            front = front.next;
            if (front == null)
            {
                rear = null;
            }
        }


    }

}
