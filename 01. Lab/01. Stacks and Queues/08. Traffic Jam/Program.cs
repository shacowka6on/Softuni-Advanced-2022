using System;
using System.Linq;
using System.Collections.Generic;


namespace Advanced
{
    class Program
    {
        static void Maain(string[] args)
        {
            int carsThatCanPass = int.Parse(Console.ReadLine());
            var traffic = new Queue<string>();
            int count = 0;
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "end") break;

                if (cmd == "green")
                {
                    if (carsThatCanPass > traffic.Count)
                    {
                        carsThatCanPass = traffic.Count;
                    }
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        Console.WriteLine($"{traffic.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    traffic.Enqueue(cmd);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}