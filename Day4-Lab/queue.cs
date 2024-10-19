using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Lab
{
    public class queue<T> 
    {
        T[] arr;
        int Enqueue;
        int Dequeue;

        public queue(int size = 10)
        {
            arr = new T[size];
            Enqueue = 0;
            Dequeue = 0;
        }

        public void Push(T item)
        {
            if(Enqueue < arr.Length)
                arr[Enqueue++] = item;
        }

        public T Pop()
        {
            if(Dequeue >= 0 && Dequeue < arr.Length && Dequeue <= Enqueue)
                return arr[Dequeue++];
            else
                return default(T);
        }
    }
}
