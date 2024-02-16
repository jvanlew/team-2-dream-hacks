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

		[Test]
		public void Calculate_Position_Should_Move_North_Successfully() {
			testObj?.StartPosition.SetPosition(5,5);
			testObj?.CalculatePosition(testObj?.StartPosition, GameController.DIRECTION.NORTH);
			Assert.AreEqual(6, testObj?.StartPosition.PositionY);
		}
 
 		[Test]
		public void Calculate_Position_Should_Move_East_Successfully() {
			testObj?.StartPosition.SetPosition(5,5);
			testObj?.CalculatePosition(testObj?.StartPosition, GameController.DIRECTION.EAST);
			Assert.AreEqual(6, testObj?.StartPosition.PositionX);
		}

 		[Test]
		public void Calculate_Position_Should_Move_South_Successfully() {
			testObj?.StartPosition.SetPosition(5,5);
			testObj?.CalculatePosition(testObj?.StartPosition, GameController.DIRECTION.SOUTH);
			Assert.AreEqual(4, testObj?.StartPosition.PositionY);
		}

 		[Test]
		public void Calculate_Position_Should_Move_West_Successfully() {
			testObj?.StartPosition.SetPosition(5,5);
			testObj?.CalculatePosition(testObj?.StartPosition, GameController.DIRECTION.WEST);
			Assert.AreEqual(4, testObj?.StartPosition.PositionX);
		}

    }
}