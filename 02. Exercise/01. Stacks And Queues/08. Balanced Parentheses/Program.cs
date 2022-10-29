using System;
using System.Linq;
using System.Collections.Generic;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var queue = new Queue<char>(input);

            int counter = 0;
            bool check = true;

            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            while (queue.Count > 0)
            {
                var first = queue.Dequeue();
                var next = queue.Peek();

                if (first == '{')
                {
                    if (next == '}')
                    {
                        queue.Dequeue();
                        counter = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }
                else if (first == '(')
                {
                    if (next == ')')
                    {
                        queue.Dequeue();
                        counter = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }
                else if (first == '[')
                {
                    if (next == ']')
                    {
                        queue.Dequeue();
                        counter = 0;
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(first);
                    }
                }
                else
                {
                    queue.Enqueue(first);
                }

                counter++;

                if (counter == queue.Count)
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
    
}
