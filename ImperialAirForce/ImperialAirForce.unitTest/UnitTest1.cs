using System.Drawing;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace ImperialAirForce.unitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsPointLegalTest() {
            Point p1 = new Point(14, 14, 4);
            Point p2 = new Point(-3, 15, 5);
            Point p3 = new Point(16, 15, 5);
            
            Map map = new Map();
            Assert.IsTrue(map.IsPointLegal(p1));
            Assert.IsFalse(map.IsPointLegal(p2));
            Assert.IsFalse(map.IsPointLegal(p3));
        }

        [Test]
        public void LoggerTest() {
            string message = "Regenbogen";

            Logger.GetInstance().Info(message);
            Assert.AreEqual("Regenbogen", message);
        }

        [Test]
        public void EqualsTest() {
            Point p1 = new Point(5, 3, 7);
            Point p2 = new Point(5, 3, 7);
            Point p3 = new Point(4, 3, 3);

            Assert.IsTrue(p1.Equals(p2));
            Assert.IsFalse(p1.Equals(p3));
        }

        [Test]
        public void AircraftFactoryTest() {
            
        }
    }
}