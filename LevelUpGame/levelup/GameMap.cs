using System.Drawing;

namespace levelup
{
    public class GameMap
    {
		public List<Position> Positions { get; private set; }

		public Position StartPosition { get; set; }

		public GameMap() {
			this.Positions = new List<Position>();

			for (int x = 0; x < 10; x++) {
				for (int y = 0; y < 10; y++) {
					this.Positions.Add(new Position(x, y));
				}
			}

			this.StartPosition = new Position(0, 0);
		}

		public bool IsValidPosition(Position position) {
			var isValid = this.Positions.Any(p => p.PositionX == position.PositionX && p.PositionY == position.PositionY);

			return isValid;
		}
    }
}