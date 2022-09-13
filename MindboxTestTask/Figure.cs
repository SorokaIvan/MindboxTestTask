namespace MindboxTestTask
{
    public abstract class Figure
    {
        public string FigureName { get; set; }

        public Figure (string figureName)
        {
            FigureName = figureName;
        }

        public abstract double Square();
    }
}
