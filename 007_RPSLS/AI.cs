using System;
using System.Collections.Generic;
using System.Text;

namespace _007_RPSLS
{
    class AI : Player
    {


        public AI()
        {


        }


        public override void ChooseAGesture()
        {
            var random = new Random();
            int randomNumber = random.Next(1, 5);
            if (randomNumber == 1)
            {
                chosenGesture = gestures[0];

            }

            else if (randomNumber == 1)


            {
                chosenGesture = gestures[1];

            }
            else if (randomNumber == 2)

            {
                chosenGesture = gestures[2];

            }

            else if (randomNumber == 3)
            {
                chosenGesture = gestures[3];
            }

            else if (randomNumber == 4)
            {
                chosenGesture = gestures[4];
            }
        }
    }
}



    // have a computer "choose" a gesture (randomly)




