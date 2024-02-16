using System.ComponentModel;
using System.Drawing;

namespace levelup
{
    public class Position
    {
		public int PositionX { get; set; }
		public int PositionY { get; set; }

		public void SetPosition(int x, int y) {
			this.PositionX = x;
			this.PositionY = y;
		}

		//public bool IsValidPosition() {
		//	if ((this.x >= 0 && this.x <= 9) && (this.y >= 0 && this.y <= 9)) {
		//		return true;
		//	}
		//	else {
		//		return false;
		//	}
		//}

		public Position(int x, int y) {
			this.PositionX = x;
			this.PositionY = y;
		}

		public Position() { }
    }
}