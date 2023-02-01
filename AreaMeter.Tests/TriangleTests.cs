namespace AreaMeter.Tests
{
    public  class TriangleTests
    {
        [Fact]
        public void AreaMath_5and6and8and2Precision_14dot98return()
        {
            double a = 5;
            double b = 6;
            double c = 8;
            int precision = 2;
            double expected = 14.98;

            Triangle triangle = new(a, b, c, precision);
            double actual = triangle.Area;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetPrecision_16_throwException()
        {
            int precision = 16;

            Triangle triangle = new(5, 6, 8);

            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.Precision = precision);
        }

        [Fact]
        public void CheckExistence_5and6and20_throwException()
        {
            double a = 5;
            double b = 6;
            double c = 20;

            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void RightTriangleCheck_6and8and10_trueReturn()
        {
            double a = 6;
            double b = 8;
            double c = 10;
            bool expected = true;

            Triangle triangle = new(a, b, c);
            bool actual = triangle.IsRightTriangle;

            Assert.Equal(expected, actual);
        }
    }
}
