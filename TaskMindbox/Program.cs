using FigureLibrary;
using Mindbox_lib;

namespace MindboxTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure();

            #region Радиус круга
            Console.Write("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());
            double circleArea = figure.CalculateCircleArea(radius);
            #endregion

            #region Стороны треугольника
            Console.Write("Введите длину стороны a треугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны b треугольника: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны c треугольника: ");
            double c = double.Parse(Console.ReadLine());
            double triangleArea = figure.CalculateTriangleArea(a, b, c);

            var triangle = new Triangle(a, b, c);
            bool isRightTriangle = triangle.IsRightTriangle();
            #endregion

            Console.WriteLine($"Площадь круга: {circleArea}");
            Console.WriteLine($"Площадь треугольника: {triangleArea}");
            Console.WriteLine($"Прямоугольный треугольник: {isRightTriangle}");
        }
    }
}