using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public abstract class Dog
    {
        public string Breed { get; set; }

        public Dog()
        {
            Breed = "";
        }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public abstract double GetAmountFoodPerDay();

        public override string ToString()
        {
            return Breed;
        }
    }
}
