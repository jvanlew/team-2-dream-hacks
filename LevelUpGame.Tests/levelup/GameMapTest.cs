using NUnit.Framework;
using levelup;
using System;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
            
            
           

        }

        [Test]
        public void IsPositionValid()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            
            Assert.IsTrue(testObj.IsValid());
             
        }

    
    }
}