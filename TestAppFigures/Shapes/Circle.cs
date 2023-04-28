using TestAppFigures.Shapes.Base;

namespace TestAppFigures
{
    public class Circle : AbstractShape
    {
        public Circle(double radius)
        {
            if (!DoesCircleExist(radius))
                throw new ArgumentException("Радиус не может быть равен меньше или равен 0!");

           Radius = radius;
        }
        public double Radius { get; }
        /// <summary>
        /// Метод нахождения площади окружности
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {

            return Math.PI * Math.Pow(Radius, 2);

        }
        /// <summary>
        /// Проверка существования окружности
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        private bool DoesCircleExist(double radius)
        {
            if(radius <= 0) 
                return false;

            return true;
        }
    }
}
