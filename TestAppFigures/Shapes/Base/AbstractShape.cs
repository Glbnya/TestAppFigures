namespace TestAppFigures.Shapes.Base
{
    /// <summary>
    /// Абстрактный класс фигуры
    /// </summary>
    public abstract class AbstractShape
    {
        private readonly Lazy<double> _area;
        public AbstractShape()
        {
            _area = new Lazy<double>(CalculateArea);
        }
        public double Area
        {
            get { return _area.Value; }
        }
        public abstract double CalculateArea();
    }
}
