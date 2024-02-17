using NUnit.Framework;
using LevelUpGame.Library.Entities;
using System;
using System.Drawing;

namespace LevelUpGame.Tests
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position();
        }

    }
}