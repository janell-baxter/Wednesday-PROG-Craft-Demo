using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WednesdayDayOneDemo
{
    //example enum
    enum Material
        {
        Dry,
        Liquid,
        Other
    }
    public class Item
    {
        private string name;
        private string description = "general item";
        //float (f), double, decimal (m)
        private float amount = 2.0f;
        

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public float Amount { get => amount; set => amount = value; }
        public Material MaterialType;

        public Item()
        {

        }
        public Item(string _name)
        {
            Name = _name;
        }
    }
}