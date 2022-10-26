using System;
using System.Linq;
using System.Collections.Generic;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "end") break;

                string[] tokens = input.Split(' ');
                string action = tokens[0];
                switch (action)
                {
                    case "add":
                        stack.Push(int.Parse(tokens[1]));
                        stack.Push(int.Parse(tokens[2]));
                        break;
                    case "remove":
                        int n = int.Parse(tokens[1]);
                        if (stack.Count >= n)
                        {
                            for (int i = 0; i < n; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}