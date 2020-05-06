using System;
namespace csharp_practice
{
    class Hw1
    {

        public void Calc()
        {
            int num = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    num += i;
                }
            }

            Console.WriteLine($"{num}");
        }
    }
}