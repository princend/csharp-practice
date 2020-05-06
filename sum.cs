using System;
namespace csharp_practice
{

    class Calc
    {
        public double twoValueSum(double a, double b)
        {
            return a + b;
        }


        public void toCalcSum()
        {
            try
            {
                Console.WriteLine($"計算a+b總和");
                Console.WriteLine($"請輸入數字a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"請輸入數字b:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"總和為:{this.twoValueSum(a, b)}");
            }
            catch (System.Exception)
            {
                Console.WriteLine($"請輸入正常格式der數字");
                throw;
            }

        }
    }

}