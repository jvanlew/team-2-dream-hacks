using System.ComponentModel;
using System.Drawing;

namespace levelup
{
	public class Position
	{
		public int PositionX { get; set; }
		public int PositionY { get; set; }

		public Position(int x, int y) {
			this.PositionX = x;
			this.PositionY = y;
		}

		public Position() : this(0, 0) { }
	}
}