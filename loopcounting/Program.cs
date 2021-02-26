using System;

namespace loopcounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 10; x++)
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 1; i >= 20; i++)
                {
                    Console.WriteLine(i);
                }
            }

            
     
        }
    }
}
