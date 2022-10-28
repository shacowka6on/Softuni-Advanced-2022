using System;
using System.Linq;
using System.Collections.Generic;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries) 
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(clothes);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
