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

            int ran1 = ran.Next(50, 75); // get random number store in ran1

            int point = 0;  // customer point
            int i = 1;

            while (i <= 3)  // use while for 3 tries
            {
                Console.WriteLine("Lets Play guess wich number i guessed from 50 to 75");

                string input = Console.ReadLine();
                int gnumber;
                if (int.TryParse(input, out gnumber)) // make sure customer enter  numbers
                {
                    if (gnumber >= 50 && gnumber <= 75) // make sure he guess anumber inrange 50-75
                    {
                        if (gnumber == ran1 & i <= 3) // compare if he guessed wright
                        {
                            switch (i)
                            {
                                case 1:
                                    point = point + 10;
                                    break;

                                case 2:
                                    point = point + 7;
                                    break;

                                case 3:
                                    point = point + 5;
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("you guessed " + i + " times you scored " + point + " points");
                            break;

                        }
                        else

                        {
                            Console.WriteLine("you guessed " + i + " times you scored " + point + " points");
                        }
                        // add 1 to i
                        i++;
                    }
                    else

                    {
                        Console.WriteLine("error your number its not in range try again ");
                    }

                }
                else

                {
                    Console.WriteLine("Error Incorect Number try again use number range 50-75 ");

                }

            }
        }
    }
}
