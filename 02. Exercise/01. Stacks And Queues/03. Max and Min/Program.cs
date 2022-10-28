using System;
using System.Linq;
using System.Collections.Generic;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (queries[0])
                {
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default:
                        stack.Push(queries[1]);
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
