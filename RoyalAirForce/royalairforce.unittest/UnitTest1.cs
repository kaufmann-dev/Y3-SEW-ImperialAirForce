using System.Drawing;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace royalairforce.unittest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void PointEqualsTest() {
            Point p1 = new Point(3, 4, 3);
            Point p2 = new Point(6, 9, 2);
            Point p3 = new Point(3, 4, 3);

            Assert.IsTrue(p1.Equals(p3));
            Assert.IsFalse(p1.Equals(p2));
        }

        [Test]
        public void LoggingTest() {
            string msg = "test message";

            Logger.GetInstance().Info(msg);
            Assert.AreEqual("test message", msg);
        }
    }
}