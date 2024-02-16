using System;
using System.Drawing;
using FluentAssertions;
using levelup;
using LevelUpGame.levelup.Enumerations;
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
        public void givenTheCharacterStartsAtX(string charName, int startX)
        {
            this.startX = startX;
        }

        [Given(@"starts at Y-coordinates (.*)")]
        public void givenTheCharacterStartsAtY(int startY)
        {
            this.startY = startY;
        }

        [Given(@"the player chooses to move in (.*)")]
        public void givenPlayerChoosesDirection(String direction) {
            this.direction = (MoveDirections) Enum.Parse(typeof(MoveDirections) , direction);
        }

        [Given(@"the current move count is (.*)")]
        public void givenTheCurrentMoveCountIs(int currentMoveCount)
        {
            testObj.SetCurrentMoveCount(currentMoveCount);
        }

        [When(@"the character moves")]
        public void whenTheCharacterMoves()
        {
            testObj.SetCharacterPosition(new Position(this.startX, this.startY));
            testObj.Move(this.direction);
            GameStatus status = testObj.GetStatus();
            this.currentPosition = status.CurrentPosition;
        }

        [Then(@"the character is now at position with X-coordinates (.*)")]
        public void checkXCoordinates(int endX)
        {
            Assert.NotNull(this.currentPosition, "Expected position not null" );
            Assert.AreEqual(endX, this.currentPosition.PositionX);
        }

        [Then(@"Y-coordinates (.*)")]
        public void checkYCoordinates(int endY)
        {
            Assert.NotNull(this.currentPosition, "Expected position not null");
            Assert.AreEqual(endY, this.currentPosition.PositionY);
        }

        [Then(@"the new move count is (.*)")]
        public void checkNewMoveCount(int endingMoveCount)
        {
            Assert.AreEqual(testObj.GetStatus().MoveCount, endingMoveCount);
        }
    }
}