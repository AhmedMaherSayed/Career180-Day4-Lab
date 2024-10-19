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
            //var intStack = new stack<int>(3);

            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);
            //intStack.Push(4);
            //intStack.Push(5);

            //Console.WriteLine(intStack.Pop());
            //Console.WriteLine(intStack.Pop());
            //Console.WriteLine(intStack.Pop());
            //Console.WriteLine(intStack.Pop());
            #endregion

            #region Lab Part 2
            var dic = new Dictionary<Question, List<Answer>>();

            var question1 = new Question(1, "OOP stands for ...?", 10);
            var question2 = new Question(2, "DP stands for ...?", 5);

            var q1Answer1 = new Answer(1, "Object Base Programming!");
            var q1Answer2 = new Answer(2, "Object Oriented Programming!");
            var q1Answer3 = new Answer(3, "Functional Programming!");
            var q1Answer4 = new Answer(4, "Event-Driven Programming!");

            dic[question1] = new List<Answer>() { q1Answer1, q1Answer2, q1Answer3, q1Answer4 };

            var q2Answer1 = new Answer(1, "Design Patterns");
            var q2Answer2 = new Answer(2, "Design Principles");
            var q2Answer3 = new Answer(3, "Design Inversion");
            var q2Answer4 = new Answer(4, "Design Injection");

            dic[question2] = new List<Answer> { q2Answer1, q2Answer2, q2Answer3, q2Answer4 };
           foreach ( KeyValuePair<Question, List<Answer>> pair in dic )
            {
                Console.WriteLine(pair.Key + "\n");

                foreach (var answer in pair.Value)
                    Console.WriteLine(answer);
                Console.WriteLine("\n-------------------------------------\n");
            }
            #endregion
        }
    }
}
