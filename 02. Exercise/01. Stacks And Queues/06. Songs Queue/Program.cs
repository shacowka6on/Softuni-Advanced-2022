using System;
using System.Linq;
using System.Collections.Generic;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var queue = new Queue<string>(songs);
            while (queue.Count > 0)
            {
                string cmd = Console.ReadLine();
                string action = cmd.Split()[0];
                switch (action)
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", queue));
                        break;
                    default:
                        string songToAdd = String.Empty;
                        for (int i = 4; i < cmd.Length; i++)
                        {
                           songToAdd += cmd[i];
                        }
                        if (!queue.Contains(songToAdd))
                        {
                            queue.Enqueue(songToAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
