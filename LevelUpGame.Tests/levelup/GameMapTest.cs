using NUnit.Framework;
using LevelUpGame.Library.Entities;
using LevelUpGame.Library.Enumerations;

namespace LevelUpGame.Tests
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
			Assert.That(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Negative_X_Positions_Should_Be_Invalid() {
			var currPos = new Position(-1, 2);
			Assert.That(testObj.IsValidPosition(currPos), Is.False);
		}


		[Test]
		public void Negative_Y_Positions_Should_Be_Invalid() {
			var currPos = new Position(1, -2);
			Assert.That(testObj.IsValidPosition(currPos), Is.False);
		}


		[Test]
		public void Position_Y_Greater_Than_9_Should_Be_Invalid() {
			var currPos = new Position(2, 10);
			Assert.That(testObj.IsValidPosition(currPos), Is.False);

		}
		[Test]
		public void Lower_Left_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(0, 0);
			Assert.That(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Upper_Left_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(0, 9);
			Assert.That(testObj.IsValidPosition(currPos));

		}

		[Test]
		public void Lower_Right_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(9, 0);
			Assert.That(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Upper_Right_Corner_Position_Should_Be_Valid() {
			var currPos = new Position(9, 9);
			Assert.That(testObj.IsValidPosition(currPos));
		}

		[Test]
		public void Calculate_Position_Should_Move_North_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, MoveDirections.North);
			Assert.That(newPos.PositionY, Is.EqualTo(++currPos.PositionY));
		}

		[Test]
		public void Calculate_Position_Should_Move_East_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, MoveDirections.East);
			Assert.That(newPos.PositionX, Is.EqualTo(++currPos.PositionX));
		}

		[Test]
		public void Calculate_Position_Should_Move_South_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, MoveDirections.South);
			Assert.That(newPos.PositionY, Is.EqualTo(--currPos.PositionY));
		}

		[Test]
		public void Calculate_Position_Should_Move_West_Successfully() {
			var currPos = new Position(5, 5);
			var newPos = testObj.CalculateNewPosition(currPos, MoveDirections.West);
			Assert.That(newPos.PositionX, Is.EqualTo(--currPos.PositionX));
		}
	}
}