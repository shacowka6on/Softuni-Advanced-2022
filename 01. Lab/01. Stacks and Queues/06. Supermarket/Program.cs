using System;
using System.Linq;
using System.Collections.Generic;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;

                if (cmd == "Paid")
                {
                    int n = queue.Count;
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(cmd);
                }
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"{queue.Count} people remaining.");
            }
        }
    }
}