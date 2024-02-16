using System.Drawing;

namespace levelup
{
    public class GameMap
    {
         readonly Position [,]  pos = new Position[10,10] {
            {new Position(0,9), new Position(1,9),new Position(2,9), new Position(3,9), new Position(4,9), new Position(5,9), new Position(6,9), new Position(7,9), new Position(8,9),new Position(9,9)},
            {new Position(0,8), new Position(1,8),new Position(2,8), new Position(3,8), new Position(4,8), new Position(5,8), new Position(6,8), new Position(7,8), new Position(8,8),new Position(9,8)},
            {new Position(0,7), new Position(1,7),new Position(2,7), new Position(3,7), new Position(4,7), new Position(5,7), new Position(6,7), new Position(7,7), new Position(8,7),new Position(9,7)},
            {new Position(0,6), new Position(1,6),new Position(2,6), new Position(3,6), new Position(4,6), new Position(5,6), new Position(6,6), new Position(7,6), new Position(8,6),new Position(9,6)},
            {new Position(0,5), new Position(1,5),new Position(2,5), new Position(3,5), new Position(4,5), new Position(5,5), new Position(6,5), new Position(7,5), new Position(8,5),new Position(9,5)},
            {new Position(0,4), new Position(1,4),new Position(2,4), new Position(3,4), new Position(4,4), new Position(5,4), new Position(6,4), new Position(7,4), new Position(8,4),new Position(9,4)},
            {new Position(0,3), new Position(1,3),new Position(2,3), new Position(3,3), new Position(4,3), new Position(5,3), new Position(6,3), new Position(7,3), new Position(8,3),new Position(9,3)},
            {new Position(0,2), new Position(1,2),new Position(2,2), new Position(3,2), new Position(4,2), new Position(5,2), new Position(6,2), new Position(7,2), new Position(8,2),new Position(9,2)},
            {new Position(0,1), new Position(1,1),new Position(2,1), new Position(3,1), new Position(4,1), new Position(5,1), new Position(6,1), new Position(7,1), new Position(8,1),new Position(9,1)},
            {new Position(0,0), new Position(1,0),new Position(2,0), new Position(3,0), new Position(4,0), new Position(5,0), new Position(6,0), new Position(7,0), new Position(8,0),new Position(9,0)},
        }; 
                                             
           Position currentPosition ;                                  

        
         

        public GameMap()
        {
            this.currentPosition = new Position(0,0);
        }
        public bool IsValid(Position pos){
            return true;
        }
        
    }
}