using ClassGeometry;
namespace TestGeometry

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ClassGeometry.Rectangle rec = new ClassGeometry.Rectangle();
            Assert.NotNull(rec);
        }
        [Fact]
        public void CreateTriangle()
        {
            ClassGeometry.Triangle tri = new ClassGeometry.Triangle();
            Assert.NotNull(tri);
        }

        [Fact]
        public void RectangleArea_check()
        {
            ClassGeometry.Rectangle rectangle = new ClassGeometry.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Area();

            Assert.Equal(20, res);
        }

        [Fact]
        public void RectangleArea_checkException() 
        {
            ClassGeometry.Rectangle rectangle = new ClassGeometry.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Area());

            Assert.Contains("error!", ex.Message.ToString());
        }

        [Fact]
        public void RectanglePerimetre_check()
        {
            ClassGeometry.Rectangle rectangle = new ClassGeometry.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Perimeter();

            Assert.Equal(24, res);
        }

        [Fact]
        public void RectanglePerimetre_checkException()
        {
            ClassGeometry.Rectangle rectangle = new ClassGeometry.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Perimeter());

            Assert.Contains("error!", ex.Message.ToString());
        }
    }
}