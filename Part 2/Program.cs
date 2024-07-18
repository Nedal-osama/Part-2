namespace Part_2
{
    using System;


    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }


    public interface ICircle : IShape
    {
    }

    public interface IRectangle : IShape
    {
    }


    public class Circle : ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area
        {
            get { return Math.PI * radius * radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Circle with radius " + radius);
        }
    }


    public class Rectangle : IRectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double Area
        {
            get { return length * width; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Rectangle with length " + length + " and width " + width);
        }
    }

    class Program
    {
        static void Main( string[] args)
        {
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            circle.DisplayShapeInfo();
            Console.WriteLine("Area: " + circle.Area);
            Console.WriteLine();

            rectangle.DisplayShapeInfo();
            Console.WriteLine("Area: " + rectangle.Area);
        }
    }
}
