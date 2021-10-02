using System;
using System.Collections.Generic; //ไม่ประกาศจะไม่สามารถใช้ list ได้
using System.Text;

enum Selectmenu { Play = 1 , Exit }//ใช้enumเพื่อเรียกการใช้งานของ Selectmenu ถ้าไม่ใส่จะทำให้โค้ด error

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args) //เอาไว้ดึงพวกstatic void ที่เขียนแยกมาใช้เฉยๆ
        {
            playhangman(); 
            hangmangame();
        }
        static void playhangman() //ส่วนนี้เป็นส่วนของหน้าเมนูหลักมีการดึงstatic void แยกมาใช้เพื่อไม่ให่เกิดความสับสนแล้วแต่คนจะเขียน
        {
            Console.WriteLine("Welcome To Hangman Game");
            Console.WriteLine("---------------------------");
            Console.WriteLine("[1] Play Game");
            Console.WriteLine("[2] Exit");
            Console.Write("Please Select Menu : ");
            Selectmenu mn = (Selectmenu)(int.Parse(Console.ReadLine()));
            selectmenu(mn);
        }
        static void selectmenu(Selectmenu mn) //ส่วนนี้ใช้ if else ในการเลือกค่าใดค่าหนึ่ง
        {
            if (mn == Selectmenu.Play) //ถ้าเลือก 1 = play game
            {
                hangmangame(); //ดึงจากstatic void ของ hangmangame มาใช้
            }
            else if (mn != Selectmenu.Exit) // ถ้าเลือก 2 หรือ อื่นๆ = Exit
            {
                Console.ReadLine();
            }
        }
        static void hangmangame() //ข้อมูลของเกมทั้งหมด
        {
            string[] Word = new string[3]; //array เก็บข้อมูลของข้อความ
            Word[0] = "tennis";
            Word[1] = "football";
            Word[2] = "badminton";
            Random random = new Random(); // ใช้ random ตอนที่เกมเริ่มแล้วจะมีการสุ่มคำศัพท์ตอนเกมเริ่ม
            int rd = random.Next(0, 2);
            string newGuessWord = Word[rd];


            char[] guess = new char[Word.Length]; //ในส่วนนี้เป็นส่วนซ่อนคำศัพท์ จะแสดงผลแบบนี้ _ _ _ _ จนกว่าคำศัพท์จะถูก
            for (int p = 0; p < Word.Length; p++)
                guess[p] = '_';

            List<char> correctGuesses = new List<char>(); 
            List<char> incorrectGuesses = new List<char>();//ตัวนับคะแนนเวลาผิด

            int incorrect = 0; //กำหนดค่านับคำผิดไว้ที่ 0
            int lives = 6; //สามารถผิดได้แค่ 6 คำ
            bool won = false; // เกิน 6 คำถือว่าแพ้
            int lettersRevealed = 0;

            string input;
            char guess;

            while (!won && lives > 0) 
            {
                Console.Write("Input letter alphabet : ");//กรอกตัวอักษรที่เราจะเดา

                input = Console.ReadLine();
                guess = input[0];

                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine(guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine(guess);
                    continue;
                }

                if (newGuessWord.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < newGuessWord.Length; i++)
                    {
                        if (newGuessWord[i] == guess)
                        {
                            displayToPlayer[i] = newGuessWord[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == newGuessWord.Length)
                        won = true;
                }
                else
                {
                    incorrectGuesses.Add(guess);
                    incorrect++; //ตัวนับจำนวนผิดจะแสดงค่าตรง Console.WriteLine("Incorrect Score : {0}",incorrect);
                    lives--;//ชีวิตจะลดลงไปเรื่อยๆ พอผิดครบ6คำ จะจบเกมทันที
                    Console.WriteLine("Incorrect Score : {0}",incorrect);
                    Console.WriteLine(guess);
                    
                    
                }

                Console.WriteLine(guess.ToString());
            }

            if (won) //ถ้าชนะจะแสดงผล"You win!"
                Console.WriteLine("You win!");
            else //ถ้าแพ้จะแสดงผล"You lost!"
                Console.WriteLine("You lost!");

            
            Console.ReadLine();
        }
    }
}
        
    

