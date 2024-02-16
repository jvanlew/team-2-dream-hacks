using NUnit.Framework;

namespace levelup
{
	[TestFixture]
	public class GameMapTest
	{
		private GameMap testObj;

		[SetUp]
		public void SetUp() {
			testObj = new GameMap();
		}

		[Test]
		public void Valid_Position_Should_Be_Valid() {
			var currPos = new Position(3, 6);
			Assert.IsTrue(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Negative_X_Positions_Should_Be_Invalid() {
			var currPos = new Position(-1, 2);
			Assert.IsFalse(testObj?.IsValidPosition(currPos));
		}


		[Test]
		public void Negative_Y_Positions_Should_Be_Invalid() {
			var currPos = new Position(1, -2);
			Assert.IsFalse(testObj?.IsValidPosition(currPos));
		}


		[Test]
		public void Position_Y_Greater_Than_9_Should_Be_Invalid() {
			var currPos = new Position(2, 10);
			Assert.IsFalse(testObj?.IsValidPosition(currPos));

		}
		[Test]
		public void Lower_Left_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(0, 0);
			Assert.IsTrue(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Upper_Left_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(0, 9);
			Assert.IsTrue(testObj.IsValidPosition(currPos));

		}

		[Test]
		public void Lower_Right_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(9, 0);
			Assert.IsTrue(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Upper_Right_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(9, 9);
			Assert.IsTrue(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Calculate_Position_Should_Move_North_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, LevelUpGame.levelup.Enumerations.MoveDirections.North);
			Assert.AreEqual(++currPos.PositionY, newPos.PositionY);
		}

		[Test]
		public void Calculate_Position_Should_Move_East_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, LevelUpGame.levelup.Enumerations.MoveDirections.East);
			Assert.AreEqual(++currPos.PositionX, newPos.PositionX);
		}

		[Test]
		public void Calculate_Position_Should_Move_South_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, LevelUpGame.levelup.Enumerations.MoveDirections.South);
			Assert.AreEqual(--currPos.PositionY, newPos.PositionY);
		}

		[Test]
		public void Calculate_Position_Should_Move_West_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, LevelUpGame.levelup.Enumerations.MoveDirections.West);
			Assert.AreEqual(--currPos.PositionX, newPos.PositionX);
		}

	}
}