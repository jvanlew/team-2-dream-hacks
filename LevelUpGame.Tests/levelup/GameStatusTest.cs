using NUnit.Framework;
using levelup;
using System;
using System.Drawing;

namespace levelup
{
    [TestFixture]
    public class GameStatusTest
    {
        private GameStatus? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameStatus();
            
            
           

        }

        [Test]
        public void IsPrintingCorrectStatus()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.SetGameStatusValues("Mike",5,2);
            GameStatus.moveCount = 200;
            Assert.IsNotNull(testObj.toString());
             
        }

    
    }
}