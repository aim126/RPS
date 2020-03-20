using System;
using System.Collections.Generic;
using System.Text;

namespace _007_RPSLS
{
    class Human : Player
    {
        public Human()
        {

        }

        public override void ChooseAGesture()
        {
            Console.WriteLine("Please choose a Gesture Human/AI");

            chosenGesture = Console.ReadLine();
        }
    }
}
