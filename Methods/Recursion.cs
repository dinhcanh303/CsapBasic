﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Recursion
    {
        static void Main()
        {
            // Quan trong la tim dc diem dung 
             
            Console.WriteLine("n! =" + GiaiThua(10));

            // De Quy 
            Console.WriteLine("n! =" + GT(10));


            Console.WriteLine("Fibo =" + Fibo(10));


        }

        static long GiaiThua(int n)
        {
            long g = 1;
            for (int i = 1; i <= n; i++)
            {
                g *= i;
            }

            return g;
        }
        // F0 = 0 , F1 = 1 
        // Fn = Fn -1 + Fn-2
        static long Fibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
        }

        // De que nay ton nhieu thoi gian hon ton nhieu bo nho hon 
        // n! = n* (n-1)!

        static long GT(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * GT(n - 1);
            }
        }
    }
}
