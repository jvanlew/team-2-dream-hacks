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
        public void IscorrectPositionValid()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(1,2);
            Assert.IsTrue(testObj.isValid());
             
        }

        [Test]
        public void IsNegativeXFailing()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(-1,2);
            Assert.IsFalse(testObj.isValid());
             
        }

       
       [Test]
        public void IsNegativeYFailing()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(1,-2);
            Assert.IsFalse(testObj.isValid());
             
        }

        
        [Test]
        public void IsHigherThan9YFailing()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(2,10);
            Assert.IsFalse(testObj.isValid());
             
        }
        [Test]
        public void CheckfirstCorner()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(0,0);
            Assert.IsTrue(testObj.isValid());
             
        }

        [Test]
        public void CheckSecondCorner()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(0,9);
            Assert.IsTrue(testObj.isValid());
             
        }

        [Test]
        public void CheckThirdCorner()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(9,0);
            Assert.IsTrue(testObj.isValid());
             
        }

        [Test]
        public void CheckFourthCorner()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetPosition(9,9);
            Assert.IsTrue(testObj.isValid());
             
        }
    }
}