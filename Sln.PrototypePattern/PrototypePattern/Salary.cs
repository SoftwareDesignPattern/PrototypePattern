using System;

namespace PrototypePattern
{
    [Serializable]
    internal class Salary
    {
        public double Basic { set; get; }
        public double HouseRentPercentage { set; get; }
        public double ConveyancePercentage { set; get; }

        public Salary GetShallowCopy()
        {
            return (Salary)this.MemberwiseClone();
        }
    }
}
