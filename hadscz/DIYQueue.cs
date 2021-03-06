﻿using System;

namespace QueueImplementation
{
    public class DIYQueue : IQueue
    {
        int?[] array = new int?[5];

        public int? Dequeue()
        {
            int? temp = array[0];
            array[0] = null;
            for (int i = 1; i < array.Length; i++)
            {
                array[i - 1] = array[i];
            }
            array[array.Length - 1] = null;
            return temp;
        }

        public void Enqueue(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    return;
                }
            }

            throw new Exception("The queue is full!");
        }

        public int Peek()
        {
            return array[0] ?? throw new Exception("Queue is empty!");
        }
    }
}
