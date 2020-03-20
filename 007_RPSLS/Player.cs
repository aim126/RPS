using System;
using System.Collections.Generic;
using System.Text;

namespace _007_RPSLS
{
    abstract class Player
    {
        // member variables (HAS A)
        public List<string> gestures;
        public string chosenGesture;
        public int score;

        

        // constructor
         


        public Player()
        {   gestures= new List<string>() ;
            gestures.Add("Rock");
            gestures.Add ("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }


        // member methods (CAN DO)
        public abstract void ChooseAGesture();
           
           
           
        

    }

}




      


        






        
        




   