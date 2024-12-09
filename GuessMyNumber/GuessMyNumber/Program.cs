using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random ran = new Random();

            int ran1 = ran.Next(50, 76); // get random number store in ran1
            Console.WriteLine(ran1);
            int point = 0;  // customer point
            int i = 0;

            while (true)  // use while for 3 tries
            {
                Console.WriteLine("Lets Play guess wich number i guessed from 50 to 75(50,75)");

                string input = Console.ReadLine();
                int gnumber;
                if (int.TryParse(input, out gnumber)) // make sure customer enter  numbers
                    
                {

                    if (gnumber >= 50 && gnumber <= 75) // make sure he guess anumber inrange 50-75
                    {
                        i++;
                        if (gnumber == ran1 ) // compare if he guessed wright
                        {
                            
                            switch (i)
                            {
                                case 1:
                                    point = point + 10;
                                    Console.WriteLine($"You Guessed the number {ran1} from {i} tries you scored {point} points");
                                    return;
                                    
                                case 2:
                                    point = point + 7;
                                    Console.WriteLine($"You Guessed the number {ran1} from {i} tries you scored {point} points");
                                    return;

                                case 3:
                                    point = point + 5;
                                    Console.WriteLine($"You Guessed the number {ran1} from {i} tries you scored {point} points");
                                    return;
                                default:
                                    Console.WriteLine($"You Guessed the number {ran1} from {i} tries you scored {point} points");
                                    return;
                            }
                           

                        }
                        
                       
                    }
                    else

                    {
                        Console.WriteLine("error your enter number its not in range of (50,75) try again ");
                    }

                }
                else

                {
                    Console.WriteLine("Error invalid Number characters and symbols not allowed  try again use number range 50-75 ");

                }

            }
            
        }
    }
}
