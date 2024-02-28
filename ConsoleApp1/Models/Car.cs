

namespace ConsoleApp1.Models
{
    internal class Car
    {
        public string name;
       private string color = "Red";
        public int speed;
        public string  Color {
            get
            {
                if (speed > 400)
                {
                    return color;
                }
                return null;
               
            }
            set
            {
                color = value;

            }
        
        
        
        
        }

    }
}
