using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WednesdayDayOneDemo
{
    class Utility
    {
      
        public static void Pause()
        {
            Print("Press any key to continue...");
            ReadKey();
        }

        public static void ChangeScore(Person player, int amount)
        {
            player.Score += amount;
        }
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
        //public static string TextToLower(string message)
        //{
        //    return message.ToLower();
        //}

        public static string TextToLower(string message) => message.ToLower();

        //separation of concern
        public static void Print(string message)
        {
            WriteLine(message);
            //specific to my GUI platform
        }

    }
}
