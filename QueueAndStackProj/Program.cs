using StackImplementations;
using System;

namespace QueueAndStackProj
{
    class Program
    {
        static void Main(string[] args)
        {
            DIYStack stack = new DIYStack();

            stack.Push(3);
            stack.Push(2);

            Console.WriteLine(stack.Pop());

            stack.Push(7);
            stack.Push(4);
            stack.Push(10);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
