using System;
using System.Collections.Generic;
using System.Text;

namespace StackImplementations
{
    public class DIYStack : IStack
    {
        int?[] array = new int?[5];

        public int Peek()
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != null)
                {
                    return (int)array[i];
                }
            }

            throw new Exception("The stack is empty!");
        }

        public int Pop()
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != null)
                {
                    var temp = (int)array[i];
                    array[i] = null;
                    return temp;
                }
            }

            throw new Exception("The stack is empty!");
        }

        public void Push(int item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    return;
                }
            }

            throw new Exception("The stack is full!");
        }
    }
}
