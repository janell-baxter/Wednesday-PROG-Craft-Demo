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

        //TODO: 
        //Read all lines
        //split
        //inheritance - overriding and virtual

        public static string[] LoadLinesFromFile(string path)
        {
            return File.ReadAllLines(path);
        }

        public static List<Item> CreateItemsFromFile(string path)
         {
        List<Item> temp = new List<Item>();
        string[] source = LoadLinesFromFile(path);
            foreach (string s in source)
             {   
            temp.Add(new Item(){Name = s});
            }
        
            return temp;
        }
        public static List<Item> CreateItemsWithPropertiesFromFile(string path)
         {
        List<Item> temp = new List<Item>();
        string[] source = LoadLinesFromFile(path);
            foreach (string s in source)
             {
                string[] subs = s.Split('~');
                temp.Add(new Item(){Name=subs[2], Amount= float.Parse(subs[0] })
            }
        
            return temp;
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
