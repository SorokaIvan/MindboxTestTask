namespace MindboxTestTask
{
    public class Circle : Figure
    {
        public double Diameter { get; set; }

        public Circle(double diameter) : base("Circle")
        {
            if (diameter <= 0)
            {
                throw new FigureException("У круга не может быть диаметр отрицательным или равен нулю!");
            }

            Diameter = diameter;
        }

        public override double Square()
        {
            const double pi = 3.14;

            return pi * Math.Pow((Diameter / 2), 2);
        }
    }
}
