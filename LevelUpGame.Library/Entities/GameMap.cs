using LevelUpGame.Library.Enumerations;

namespace LevelUpGame.Library.Entities
{
	public class GameMap
	{
		public List<Position> Positions { get; private set; }

		public GameMap()
		{
			this.Positions = new List<Position>();

			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					this.Positions.Add(new Position(x, y));
				}
			}
		}

		public bool IsValidPosition(Position position)
		{
			return this.Positions.Any(p => p.PositionX == position.PositionX && p.PositionY == position.PositionY);
		}

		public Position CalculateNewPosition(Position currentPosition, MoveDirections direction)
		{
			var newPosition = new Position {
				PositionX = currentPosition.PositionX,
				PositionY = currentPosition.PositionY
			};

			switch (direction)
			{
				case MoveDirections.North:
					newPosition.PositionY++;
					break;

				case MoveDirections.East:
					newPosition.PositionX++;
					break;

				case MoveDirections.South:
					newPosition.PositionY--;
					break;

				case MoveDirections.West:
					newPosition.PositionX--;
					break;
			}

			return IsValidPosition(newPosition) ? newPosition : currentPosition;
		}
	}
}