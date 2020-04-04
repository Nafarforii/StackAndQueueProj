using System;
using System.Collections.Generic;
using System.Text;

namespace QueueImplementation
{
    public interface IQueue
    {
        void Enqueue(int item);
        int Dequeue();
        int Peek();
    }
}
