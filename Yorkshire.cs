using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Yorkshire : Dog
    {
        public double Length { get; set; }
        public double Weight { get; set; }

        public Yorkshire() : base()
        {
            Length = 0;
            Weight = 0;
        }

        public Yorkshire(string breed, double length, double weight) : base(breed)
        {
            Length = length;
            Weight = weight;
        }

        public override double GetAmountFoodPerDay()
        {
            return Length * 1d / Weight;
        }

        public override string ToString()
        {
            return $"{base.ToString()}. Довжина: {Length}. Вага: {Weight}. Їжі в день: {GetAmountFoodPerDay()}";
        }
    }
}
