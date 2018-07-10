using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            if (n >= 0)
                Factorial(n);
            
        }

        public static void Factorial(int n)
        {
            long result = 1;
            if (n == 0)
                result = 1;
            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
