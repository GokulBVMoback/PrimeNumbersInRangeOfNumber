using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the Prime Numbers between 2 to you wanted:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=2; i<=n; i++)
            {
                int prime=1;
                for (int j = 2; j <= i+1; ++j)
                {
                    if (i != j)
                    {
                        prime = i % j;
                        if (prime == 0)
                        {
                            break;
                        }
                        else if (j > i)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }

                }
            }
        }
    }
}
