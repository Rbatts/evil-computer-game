using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello I am an evil computer");
            Console.Write("do you want to play?");
            string uResponse = Console.ReadLine();

            if (uResponse == "yes")
            {
                string message = "I am going to kill you";
                Console.WriteLine(message);
            }
            else if (uResponse == "no")
            {
                string message = "Are you a coward?";
                Console.WriteLine(message);
            }


            Console.Write("Do you want to continue victim 83838?");
            string uResponse1 = Console.ReadLine();

            if (uResponse1 == "yes")
            {
                string message = "Then you shall die";
                Console.WriteLine(message);
            }
            else if (uResponse1 == "no")
            {
                string message = "There is no escape.... death is inevitable";
                Console.WriteLine(message);
            }
            {
                Console.WriteLine("You'll need a lot to beat me");
                Console.Write("Do you have a weapon?");
                string userValue = Console.ReadLine();

                if (userValue == "Yes")
                {
                    string message = "the games can now begin";
                    Console.WriteLine(message);
                }
                else if (userValue == "No")
                {
                    string message = "A sword shall be provided.";
                    Console.WriteLine(message);
                }
            }
            Console.ReadLine();


        }
            
        
    }
}
