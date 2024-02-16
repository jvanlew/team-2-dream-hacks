using System.Drawing;
using LevelUpGame.levelup.Enumerations;

namespace levelup
{
	public class GameController
	{
		public GameMap Map { get; set; }

		public GameStatus Status { get; set; }

		public GameController() {

			this.Status = new GameStatus {
				CurrentCharacter = new Character(),
				CurrentPosition = new Position(-1, -1),
				StartPosition = new Position(0, 0),
				MoveCount = -100
			};

			Map = new GameMap();
		}

		public void CreateCharacter(string name) {
			this.Status.CurrentCharacter = new Character(name);
		}

		public void StartGame() {
			CreateCharacter(this.Status.CurrentCharacter.Name);
			SetCharacterPosition(this.Status.StartPosition);
		}

		public GameStatus GetStatus() {
			return this.Status;
		}

		public void Move(MoveDirections directionToMove) {

			// calculate new position
			Position newPosition = Map.CalculateNewPosition(Status.CurrentPosition, directionToMove);

			// now update the status
			SetCurrentMoveCount(Status.MoveCount++);
			SetCharacterPosition(newPosition);
		}

		public void SetCharacterPosition(Position newPosition) {
			Status.CurrentPosition = newPosition;
		}

		public void SetCurrentMoveCount(int moveCount) {
			Status.MoveCount = moveCount;
		}

		public int GetTotalPositions() {
			return Map.Positions.Count();
		}
	}
}