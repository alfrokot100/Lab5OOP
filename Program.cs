namespace Lab5NET24
{
    internal class Program
    {
        //Cirkel klassen
        class Circle
        {
            float Pi = 3.141f;
            int _radius;

            //Konstruktor som tar in användarens värden
            public Circle(int radius)
            {
                this._radius = radius;
            }

            //Retumerrar arean
            public float GetArea()
            {
                return this.Pi * this._radius * this._radius;
            }
        }

        //Triangel klassen
        class Triangle
        {
            double _height;
            double _base;

            public Triangle(double width, double height)
            {
                this._height = height;
                this._base = width;
            }

            public double GetTriArea() 
            {
                return this._base * this._height / 2;
            }
        }

        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            Console.WriteLine("Arean är: {0}", C1.GetArea());

            Circle C2 = new Circle(6);
            Console.WriteLine("Arean är: {0}", C2.GetArea());

            Triangle T1 = new Triangle(4,12.54);
            Console.WriteLine("Arean för triangeln är {0}", T1.GetTriArea());
        }
    }
}
