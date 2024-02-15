using System.Drawing;

namespace levelup
{
    public class GameStatus
    {
      
        public static int moveCount = 0;
        private string characterName;
        private int X;
        private int Y;

          

        public void SetGameStatusValues(String name, int X, int Y)
        {
            this.characterName = name;
            this.X = X;
            this.Y = Y;
        }

        public String toString()
        {
            return "Hello "+ characterName + " you are at position "+ X +"," + Y + " and your total move count is " + moveCount;
        }

    }
}