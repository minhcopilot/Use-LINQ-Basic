using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq
{
    class Truck:Vehicle
    {
        public int PayloadCapacity { get; set; }
        public string Company { get; set; }

        public Truck(string make, string model, int year, decimal price, int payloadCapacity,string company) : base(make, model, year, price)
        {
            PayloadCapacity = payloadCapacity;
            Company = company;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tải trọng: {PayloadCapacity}";
        }
    }
}
