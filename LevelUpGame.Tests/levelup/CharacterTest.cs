using LevelUpGame.Library.Entities;
using NUnit.Framework;

namespace LevelUpGame.Tests
{
	[TestFixture]
    public class CharacterTest
    {
        private Character testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
        }

        [Test]
        public void IsDefaultNameNull()
        {
            Assert.That(testObj.Name, Is.Not.Null);
        }
    }
}