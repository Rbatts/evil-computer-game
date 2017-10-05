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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("Hello I am an evil computer");
            Console.WriteLine("");
            Console.Write("do you want to play?\n");
            Console.WriteLine("");
            string uResponse = Console.ReadLine();

            string message = "";

            if (uResponse == "yes")
            {
                message = "\nThen you will lose and I am going to kill you\n";
                Console.WriteLine(message);
            }
            else if (uResponse == "no")
            {
                message = "Are you a coward?\n";
                Console.WriteLine(message);
            }
            Console.Write("Do you want to continue victim 83838?\n");
            Console.WriteLine("");
            string uResponse1 = Console.ReadLine();

            if (uResponse1 == "yes")
            {
                message = "\nThen you shall die!\n";
                Console.WriteLine(message);
            }
            else if (uResponse1 == "no")
            {
                message = "\nThere is no escape.... death is inevitable!\n";
                Console.WriteLine(message);
            }
            Console.Write("");
            Console.WriteLine("You'll need all your strength to beat me\n");
            
            Console.Write("do you have a weapon?\n");
            Console.WriteLine("");
            string userValue = Console.ReadLine();

            if (userValue == "yes")
            {
                message = "The games can now begin.\n";
                Console.WriteLine(message);
            }
            else if (userValue == "no")
            {
                message = "A sword shall be provided.\n";
                Console.Write(message);
                Console.WriteLine("");
            }

            Console.WriteLine("Release the ogre....\nA large ogre appears through a wooden door\n");
            Console.WriteLine("");
            Console.Write("What do you want to do?\n");
            string userValue1 = Console.ReadLine();

            if (userValue1 == "fight")
            {
                message = "You have drawn your sword\n";
                Console.Write(message);
            }
            else if (userValue1 == "run")
            {
                message = "you can't run away\n";
                Console.Write(message);
            }
            Console.ReadLine();
        }
            
        
    }
}
