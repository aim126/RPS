using System;
using System.Collections.Generic;
using System.Text;

namespace _007_RPSLS
{
    class Game
    {
        Player player1;
        Player player2;



        public void RunGame()
        {


        }
        public void ChooseGameMode()
        {
            string gameMode;
            Console.WriteLine("game mode 1 is AI, Gamemode 2 is Human Which mode would you like?");
            gameMode = Console.ReadLine();
            // string userInput = null;
            switch (gameMode)
            {
                case "1":
                    HumanVsComputerMode();
                    break;
                case "2":
                    HumanvsHumanMode();
                    break;
                default:
                    Console.WriteLine("an invalid game mode was picked");
                    ChooseGameMode();
                    break;

                    // return userInput;
            }
        }
        public void DetermineRoundWinner()
        {
            if (player1.chosenGesture == "Rock" && player2.chosenGesture == "Scissors" || player1.chosenGesture == "Scissors" && player2.chosenGesture == "Paper" || player1.chosenGesture == "Paper" && player2.chosenGesture == "Rock" || player1.chosenGesture == "Rock" && player2.chosenGesture == "Lizard" || player1.chosenGesture == "lizard" && player2.chosenGesture == "Spock" || player1.chosenGesture == "spock" & player2.chosenGesture == "Scissors" || player1.chosenGesture == "Scissors" & player2.chosenGesture == "Lizard" || player1.chosenGesture == "Lizard" && player2.chosenGesture == "Paper" || player1.chosenGesture == "Paper" && player2.chosenGesture == "Spock" || player1.chosenGesture == "Spock" && player2.chosenGesture == "Rock")
            {
                player1.score++;

                Console.WriteLine("Player1 is the round Winner");

            }
            else if (player1.chosenGesture == player2.chosenGesture)

            {

                Console.WriteLine("This is a Tie");


            }
            else
            {
                player2.score++;
                Console.WriteLine("Player2 is the round Winner");
            }




        }















        public void HumanVsComputerMode()
        {
            Console.WriteLine("Gamemode 2,Gamemode1 ");
            player1 = new Human();
            player2 = new AI();
        }

        public void HumanvsHumanMode()
        {
            Console.WriteLine("Gamemode1,Gamemode1");
            player1 = new Human();
            player2 = new Human();
        }







        // instantiate player1
        // instatiate player2
    }






    //Player Player1 = new Player();
    //Player Player2 = new Player();
    //console.writeline("which game mode? 1 for Computer , 2 for Human"); 






    //console.writeline("which game mode? 1 for Computer , 2 for Human ); 
    //string user input= ConsolReadLine()
    //p1= New Human();
}










