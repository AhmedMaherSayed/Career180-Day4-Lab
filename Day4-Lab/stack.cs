using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    public class stack<T>
    {
        T[] arr;
        int topOfStack;

        public stack(int size = 10)
        {
            arr = new T[size];
            topOfStack = 0;
        }

        public void Push(T item)
        {
            if(topOfStack < arr.Length)
                arr[topOfStack++] = item;
        }

        public T Pop()
        {
            if(topOfStack < arr.Length)
             return arr[--topOfStack];

            return default(T);
        }
    }
}
