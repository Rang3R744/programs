using System;

namespace Lab6
{
    public abstract class Animal
    {
        public abstract void Move();
    }

    public class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Птах летить");
        }
    }

    public class Fish : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Риба плаває");
        }
    }

    public abstract class Shape
    {
        public abstract void Describe();
    }

    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    public class Circle : Shape, IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void Describe()
        {
            Console.WriteLine($"Коло з радіусом {Radius}");
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override void Describe()
        {
            Console.WriteLine($"Прямокутник (ширина: {Width}, висота: {Height})");
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return (Width +  Height) * 2;
        }
    }

    public interface IRunnable
    {
        void Run(int distance);
    }

    public class Athlete : IRunnable
    {
        public string Name { get; }

        public Athlete(string name)
        {
            Name = name;
        }

        public void Run(int distance)
        {
            Console.WriteLine($"{Name} пробіг {distance} метрів");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЛАБОРАТОРНА №6 (інтерактивна версія) ===");

            Console.Write("\nВиберіть тварину (bird/fish): ");
            string? animalType = Console.ReadLine()?.ToLower();

            Animal? animal = animalType switch
            {
                "bird" => new Bird(),
                "fish" => new Fish(),
                _ => null
            };

            if (animal != null)
                animal.Move();
            else
                Console.WriteLine("Невідомий тип тварини.");

            Console.Write("\nВиберіть фігуру (circle/rectangle): ");
            string? shapeType = Console.ReadLine()?.ToLower();

            if (shapeType == "circle")
            {
                Console.Write("Введіть радіус: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                Circle circle = new Circle(radius);
                circle.Describe();
                Console.WriteLine($"Площа: {circle.CalculateArea():F2}");
                Console.WriteLine($"Периметр: {circle.CalculatePerimeter():F2}");
            }
            else if (shapeType == "rectangle")
            {
                Console.Write("Введіть ширину: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть висоту: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Rectangle rect = new Rectangle(width, height);
                rect.Describe();
                Console.WriteLine($"Площа: {rect.CalculateArea():F2}");
                Console.WriteLine($"Периметр: {rect.CalculatePerimeter():F2}");
            }
            else
            {
                Console.WriteLine("Невідома фігура.");
            }

            Console.Write("\nВведіть ім'я спортсмена: ");
            string? name = Console.ReadLine();

            Console.Write("Введіть дистанцію (м): ");
            int distance = Convert.ToInt32(Console.ReadLine());

            Athlete athlete = new Athlete(name ?? "Без імені");
            athlete.Run(distance);

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
