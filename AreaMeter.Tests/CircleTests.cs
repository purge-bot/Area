namespace AreaMeter.Tests
{
    public class CircleTests
    {
        [Fact]
        public void AreaMath_rad60andPrecision2_11309dot73return()
        {
            double radius = 60;
            int precision = 2;
            double expected = 11309.73;

            Circle circle = new(radius, precision);
            double actual = circle.Area;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AreaMath_rad50andPrecisionNull_7853dot981633974483return()
        {
            double radius = 50;
            double expected = 7853.981633974483;

            Circle circle = new(radius);
            double actual = circle.Area;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateCircle_rad0_ArgumentException()
        {
            double radius = 0;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}