using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class four_assignment
    {
        public void factorial(int num)
        {
            int ans = 1;
            int iter = num;
            int check_ = 1;
            //Console.WriteLine("Hello World!");
            while (iter != 0 && check_ == 1)
            {
                ans *= iter;
                iter--;
                if (ans > 2147483647)
                {
                    check_ = 0;
                    Console.WriteLine("exceeding the maximum of int32");
                }
                else if (ans < -2147483648)
                {
                    check_ = 0;
                    Console.WriteLine("exceeding the minimum of int32");
                }
            }
            if (check_ == 1)
            {
                Console.WriteLine(ans);
            }
        }
        public void leap_year(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("This is leap year.");
            }
            else
            {
                Console.WriteLine("This is not leap year.");
            }
        }
        public void lcm(int a, int b)
        {
            int[] ans = { };
            int max_ab;
            int gcd =1;
            int ans_;
            if (a >= b)
            {
                max_ab = b;
            }
            else
            {
                max_ab = a;
            }
            for (int i=1; i<=max_ab;i++)
            {
                if (a%i==0 & b%i==0)
                {
                    gcd = i;
                }
            }
            ans_ = a * b / gcd;
            if (ans_ == 0)
            {
                Console.WriteLine($"The LCM of two numbers ({a},{b}) exceeds the space of int32.");
            }
            else
            {
                Console.WriteLine($"The LCM of two numbers ({a},{b}) is {ans_}.");
            }
            
        }
        public void prime_num (int a)
        {
            int ans_ = a;
            for (int i = 2; i <= a; i++)
            {
                if (a%i == 0 & i!= a)
                {
                    ans_ = i;
                    break;
                }
            }
            if (ans_ == a)
            {
                Console.WriteLine($"{a} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{a} is not a prime number.");
            }
        }
    }
}
