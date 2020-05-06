using System;
namespace csharp_practice
{
    class Fib
    {


        public void toCalcFib()
        {

            Console.WriteLine("請輸入位數:");
            int num = Convert.ToInt32(Console.ReadLine());
            int value = 0;
            for (int i = 0; i < num; i++)
            {
                value += fib(i);
                Console.WriteLine($"第{i+1}次 : {value}");
            }
        }


        private static int fib(int num)
        {
            if (num <= 2) { return 1; }
            else
            {
                return fib(num - 1) + fib(num - 2);
            }

        }
    }
}