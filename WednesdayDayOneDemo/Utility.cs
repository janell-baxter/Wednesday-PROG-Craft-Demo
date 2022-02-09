using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace WednesdayDayOneDemo
{
    class Utility
    {
        //separation of concern
        public static void Print(string message)
        {
            WriteLine(message);
            //specific to my GUI platform
        }
        public static void Pause()
        {
            Print("Press any key to continue...");
            ReadKey();
        }

        /*
         * public static string LoadTextFromFile(string path)
         {
            return File.ReadAllText(path);
        }
        */
        //same as previous method but expression-bodied
        public static string LoadTextFromFile(string path) => File.ReadAllText(path);

       
        public static string AllItemsInList(List<Item> items)
        {
            string output = "";
            foreach (Item i in items)
            {
                output += $"{i.Name} ({i.Description}) {Environment.NewLine}";
            }

            return output;
        }
       public static bool ItemIsInInventory(List<Item> list, string name)
        {

            foreach (Item i in list)
            {
                if (i.Name.ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }


        //expression bodied method example
        //public static string TextToLower(string message) => message.ToLower();

        //public static string TextToLower(string message)
        //{
        //    return message.ToLower();
        //}

        //public static void ChangeScore(Person player, int amount)
        //{
        //    player.Score += amount;
        //}

    }
}
