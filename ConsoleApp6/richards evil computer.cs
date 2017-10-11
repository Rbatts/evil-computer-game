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
            bool MainMenu = true;
            while (MainMenu == true)
            {
                MainMenu = Menu();
            }
        }

        private static void ComputerSays(string text, bool inGreen = false)
        {
            if (inGreen)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(text);
        }

        private static string GetUserResponse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadLine();
        }

        private static bool Menu()
        {
            
            ComputerSays("\nHello I am an evil computer\n");
            ComputerSays("do you want to play?\n");
            string uResponse = GetUserResponse();

            string message = "";
            string message2 = "";

            while (uResponse != "yes" && uResponse != "no")
            {
                ComputerSays("Please say yes or no.");
                uResponse = GetUserResponse();
            }
            if (uResponse == "yes")
            {
               message = "\nThen you will lose and I am going to kill you\n";
               ComputerSays(message);
            }
            else if (uResponse == "no")
            {
                message = "Are you a coward?\n";
                ComputerSays(message);
            }
 
            Console.Write("Do you want to continue victim 83838?\n");
            ComputerSays("");
            string uResponse1 = GetUserResponse();

            while (uResponse1 != "yes" && uResponse1 != "no")
            {
                ComputerSays("Please say yes or no.");
                uResponse1 = GetUserResponse();
            }
            if (uResponse1 == "yes")
            {
                message = "\nThen you shall die!\n";
                ComputerSays(message);
            }
            else if (uResponse1 == "no")
            {
                message = "\nThere is no escape.... death is inevitable!\n";
                ComputerSays(message);
            }
            else
            {
                ComputerSays("Please say yes or no.");
                GetUserResponse();
                Console.Clear();
                return true;
            }

            Console.Write("");
            ComputerSays("You'll need all your strength to beat me\n");
            
            Console.Write("do you have a weapon?\n");
            ComputerSays("");
            string userValue = GetUserResponse();

            while (userValue != "yes" && userValue != "no")
            {
                ComputerSays("Please say yes or no.");
                userValue = GetUserResponse();
            }
            if (userValue == "yes")
            {
                message = "You don't have a sword. You lied to me (you are burnt to death for lying).\n";
                ComputerSays(message);
                GetUserResponse();
                Console.Clear();
                return true;
            }
            else if (userValue == "no")
            {
                message = "A sword shall be provided.";
                ComputerSays(message, false);
                ComputerSays("");
                message2 = "WELL DONE YOU FOUND A SWORD.\n";
                ComputerSays(message2, true);
                
            }
            else
            {
                ComputerSays("Please say yes or no.");
                GetUserResponse();
                Console.Clear();
                return true;
            }
            Console.Write("");
            ComputerSays("Prepare yourself for the first task.\nOn a scale of 1 to 10 how ready are you?");
            ComputerSays("");
            string uResponse3 = GetUserResponse();
            while (uResponse3 != "10" && uResponse3 != "9" && uResponse3 != "8" && uResponse3 != "7" && uResponse3 != "6" && uResponse3 != "5" && uResponse3 != "4" && uResponse3 != "3" && uResponse3 != "2" && uResponse3 != "1")
            {
                ComputerSays("Please enter a number so I can evaluate you.");
                uResponse3 = GetUserResponse();
            }
            if (uResponse3 == "10")
            {
                message = "Well step up and prove it big man.";
                ComputerSays(message);
            }
            else if (uResponse3 == "9")
            {
                message = "I like a victim who puts up a fight";
                ComputerSays(message);
            }
            else if (uResponse == "8")
            {
                message = "There's some doubt in your voice, you wont make it much further";
                ComputerSays(message);
            }
            else if (uResponse3 == "7")
            {
                message = "You did't even have a sword five seconds ago how ready can you be?";
                ComputerSays(message);
            }
            else
            {
                ComputerSays("WOW you really are a coward aren't you?.\n");
            }
            //Console.WriteLine("Well now we know what kind of person you are we can begin.\n");
            
            ComputerSays("Release the ogre....\nA large ogre appears through a wooden door\n");
            ComputerSays("");
            Console.Write("What do you want to do?\n");
            string userValue1 = GetUserResponse();

            while (userValue1 != "fight" && userValue1 != "run")
            {
                ComputerSays("You can either fight or run.");
                userValue1 = GetUserResponse();
            }
            if (userValue1 == "fight")
            {
                message = "You have drawn your sword.\n";
                Console.Write(message);
            }
            else if (userValue1 == "run")
            {
                message = ("The ogre runs after you.\nHe crushed you with his feet.");
                Console.Write(message);
            }
            GetUserResponse();
            Console.Clear();

            return true;
        } 
         
    }
}