using NUnit.Framework;
using levelup;
using System;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position();
            
            
           

        }

        [Test]
        public void IsPositionValid()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(1,2);
            Assert.IsTrue(testObj.isValid());
             
        }
    }
}