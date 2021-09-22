using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int select_func = 1;
            four_assignment Assignment_4 = new four_assignment();
            while (select_func >=1 & select_func <=4)
            {
                Console.Write("1 for factorial; 2 for prime number; 3 for leap; 4 for lcm: ");
                select_func = Convert.ToInt32(Console.ReadLine());
                if (select_func == 1)
                {
                    Console.Write("Find factorial of the number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Assignment_4.factorial(a);
                }
                else if (select_func == 2)
                {
                    Console.Write("checking number is prime number or not: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Assignment_4.prime_num(a);
                }

                else if (select_func == 3)
                {
                    Console.Write("checking year is leap or not: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Assignment_4.leap_year(a);
                }
                else
                {
                    Console.WriteLine("Find LCM of two numbers: ");
                    Console.Write("First number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Assignment_4.lcm(a,b);
                }
            }
        }
    }
}
