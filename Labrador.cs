using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Labrador : Dog
    {
        public double Height { get; set; }
        public double Weight { get; set; }

        public Labrador() : base()
        {
            Height = 0;
            Weight = 0;
        }

        public Labrador(string breed, double height, double weight) : base(breed)
        {
            Height = height;
            Weight = weight;
        }

        public override double GetAmountFoodPerDay()
        {
            return 0.8 * Weight * Height;
        }

        public override string ToString()
        {
            return $"{base.ToString()}. Висота: {Height}. Вага: {Weight}. Їжі в день: {GetAmountFoodPerDay()}";
        }
    }
}
