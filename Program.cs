using System;

namespace PrimeFactor
{
    class Program
    {
        public static void Main(String[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter the number to Check Prime Number");
            n=Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for(i=2;i<=m;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine("Number is Not Prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("Number is Prime");
        }
    }
}