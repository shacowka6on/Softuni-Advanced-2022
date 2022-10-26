using System;
using System.Linq;
using System.Collections.Generic;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();
            string input = Console.ReadLine();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}
