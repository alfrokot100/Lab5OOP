namespace Lab5NET24
{
    internal class Program
    {
        class Circle
        {
            float Pi = 3.141f;
            int _radius;

            public Circle(int radius)
            {
                this._radius = radius;
            }

            public float getArea()
            {
                return this.Pi * this._radius * this._radius;
            }
        }

        class Triangle
        {
            double _height;
            double _base;

            public Triangle(double width, double height)
            {
                this._height = height;
                this._base = width;
            }

            public double getTriArea() 
            {
                return this._base * this._height / 2;
            }
        }

        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            Console.WriteLine("Arean är: {0}", C1.getArea());

            Circle C2 = new Circle(6);
            Console.WriteLine("Arean är: {0}", C2.getArea());

            Triangle T1 = new Triangle(4,12.54);
            Console.WriteLine("Arean för triangeln är {0}", T1.getTriArea());
        }
    }
}
