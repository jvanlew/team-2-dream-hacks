using System.Drawing;

namespace levelup
{
    public class Character
    {
        private string name;

        public void setName(String name){
            this.name = name;
        }
         public String getName(){
            return this.name;
        }  

        public Character()
        {
            this.name = "Default Character";
        }

        
    }
}