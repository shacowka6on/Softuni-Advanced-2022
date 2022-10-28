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

            int n = int.Parse(data[0]); //representing the number of elements to push into the stack
            int s = int.Parse(data[1]); //representing the number of elements to pop from the stack
            int x = int.Parse(data[2]); //an element that you should look for in the stack

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }
            if (stack.Count - s <= 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (stack.Count - s > 0)
            {
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
                }
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
