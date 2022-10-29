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
            int priceEachBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueIntelligence = int.Parse(Console.ReadLine());

            var queueLocks = new Queue<int>(locks);
            var stackBullets = new Stack<int>(bullets);

            int gunBarrelCounter = 0;
            int allBulletsCount = stackBullets.Count;
            while (true)
            {
                if (queueLocks.Count <= 0 && allBulletsCount >= 0)
                {
                    Console.WriteLine($"{allBulletsCount} bullets left. Earned ${valueIntelligence}");
                    return;
                }
                else if (stackBullets.Count <= 0 && queueLocks.Count > 0 || allBulletsCount <= 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
                    return;
                }
                int currLock = queueLocks.Peek();
                int currBullet = stackBullets.Peek();
                if (currLock >= currBullet)
                {
                    Console.WriteLine("Bang!");
                    currLock = queueLocks.Dequeue();
                    currBullet = stackBullets.Pop();
                    gunBarrelCounter++;
                    allBulletsCount--;
                    valueIntelligence -= priceEachBullet;
                }
                else if (currLock < currBullet)
                {
                    Console.WriteLine("Ping!");
                    currBullet = stackBullets.Pop();
                    gunBarrelCounter++;
                    allBulletsCount--;
                    valueIntelligence -= priceEachBullet;
                }
                if (gunBarrelCounter >= sizeOfGunBarrel)
                {
                    if (allBulletsCount > 0)
                    {
                        Console.WriteLine("Reloading!");
                        gunBarrelCounter = 0;
                    }
                }
            }
        }
    }
}
