using System;
using System.Linq;
using System.Collections.Generic;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var indexes = new Stack<int>();
            string expression = Console.ReadLine();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    Console.WriteLine(expression.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
