using LevelUpGame.Library.Entities;
using LevelUpGame.Library.Infrastructure;
using NUnit.Framework;

namespace LevelUpGame.Tests
{
	[TestFixture]
	internal class CloneTests
	{
		[SetUp]
		public void SetUp() {

		}

		[Test]
		public void Character_Should_Clone_Successfully() {
			var origObj = new Character("george");

			var testObj = origObj.Clone();

			Assert.That(testObj, Is.EqualTo(origObj));
		}

		[Test]
		public void GameMap_Should_Clone_Successfully() {
			var origObj = new GameMap();

			var testObj = origObj.Clone();

			Assert.That(testObj, Is.EqualTo(origObj));

		}

		[Test]
		public void GameStatus_Should_Clone_Successfully() {
			var origObj = new GameStatus {
				CurrentCharacter = new Character("george"),
				CurrentPosition = new Position(5, 9),
				StartPosition = new Position(0, 0),
				EndPosition = new Position(7, 3),
				MoveCount = 50
			};

			var testObj = origObj.Clone();

			Assert.That(testObj.MoveCount, Is.EqualTo(origObj.MoveCount));
			Assert.That(testObj.CurrentCharacter, Is.EqualTo(origObj.CurrentCharacter));
		}

		[Test]
		public void Position_Should_Clone_Successfully() {
			var origObj = new Position(1, 2);

			var testObj = origObj.Clone();

			Assert.That(testObj, Is.EqualTo(origObj));

		}
	}
}
