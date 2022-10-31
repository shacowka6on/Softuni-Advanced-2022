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
            //int[] cupsCapacity  = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //var queueCups    = new Queue<int>(cupsCapacity);
            //var stackBottles = new Stack<int>(filledBottles);

            //int wastedWaterSum = 0;
            //int wastedResets = 0;
            //int bottles = 0;
            //while (queueCups.Count > 0 && stackBottles.Count > 0)
            //{
            //    var currCup = queueCups.Peek();
            //    if (wastedResets < 0) currCup = wastedResets;
            //    wastedResets = stackBottles.Pop() - Math.Abs(currCup);
            //    if(wastedResets >= 0)
            //    {
            //        wastedWaterSum += wastedResets;
            //        queueCups.Dequeue();
            //        wastedResets = 0;
            //    }
            //}
            //if (stackBottles.Count > 0)
            //    Console.WriteLine($"Bottles: {string.Join(" ", stackBottles)}");
            //if (queueCups.Count > 0)
            //    Console.WriteLine($"Cups: {string.Join(" ", queueCups)}");
            //Console.WriteLine($"Wasted litters of water: {wastedWaterSum}");
        }
    }
}
