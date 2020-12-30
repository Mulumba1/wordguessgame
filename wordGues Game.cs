
using System;

namespace DevUniguessgame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "mulumba";
            string guess =  "";
            int guessCount = 0;
            int guesLimit = 5;
            bool outOfGuess = false;

            while(guess != secretWord && !outOfGuess)
            {
                if(guessCount < guesLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount ++; 
                    
                }
                else
                {
                    outOfGuess = true;
                }
            }
            if (outOfGuess)
                {
                    Console.Write("Oh sorry! You Loss");
                } 
            else
            {
                Console.Write("Congratulations! You win");
        
            }
        }           
    }
}
