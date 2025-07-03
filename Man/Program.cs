global using static System.Console;
using System;

namespace Man
{
    
    class Triangle
    {
        private double first_side;
        public double First_side
        {
            get => first_side;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                first_side = value;
            }
        }
        private double second_side;
        public double Second_side
        {
            get => second_side;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                second_side = value;
            }
            

        }


        private double third_side;
        public double Third_side
        {
            get => third_side;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                third_side = value;

            }
        }
        private double height;
        public double Height 
        {
            get => height;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Отрицательное значение");
                }
                height = value;
            }
        }
        public Triangle(double first_side, double second_side, double third_side, double height)
        {
            First_side = first_side;
            Second_side = second_side;
            Third_side = third_side;
            Height = height;

        }
        public double GetPerim() 
        {
            return (First_side + Second_side + Third_side);
        }
        public double GetOsnovanie() 
        {
            return (Math.Max(First_side, Math.Max(Second_side, Third_side)));
        }

        public double GetPloshad()
        {
            return (Height * GetOsnovanie() / 2);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 6, 12, 2);

            double number1 = triangle.GetPerim();
            double number2 = triangle.GetPloshad();
            Console.WriteLine($"Периметр со сторонами {triangle.Third_side},{triangle.Second_side},{triangle.First_side} равен {number1}");
            Console.WriteLine($"Основание {triangle.GetOsnovanie()} и высота {triangle.Height}. Площадь равна {number2}");
            WriteLine("asdasd");





        }
    }
}
