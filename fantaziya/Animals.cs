using System;
using System.Collections.Generic;
using System.Text;

namespace fantaziya
{
    class Animals
    {
        public string Name;
        public string NickName;
        public string Colour;
        public int Age;
        public Animals(string name, string nickName,string colour,int age)
        {
            Name = name;
            NickName = nickName;
            Colour = colour;
            Age = age;
        }
        public void A()
        {
            Console.WriteLine($"Name{Name}, Nickname {NickName}, Colour {Colour}, Age{Age}");
        }
     }
}
