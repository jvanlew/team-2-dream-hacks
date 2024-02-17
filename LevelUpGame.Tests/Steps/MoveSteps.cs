using System;
using System.Drawing;
using FluentAssertions;
using LevelUpGame.Library.Entities;
using LevelUpGame.Library.Enumerations;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DotNetExample.Tests.Steps
{
	[Binding]
	public class MoveSteps
	{
		GameController testObj = new GameController();
		int startX, startY;
		MoveDirections direction;
		Position currentPosition;

		[Given(@"the character (.*) starts at position with X-coordinates (.*)")]
		public void givenTheCharacterStartsAtX(string charName, int startX) {
			this.startX = startX;
		}

		[Given(@"starts at Y-coordinates (.*)")]
		public void givenTheCharacterStartsAtY(int startY) {
			this.startY = startY;
		}

		[Given(@"the player chooses to move in (.*)")]
		public void givenPlayerChoosesDirection(String direction) {
			this.direction = (MoveDirections)Enum.Parse(typeof(MoveDirections), direction);
		}

		[Given(@"the current move count is (.*)")]
		public void givenTheCurrentMoveCountIs(int currentMoveCount) {
			testObj.SetCurrentMoveCount(currentMoveCount);
		}

		[When(@"the character moves")]
		public void whenTheCharacterMoves() {
			testObj.SetCharacterPosition(new Position(this.startX, this.startY));
			testObj.Move(this.direction);
			GameStatus status = testObj.GetStatus();
			this.currentPosition = status.CurrentPosition;
		}

		[Then(@"the character is now at position with X-coordinates (.*)")]
		public void checkXCoordinates(int endX) {
			Assert.That(this.currentPosition, Is.Not.Null, "Expected position not null");
			Assert.That(endX, Is.EqualTo(this.currentPosition.PositionX));
		}

		[Then(@"Y-coordinates (.*)")]
		public void checkYCoordinates(int endY) {
			Assert.That(this.currentPosition, Is.Not.Null, "Expected position not null");
			Assert.That(endY, Is.EqualTo(this.currentPosition.PositionY));
		}

		[Then(@"the new move count is (.*)")]
		public void checkNewMoveCount(int endingMoveCount) {
			Assert.That(testObj.GetStatus().MoveCount, Is.EqualTo(endingMoveCount));
		}
	}
}