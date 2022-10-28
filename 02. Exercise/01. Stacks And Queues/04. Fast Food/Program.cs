using System;
using System.Linq;
using System.Collections.Generic;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(orders);
            int n = queue.Count;
            int biggestOrder = queue.Max();
            for (int i = 0; i < n; i++)
            {
                if (quantity >= orders[i])
                {
                    quantity -= orders[i];
                    queue.Dequeue();
                }
                else
                {
                    if (quantity - orders[i] <= 0 && queue.Count > 0)
                    {
                        Console.WriteLine(biggestOrder);
                        Console.Write("Orders left: ");
                        Console.Write(String.Join(" ", queue));
                        return;
                    }
                }
            }
            Console.WriteLine(biggestOrder + "\nOrders complete");
        }
    }
}
