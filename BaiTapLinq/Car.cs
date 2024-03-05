using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq
{
    class Car:Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Car(string make, string model, int year, decimal price, int numberOfSeats) : base(make, model, year, price)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return base.ToString() + $", Số chỗ: {NumberOfSeats}";
        }
    }
}
