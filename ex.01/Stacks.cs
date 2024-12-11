using System;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        int[] ints = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

        int toPush = ints[0];
        int toPop = ints[1];
        int toMatch = ints[2];

        int[] nums = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

        Stack<int> stack = new Stack<int>();
        
        for (int i = 0; i < toPush; i++)
        {
            stack.Push(nums[i]);
        }

        int min = int.MaxValue;

        for (int i = 0; i < toPop; i++)
        {
            int current = stack.Pop();

            if(current == toMatch)
            {
                Console.WriteLine("found");
                return;
            }

            if(current < min)
            {
                min = current;
            }
        }

        System.Console.WriteLine(min);
    }
}
