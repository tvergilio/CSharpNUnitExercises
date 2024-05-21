using CSharpNUnitExercises;
using NUnit.Framework;

namespace Tests
{
    public class GeometryTests
    {
        private Geometry geometry;

        [SetUp]
        public void Setup()
        {
            geometry = new Geometry();
        }

        [Test]
        public void Point_StructInitialization()
        {
            var p = new Point(3, 4);
            Assert.Multiple(() =>
            {
                Assert.That(p.X, Is.EqualTo(3));
                Assert.That(p.Y, Is.EqualTo(4));
            });
        }

        [Test]
        public void Point_DistanceTo_CalculatesCorrectDistance()
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(3, 4);

            // The distance between (0,0) and (3,4) is 5
            Assert.That(p1.DistanceTo(p2), Is.EqualTo(5));
        }

        [Test]
        public void Geometry_CalculateDistance_CalculatesCorrectDistance()
        {
            var p1 = new Point(1, 1);
            var p2 = new Point(4, 5);

            // The distance between (1,1) and (4,5) is 5
            Assert.That(geometry.CalculateDistance(p1, p2), Is.EqualTo(5));
        }
    }
}