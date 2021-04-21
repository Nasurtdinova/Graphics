using System;

namespace Figure
{
    class Program
    {
        static void Main()
        {
            Сircle cir = new Сircle(1, 1, 5);
            cir.Draw();
            Triangle tri = new Triangle(1, 1, 5, 9, 9, 3);
            tri.Draw();
            Line lin = new Line(1, 1, 2, 1);
            lin.Draw();
        }
    }

    class Figure
    {
        protected int X;
        protected int Y;

        public Figure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }

    class Сircle : Figure //объявляем класс окружность
    {
        protected int radius;

        public Сircle(int X, int Y, int radius) : base(X, Y)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            if (radius != 0)
            {
                Console.WriteLine($"Радиус окружности {radius} \n Координаты: {X}, {Y}");
            }
            else
                throw (new Exception("Неправильная окружность"));
        }
    }

    class Line : Figure //объявляем класс линия
    {
        protected int X1;
        protected int Y1;
        protected int length;
        public Line(int X, int Y, int X1, int Y1) : base(X, Y)
        {
            this.X1 = X1;
            this.Y1 = Y1;
        }
        public void Draw()
        {
            if (X != 0 && Y != 0)
            {
                length = (int)Math.Sqrt((X - X1) * (X - X1) + (Y - Y1) * (Y1 - Y));
                Console.Write($"Длина линии {length}");
            }
            else
                throw (new Exception("Неправильная линия"));
        }
    }

    class Rectangle : Figure //объявляем класс прямоугольник
    {
        public Rectangle(int X, int Y) : base(X, Y) { }
    }

    class Triangle : Figure //объявляем класс треугольник
    {
        protected int X1;
        protected int Y1;
        protected int X2;
        protected int Y2;
        public Triangle(int X, int Y, int X1, int Y1, int X2, int Y2) : base(X, Y)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
        }

        public void Draw()
        {
            int AB = (int)Math.Sqrt((X1 - X) * (X1 - X) + (Y1 - Y) * (Y1 - Y));
            int BC = (int)Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1));
            int CA = (int)Math.Sqrt((X - X2) * (X - X2) + (Y - Y2) * (Y - Y2));
            if (AB >= BC + CA || CA >= BC + AB || BC >= AB + CA)
            {
                throw (new Exception("Недопустимый размер треугольника. Точки лежат на одной прямой или длина ребра равна нулю"));
            }
            else
            {
                Console.WriteLine($"Стороны треугольника {AB}, {BC}, {CA}");
            }
        }
    }
}
