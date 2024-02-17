using System;
using FluentAssertions;
using LevelUpGame.Library.Entities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class StartGameSteps
    {
        private GameController testObj = new GameController();

        [When(@"the game is started")]
        public void whenTheGameIsStarted()
        {
            testObj = new GameController();
            testObj.StartGame();
        }

        [When(@"the game has (.*) positions")]
        public void checkPositionCount(int numPositions)
        {
            testObj.GetTotalPositions().Should().Be(numPositions);
        }

        [Then(@"the game sets the character's X position to (.*)")]
        public void checkXPosition(int xPosition)
        {
            testObj.GetStatus().CurrentPosition.PositionX.Should().Be(xPosition);
        }

        [Then(@"the game sets the character's Y position to (.*)")]
        public void checkYPosition(int yPosition)
        {
            testObj.GetStatus().CurrentPosition.PositionY.Should().Be(yPosition);
        }

        [Then(@"the starting move count is (.*)")]
        public void checkMoveCount(int moveCount) {
            testObj.GetStatus().MoveCount.Should().Be(moveCount);
        }
    }
}