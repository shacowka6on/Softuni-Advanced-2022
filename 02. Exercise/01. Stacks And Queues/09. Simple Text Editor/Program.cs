using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            //· 1 someString - appends someString to the end of the text.
            //· 2 count - erases the last count elements from the text.
            //· 3 index - returns the element at position index from the text.
            //· 4 - undoes the last not undone command of type 1 or 2
            //  and returns the text to the state before that operation.

            //Input
            //The first line contains n – the number of operations.
            //· Each of the following n lines contains the name of the operation,
            //  followed by the command argument, if any, separated by space in the
            //  following format "CommandName Argument".

            //Output
            //· For each operation of type 3 print a single line with the returned
            //  character of that operation.

            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                int action = int.Parse(cmd[0]);
                switch (action)
                {
                    case 1:
                        stack.Push(s.ToString());
                        s.Append(cmd[1]);
                        break;
                    case 2:
                        stack.Push(s.ToString());
                        int count = int.Parse(cmd[1]);
                        s = s.Remove(s.Length - count, count);
                        break;
                    case 3:
                        int index = int.Parse(cmd[1]);
                        if (index > 0 && index <= s.Length)
                        {
                            Console.WriteLine(s[index - 1]);
                        }
                        break;
                    case 4:
                        s = new StringBuilder(stack.Pop());
                        break;
                }
            }
        }
    }
}
