using System;
using System.Linq;
using System.Collections.Generic;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();

            int n = int.Parse(data[0]); //representing the number of elements to enqueue into the stack
            int s = int.Parse(data[1]); //representing the number of elements to dequeue from the stack
            int x = int.Parse(data[2]); //an element that you should look for in the stack

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            if (queue.Count - s <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (queue.Count - s > 0)
            {
                for (int i = 0; i < s; i++)
                {
                    queue.Dequeue();
                }
            }
            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
