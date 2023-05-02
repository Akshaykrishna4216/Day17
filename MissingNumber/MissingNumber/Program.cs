using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1=0, s2=0;
            Console.WriteLine("enter size of array");
            int n=int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("enter n-1 elements of array");
            for(int i = 0; i < n-1; i++)
            {
                A[i] =int.Parse(Console.ReadLine());
            }
            for(int i=0; i < n; i++)
            {
                s1 += A[i];
            }
            for(int i=0 ; i <= n ; i++)
            {
                s2 += i;
            }
            Console.WriteLine("missing Element:" + (s2 - s1));
        }
    }
}
