namespace Day4_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Queue Implementation
            //var intQueue = new queue<int>(5);

            //intQueue.Push(1);
            //intQueue.Push(2);
            //intQueue.Push(3);
            //intQueue.Push(4);
            //intQueue.Push(5);

            //Console.WriteLine(intQueue.Pop());
            //Console.WriteLine(intQueue.Pop());
            //Console.WriteLine(intQueue.Pop());
            //Console.WriteLine(intQueue.Pop());
            //Console.WriteLine(intQueue.Pop());
            //Console.WriteLine(intQueue.Pop()); 
            #endregion

            #region Stack Implementation
            var intStack = new stack<int>(3);

            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            intStack.Push(4);
            intStack.Push(5);

            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
            Console.WriteLine(intStack.Pop());
            #endregion
        }
    }
}
