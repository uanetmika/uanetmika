using System;

namespace ConsoleApp51
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int score = 0;

            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("---------------------------");
            Console.WriteLine("(1) Play Game");
            Console.WriteLine("(2) Exit");
            int wc = int.Parse(Console.ReadLine());

            string[] listword = new string[2];
            listword[0] = "Tennis";
            listword[1] = "Football";
            listword[2] = "Badminton";

            Random random = new Random();
            int resultRandom = random.Next(0,2);

            
            

            if (wc == 1) 
            {

                Console.WriteLine("Play Game Hangman");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Incorrect Score : {0}",score);
                Console.WriteLine("Input letter alphabe : ");
                string la = Console.ReadLine();

                
                
               
            }
            else if (wc == 2) 
            {
                
            }
        }
    }
}
