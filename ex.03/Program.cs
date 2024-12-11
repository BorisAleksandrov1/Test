using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main(string[] args)
    {
        int greenLight = int.Parse(Console.ReadLine()); //seconds
        int freeWindow = int.Parse(Console.ReadLine());
        
        int carsPassed = 0;

        Queue<string> queue = new Queue<string>();
        string cmd = string.Empty;

        while(cmd != "END")
        {
            cmd = Console.ReadLine();
            queue.Enqueue(cmd);

            if(cmd == "green")
            {
                while(greenLight > 0)
                {
                    //time
                    int carLength = 0;

                    if(queue.Count > 0)
                    {
                        carLength = queue.Dequeue().Length;
                    }

                    greenLight -= carLength;

                    
                }
            }
        }
    }
}
