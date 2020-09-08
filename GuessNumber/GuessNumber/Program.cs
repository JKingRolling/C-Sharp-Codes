using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber, guessNumber;
            int times = 1;
            //生成随机数
            Random rnd = new Random();
            randomNumber = rnd.Next(99999);

            //输入猜的数
            Console.WriteLine("Please guess this number:");
            guessNumber = Convert.ToInt32(Console.ReadLine());
            
            while (guessNumber != randomNumber)
            {
                if (guessNumber < randomNumber)
                {
                    Console.WriteLine("Too small,guess again:");
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                    times++;
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Too big,guess again:");
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                    times++;
                }
            }
            Console.WriteLine("Guess Right!Your had guessed {0} times!",times);
            Console.ReadKey();         
        }
    }
}
