using TestAppFigures;
using TestAppFigures.Shapes;

namespace UnitTesting
{
    public class ShapesTesting
    {
        /// <summary>
        /// Негативное значение радиуса
        /// </summary>
        [Fact]
        public void NegativeRadiusCircleTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
        /// <summary>
        /// Проверка площади при положительном значении радиуса
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="expected"></param>
        /// <param name="notExpected"></param>
        [Theory]
        [InlineData(1, 1, 1.1)]
        [InlineData(3, 3, 3.00001)]
        public void PositiveRadiusCircleTest(double radius, double expected, double notExpected)
        {
            Circle circle = new Circle(radius);
            Assert.NotEqual(notExpected, circle.Radius);
            Assert.Equal(expected, circle.Radius);
        }
        /// <summary>
        /// Проверка нахождения площади окружности
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="calculatedArea"></param>
        [Theory]
        [InlineData(7, 154)]
        [InlineData(44, 6082)]
        public void AreaCalculationCircleTest(double radius, double calculatedArea)
        {
            Circle circle = new Circle(radius);
            Assert.Equal(calculatedArea, Math.Round(circle.Area));
        }
        /// <summary>
        /// Проверка на попытки добавить несуществующий треугольник
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        public void NegativeSideTriangleTest(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
        /// <summary>
        /// Проверка на попытки добавить несуществующий треугольник 
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        [Theory]
        [InlineData(3, 4, 17)]
        [InlineData(2, 1, 4)]
        [InlineData(5, 4, 0.5)]
        public void DoesNotExistTriangleTest(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
        /// <summary>
        /// Проверка подсчета площади треугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <param name="expectedArea"></param>
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(20, 11, 10, 31.9756)]
        [InlineData(4, 4, 4, 6.9282)]
        public void AreaCalculationTriangleTest(double sideA, double sideB, double sideC, double expectedArea)
        {
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Equal(expectedArea, Math.Round(triangle.Area, 4));
        }
    }
}