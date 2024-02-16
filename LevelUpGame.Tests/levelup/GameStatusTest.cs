using NUnit.Framework;
using levelup;
using System;
using System.Drawing;

namespace levelup
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
			Assert.IsTrue(testObj.ToString().Contains(characterName));
			Assert.IsTrue(testObj.ToString().Contains(moveCount.ToString()));
		}
	}
}