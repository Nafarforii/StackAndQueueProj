using System;

namespace QueueImplementation
{
    public class DIYQueue : IQueue
    {
        int?[] array = new int?[5];

        public int Dequeue()
        {
            int? temp = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                array[0] = null;
                array[i - 1] = array[i];
            }
            return (int)temp;
        }

        public void Enqueue(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    break;
                }
            }
        }

        public int Peek()
        {
            return (int)array[0];
        }
    }
}
