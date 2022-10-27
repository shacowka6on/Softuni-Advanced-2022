using System;
using System.Linq;
using System.Collections.Generic;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(kids);
            int toss = 1;
            while (queue.Count > 1)
            {
                string kid = queue.Dequeue();
                if (toss == n)
                {
                    Console.WriteLine($"Removed {kid}");
                    toss = 1;
                    continue;
                }
                queue.Enqueue(kid);
                toss++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}