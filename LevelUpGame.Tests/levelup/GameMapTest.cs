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
		public void SetUp() {
			testObj = new GameMap();
		}

		[Test]
		public void IsCorrectPositionValid() {
			testObj?.StartPosition.SetPosition(1, 2);
			Assert.IsTrue(testObj.IsValidPosition(testObj.StartPosition));

		}

		[Test]
		public void IsNegativeXFailing() {
			testObj?.StartPosition.SetPosition(-1, 2);
			Assert.IsFalse(testObj.IsValidPosition(testObj.StartPosition));

		}


		[Test]
		public void IsNegativeYFailing() {
			testObj?.StartPosition.SetPosition(1, -2);
			Assert.IsFalse(testObj.IsValidPosition(testObj.StartPosition));

		}


		[Test]
		public void IsHigherThan9YFailing() {
			testObj?.StartPosition.SetPosition(2, 10);
			Assert.IsFalse(testObj.IsValidPosition(testObj.StartPosition));

		}
		[Test]
		public void CheckFirstCorner() {
			testObj?.StartPosition.SetPosition(0, 0);
			Assert.IsTrue(testObj.IsValidPosition(testObj.StartPosition));

		}

		[Test]
		public void CheckSecondCorner() {
			testObj?.StartPosition.SetPosition(0, 9);
			Assert.IsTrue(testObj.IsValidPosition(testObj.StartPosition));

		}

		[Test]
		public void CheckThirdCorner() {
			testObj?.StartPosition.SetPosition(9, 0);
			Assert.IsTrue(testObj.IsValidPosition(testObj.StartPosition));

		}

		[Test]
		public void CheckFourthCorner() {
			testObj?.StartPosition.SetPosition(9, 9);
			Assert.IsTrue(testObj.IsValidPosition(testObj.StartPosition));

		}
    
    }
}