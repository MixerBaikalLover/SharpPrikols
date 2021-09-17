using System.Collections.Generic;

namespace SecondTry
{
    public class Building
    {
        internal string address { get; set; }
        internal int floorCount { get; set; }

        public Building(string address, int floorCount)
        {
            this.address = address;
            this.floorCount = floorCount;
        }

        public Building()
        {
        }

        public void Deconstruct(out string address, out int floorCount)
        {
            address = this.address;
            floorCount = this.floorCount;
        }
    }
}