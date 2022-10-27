using System;
using System.Linq;
using System.Collections.Generic;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            string[] expression = Console.ReadLine().Split();
            for (int i = 0; i < expression.Length; i++)
            {
                stack.Push(expression[i]);
                if (stack.Count == 3)
                {
                    int first = int.Parse(stack.Pop());
                    var op = stack.Pop();
                    int second = int.Parse(stack.Pop());
                    int result = 0;
                    if (op == "+")
                    {
                        result = first + second;
                    }
                    else
                    {
                        result = Math.Abs(first - second);
                    }
                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}