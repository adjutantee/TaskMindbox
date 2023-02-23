namespace Mindbox_testlib
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculateCircleArea_Test()
        {
            Figure figure = new Figure();
            double radius = 1;
            double result = figure.CalculateCircleArea(radius);
            Assert.AreEqual(Math.PI, result);
        }

        [Test]
        public void CalculateTriangleArea_Test()
        {
            Figure figure = new Figure();
            double a = 3;
            double b = 4;
            double c = 5;
            double result = figure.CalculateTriangleArea(a, b, c);
            Assert.AreEqual(6, result);
        }
    }
}