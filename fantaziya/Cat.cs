using System;
using System.Collections.Generic;
using System.Text;

namespace fantaziya
{
    class Cat:Animals
    {
        public double Weight;
        public Cat(string name, string nickName, string colour, int age, double weight):base(name,nickName,colour,age)
        {
            Weight = weight;
        }
    }
}
