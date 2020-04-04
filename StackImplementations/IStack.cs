using System;

namespace StackImplementations
{
    public interface IStack
    {
        void Push(int item);
        int Pop();
        int Peek();
    }
}
