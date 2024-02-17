using System.Drawing;

namespace LevelUpGame.Library.Entities
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

		//public GameStatus Clone() {
		//	var newStatus = new GameStatus {
		//		MoveCount = MoveCount,
		//		StartPosition = new Position(StartPosition.PositionX, StartPosition.PositionY),
		//		CurrentPosition = new Position(CurrentPosition.PositionX, CurrentPosition.PositionY),
		//		CurrentCharacter = new Character {
		//			Name = CurrentCharacter.Name
		//		}
		//	};

		//	if (EndPosition != null) {
		//		newStatus.EndPosition = new Position(EndPosition.PositionX, EndPosition.PositionY);
		//	}

		//	return newStatus;
		//}
	}
}