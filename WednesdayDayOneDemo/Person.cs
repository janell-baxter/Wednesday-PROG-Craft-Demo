using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static WednesdayDayOneDemo.Utility;

namespace WednesdayDayOneDemo
{
    public class Person
    {
        public string Name = "Anonymous Player";
        public int Score = 0;
        public List<Item> Inventory = new List<Item>() 
        {
            new Item("Cookbook"),
            new Item()
            { 
                Name = "Cheese", 
                Description = "Cheddar cheese", 
                Amount = 3.6f
            },
            new Item()
            { Amount = 1.2f}
        
        };

        //A person makes a cake
        //void MakeCake()
        //{
        //    if (ItemIsInInventory(Inventory, "Milk") && ItemIsInInventory(Inventory, "Butter"))
        //    {
        //        //return new Cake() { Name = "Tasty Cake" };
        //        Inventory.Add(new Item() { Name = "Tasty Cake" });
        //    }
        //    //return null;

        //}

        public void MakeItem(Formula recipe)
        {
            //if all the required elements in the recipe exist in the player's inventory in the right amounts (or more)
            // remove the items from the player's inventory (or modify the amounts)
            // add the correct item to the player's inventory
        }
    }
}