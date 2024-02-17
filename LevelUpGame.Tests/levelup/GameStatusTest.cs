using NUnit.Framework;
using LevelUpGame.Library.Entities;
using System;
using System.Drawing;

namespace LevelUpGame.Tests
{
	[TestFixture]
	public class GameStatusTest
	{
		private GameStatus testObj;

		[SetUp]
		public void SetUp() {
			testObj = new GameStatus();
		}

		[Test]
		[TestCase("5", "2", "Mike", 200)]
		public void IsPrintingCorrectStatus(int positionX, int positionY, string characterName, int moveCount) {

			testObj.CurrentPosition = new Position(positionX, positionY);
			testObj.CurrentCharacter = new Character(characterName);
			testObj.MoveCount = moveCount;
			Assert.That(testObj.ToString().Contains(characterName));
			Assert.That(testObj.ToString().Contains(moveCount.ToString()));
		}
	}
}