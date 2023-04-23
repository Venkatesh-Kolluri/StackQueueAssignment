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
            PeekPop stack = new PeekPop();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine(stack.Peek());

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
