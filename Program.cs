using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
   internal class Program
    {
       static int GCD(int a,int b)
       {
           if (b == 0)
               return a;
           return GCD(b, a % b);
       }

        static void Main(string[] args)
        {
            Console.Write("enter number 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter number 2:");
            int num2 = int.Parse(Console.ReadLine());

            int result = GCD(num1, num2);
            Console.WriteLine("GCD:{0}",result);
            Console.ReadKey();
        }
    }
}
