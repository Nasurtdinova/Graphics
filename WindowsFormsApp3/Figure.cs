using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Figure
    {
        protected int X;
        protected int Y;

        public Figure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public override string ToString()
        {
            return base.ToString() + $";X={X};Y={Y};";
        }
    }

    public class Circle : Figure //объявляем класс окружность
    {
        protected int Radius;

        public Сircle(int X, int Y, int newRadius) : base(X, Y)
        {
            this.Radius = newRadius;
        }

        public void Draw()
        {
            if (Radius != 0)
            {
                Console.WriteLine($"Радиус окружности {Radius} \n Координаты: {X}, {Y}");
            }
            else
                throw (new Exception("Неправильная окружность"));
        }
        public override string ToString()
        {
            return base.ToString() + $"R = {Radius}";
        }
    }

    public class Line : Figure //объявляем класс линия
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

    public class Rectangle : Figure //объявляем класс прямоугольник
    {
        protected int Width;
        protected int Height;
        public Rectangle(int X, int Y, int Width, int Height) : base(X, Y) 
        {
            this.Width = Width;
            this.Height = Height;
        }
        public void Draw()
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"Height = {Height}, Width = {Width}";
        }

    }

    public class Triangle : Figure //объявляем класс треугольник
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
        public override string ToString()
        {
            return base.ToString() + $"X = {X}, Y = {Y}, X1 = {X1}, Y1 = {Y1}, X2 = {X2}, Y2 = {Y2}";
        }
    }
}

