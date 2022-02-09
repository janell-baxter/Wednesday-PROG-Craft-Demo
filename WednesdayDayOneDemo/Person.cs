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
                Amount = 6,
                MaterialType = Material.Other //example of using an enum
            },
            new Item()
            {
                Name = "Bread",
                Description = "Sourdough bread",
                Amount = 12
            },
            new Item()
            {
                Name = "Cow Milk",
                Description = "Cow milk",
                Amount = 3
            },
            new Item()
            {
                Name = "Oat Milk",
                Description = "Oat milk",
                Amount = 12
            }

        };

       

        public void MakeItem(Formula recipe)
        {

            //get the list of ingredients from the formula/recipe
            //for each of the ingredients search the player's inventory for a match - could use search in utility class
            //if it exists in the player's inventory, then we want to see if there is enough

            //if all the required elements in the recipe exist in the player's inventory in the right amounts (or more)
            // remove the items from the player's inventory (or modify the amounts)
            // add the correct item to the player's inventory

            Inventory.Add(new Item() {Name = recipe.Name });



        }



        //A person makes a cake - hard coded example (not as good >.<)

        //void MakeCake()
        //{
        //    if (ItemIsInInventory(Inventory, "Milk") && ItemIsInInventory(Inventory, "Butter"))
        //    {
        //        //return new Cake() { Name = "Tasty Cake" };
        //        Inventory.Add(new Item() { Name = "Tasty Cake" });
        //    }
        //    //return null;

        //}
    }
}