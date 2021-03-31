using System;

namespace Tapshiriq_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0 & n <= 100)
            {

                
                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= n; j++)  
                    {
                        Console.Write(" ");
                        if (j <= n - i)
                            Console.Write("#");
                        if (j == n)
                            Console.Write('\n');

                    }
                    
                }
            }
            else
                Console.WriteLine("n 0 < n <= 100 araliginda olmalidir.");
                
        }
    }
}
