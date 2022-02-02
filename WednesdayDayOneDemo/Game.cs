using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static WednesdayDayOneDemo.Utility;

namespace WednesdayDayOneDemo
{
    class Game
    {
        //Next steps?

        //Player should have an inventory - probably a list
        //Player currency - start with some
        //NPC trader or vendor that also has an inventory

        //Items should have a value?

        //add ability to add items together
        //figure out how the formula works
        //how can we have one method that will take multiple inputs and return one or more outputs
        //how can we track the specific formula/recipe for each items we want to create


        Person Player = new Person();
        List<Formula> Recipes = new List<Formula>();

        public void Run()
        {
            //Player.Inventory.Add(
            //    new Item()
            //    { 
            //     Name = "Bread",
            //     Description = "Sourdough bread",
            //     Amount = 2
            //    }
            //    );
            //Player.Inventory.Add(new Item("Cheese"));

            Title = "Wednesday Demo!";
            //concatenation
            //WriteLine("Hello " + Player.Name + ", your score is " + Player.Score + ".");

            //composite
            //WriteLine("Hello {0}, your score is {1}.", Player.Name, Player.Score);

            //interpolation
            Print($"Hello {Player.Name}, your score is {Player.Score}.");


            Print("Here is what is in your inventory....");
            Print(AllItemsInList(Player.Inventory));


            //craft example - bread + cheese = cheese sandwich
            Recipes.Add(
                new Formula() 
                {
                    Name = "Cheese Sandwich", 
                    Ingredients = new List<Item>() 
                    { 
                        new Item() 
                        {
                            Name="Cheese" 
                        }, 
                        new Item() {
                            Name = "Bread" 
                        } 
                    } 
                }
                );

            Pause();
            //example of a declarative sentence:
            //A game allows a player to make an item if they have ingredients
        }

        //public void ChangeScore()
        //{
        //    Player.Score++;
        //}
    }
}
