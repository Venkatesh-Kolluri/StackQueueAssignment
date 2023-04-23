using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
                DequeueStack queue = new DequeueStack();
                queue.Enqueue(56);
                queue.Enqueue(30);
                queue.Enqueue(70);

                Console.WriteLine(queue.Dequeue());

                queue.DequeueFromBeginning();

                Console.WriteLine(queue.Dequeue());

        }
    }
}
