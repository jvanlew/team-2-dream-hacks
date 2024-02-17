using NUnit.Framework;
using LevelUpGame.Library.Entities;

namespace LevelUpGame.Tests
{
	[TestFixture]
	public class GameControllerTest
	{
		private GameController? testObj;

		[SetUp]
		public void SetUp() {
			testObj = new GameController();
		}

		[Test]
		public void IsGameResultInitialized() {
			Assert.That(testObj.GetStatus(), Is.Not.Null);
		}
	}
}