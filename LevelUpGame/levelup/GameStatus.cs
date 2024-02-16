using System.Drawing;

namespace levelup
{
	public class GameStatus
	{

		public Character CurrentCharacter { get; set; }

		public Position StartPosition { get; set; } = new Position(0, 0);

		public Position CurrentPosition { get; set; } = new Position(0, 0);

		public Position? EndPosition { get; set; }

		public int MoveCount { get; set; } = 0;

		public GameStatus() : this(new Character()) { }

		public GameStatus(string characterName) : this(new Character { Name = characterName }) { }

		public GameStatus(
			Character currentCharacter) { 			
			CurrentCharacter = currentCharacter;			
		}

		//public void SetGameStatusValues(String name, int X, int Y) {
		//	this.characterName = name;
		//	this.X = X;
		//	this.Y = Y;
		//}

		public override string ToString() {
			return $"Hello {CurrentCharacter.Name}! You are at position {CurrentPosition?.PositionX},{CurrentPosition?.PositionY} and your total move count is {MoveCount}";
		}
	}
}