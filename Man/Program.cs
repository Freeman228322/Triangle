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
            // Проверка на положительные стороны
            if (first_side <= 0 || second_side <= 0 || third_side <= 0)
                throw new ArgumentException("Все стороны должны быть положительными");

            // Сначала устанавливаем значения сторон
            First_side = first_side;
            Second_side = second_side;
            Third_side = third_side;

            // Проверка существования треугольника
            if (first_side + second_side <= third_side ||
                first_side + third_side <= second_side ||
                second_side + third_side <= first_side)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }

            // Проверка высоты 
            double max_possible_height = 2 * CalculateArea() / GetOsnovanie();
            if (height <= 0 || height > max_possible_height)
            {
                throw new ArgumentException($"Некорректная высота. Допустимый диапазон: 0 < h ≤ {max_possible_height:F2}");
            }

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
        private double CalculateArea()
        {
            double p = GetPerim() / 2;
            return Math.Sqrt(p * (p - First_side) * (p - Second_side) * (p - Third_side));
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(7, 6, 12, 2);

            double number1 = triangle.GetPerim();
            double number2 = triangle.GetPloshad();
            Console.WriteLine($"Периметр со сторонами {triangle.Third_side},{triangle.Second_side},{triangle.First_side} равен {number1}");
            Console.WriteLine($"Основание {triangle.GetOsnovanie()} и высота {triangle.Height}. Площадь равна {number2}");
            WriteLine("asdasd");

            Console.WriteLine("");



        }
    }
}
