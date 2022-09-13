namespace MindboxTestTask
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC) : base("Triangle")
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new FigureException("У треугольника не может быть сторона(ы) отрицательным!");
            }
            if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
            {
                throw new FigureException("У треугольника не может быть сторона больше суммы двух других)");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double Square()
        {
            var p = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool CheckRightTriangle()
        {
            return Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);
        }
    }
}
