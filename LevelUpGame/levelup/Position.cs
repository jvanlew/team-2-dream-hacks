using System.ComponentModel;
using System.Drawing;

namespace levelup
{
    public class Position
    {
        private int x;
        private int y;

        public void SetPosition(int x, int y ){
            this.x = x;
            this.y = y;
        }
         public bool isValid(){
            
            if((this.x >=0 && this.x <=9) && (this.y>=0 && this.y<= 9)){
                
                return true;
            }
            else {
                return false;
            }
        }  

        public Position(){}

        

        
    }
}