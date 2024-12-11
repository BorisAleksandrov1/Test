using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int stock = int.Parse(Console.ReadLine());

        int[] orders = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();  

        Queue<int> queue = new Queue<int>();
        foreach (int order in orders)
        {
            queue.Enqueue(order);
        }

        int max = int.MinValue;

        while (queue.Count > 0)
        {
            int current = queue.Peek();

            if (current > max)
            {
                max = current;
            }

            if (stock - current >= 0)
            {
                stock -= current;
                queue.Dequeue();
            }
            else
            {
                break;
            }
        }

        System.Console.WriteLine(max);
        
        if(queue.Count > 0)
        {
            System.Console.Write("Orders left: ");
            while(queue.Count > 0)
            {
                System.Console.Write(queue.Dequeue() + " ");
            }
        }
        else
        {
            System.Console.WriteLine("All orders are completed.");
        }

    }
}
