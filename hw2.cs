using System;
using System.Collections.Generic;

namespace csharp_practice
{
    class Hw2
    {
        public void logList()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };


            names.Add("Khan");
            names.Add("Kanah");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}");
            }

            Console.WriteLine($"My name is {names[2]}");
            Console.WriteLine($"The list has {names.Count} people in it");


            var index = names.IndexOf("Felipe");
            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }


            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }
        }



        public void getFibList()
        {
            var fibList = new List<int> { 1, 1 };
            for (int i = 2; i < 20; i++)
            {
                fibList.Add(fibList[i - 2] + fibList[i - 1]);
            }
            foreach (var item in fibList)
            {
                Console.WriteLine($"數值:{item}");
            }
        }

    }
}