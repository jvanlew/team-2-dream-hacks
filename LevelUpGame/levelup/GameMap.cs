using System.Drawing;

namespace levelup
{
	public class GameMap
	{
		public List<Position> Positions { get; private set; }

		public Position StartPosition { get; set; }

		private Position _currentPos; 

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

			// future iteration could set character to random position
			this.StartPosition = new Position(0, 0);
		}

		public bool IsValidPosition(Position position)
		{
			var isValid = this.Positions.Any(p => p.PositionX == position.PositionX && p.PositionY == position.PositionY);

			return isValid;
		}

		public void CalculatePosition(Position currentPosition, GameController.DIRECTION direction)
		{
			var newPosition = new Position {
				PositionX = currentPosition.PositionX,
				PositionY = currentPosition.PositionY
			};

			switch (direction)
			{
				case GameController.DIRECTION.NORTH:
					newPosition.PositionY++;
					break;

				case GameController.DIRECTION.EAST:
					newPosition.PositionX++;
					break;

				case GameController.DIRECTION.SOUTH:
					newPosition.PositionY--;
					break;

				case GameController.DIRECTION.WEST:
					newPosition.PositionX--;
					break;
			}

			if (IsValidPosition(newPosition))
			{
				currentPosition = newPosition;
			}
		}
	}
}