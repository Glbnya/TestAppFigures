using TestAppFigures.Shapes.Base;

namespace TestAppFigures.Shapes
{
    public class Triangle : AbstractShape
    {
        public Triangle(double a, double b, double c)
        {
            if (!DoesTriangleExist(a, b, c))
                throw new ArgumentException("Такого треугольника не существует!");

            SideA = a;
            SideB = b;
            SideC = c;
        }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        /// <summary>
        /// Нахождение площади треугольника 
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            double semiP = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiP*(semiP-SideA)*(semiP-SideB)*(semiP-SideC));
        }
        /// <summary>
        /// Является ли треугольник прямоугольным, добавил округление для случаев, когда результат получается примерным(10,10,14.14)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            if (Math.Round(SideA * SideA + SideB * SideB) == Math.Round(SideC * SideC) 
                || Math.Round(SideA * SideA + SideC * SideC) == Math.Round(SideB * SideB) 
                || Math.Round(SideC * SideC + SideB * SideB) == Math.Round(SideA * SideA))
                return true;
            return false;

        }
        /// <summary>
        /// Существует ли такой треугольник
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool DoesTriangleExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;

            if (a + b <= c || a + c <= b || b + c <= a)
                return false;

            return true;
        }
    }
}
