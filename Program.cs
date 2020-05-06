﻿using System;

namespace csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"請選擇想使用算式");
            Console.WriteLine($"1.圓面積");
            Console.WriteLine($"2.兩數總和");
            double selectedChoice = Convert.ToDouble(Console.ReadLine());

            if (selectedChoice == 1)
            {
                new Program().toCalcArea();
            }
            else if (selectedChoice == 2)
            {
                new Calc().toCalcSum();
            }
            Console.ReadKey();
        }

        public void toCalcArea()
        {
            string str = "請輸入圓半徑";
            Console.WriteLine($"{str}:");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            Circle circle_test = new Circle(circleRadius);
            Console.WriteLine($"面積為 : {circle_test.getArea()}");
            Console.WriteLine($"類型為 : {circle_test.getType()}");
        }
    }

    class Shape
    {
        protected EShape type;

        protected void getArea()
        {


        }
    }

    enum EShape
    {
        Rectangle,
        Circle,
        Triangle

    }

    class Circle : Shape
    {
        protected double _radius;
        public Circle(double radius)
        {
            _radius = radius;
            type = EShape.Circle;
        }

        public new double getArea()
        {
            return _radius * _radius * Math.PI;
        }

        public EShape getType()
        {
            return type;
        }
    }



    class EnvovleCircle : Circle
    {


        EnvovleCircle(double radius) : base(radius)
        {

            _radius = radius;
        }
    }
}