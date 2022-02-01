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
        public void Run()
        {

            Title = "Wednesday Demo!";
            //concatenation
            WriteLine("Hello " + Player.Name + ", your score is " + Player.Score + ".");

            //composite
            WriteLine("Hello {0}, your score is {1}.", Player.Name, Player.Score);

            //interpolation
            WriteLine($"Hello {Player.Name}, your score is {Player.Score}.");

            Pause();

        }

        public void ChangeScore()
        {
            Player.Score++;
        }
    }
}
