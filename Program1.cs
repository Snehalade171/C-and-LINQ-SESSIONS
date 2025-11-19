using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the target no");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("prime no up to" + target + "are");
            for(int num=2;num<=target;num++)
            {
                bool isPrime = true;
                for(int i=2;i*i<=num;i++)
                {
                    if(num%i==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.Write(num + "");
            }
            Console.WriteLine();
        }
    }
}
