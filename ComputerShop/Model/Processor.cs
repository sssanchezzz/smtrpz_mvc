using System;

namespace ComputerShop.Model
{
    public class Processor : ICaseItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public bool IsUnique { get; set; }
        public int Price { get; set; }
        public Enum Type { get; set; }
        public int PowerConsumption { get; set; }

        public int ClockRate { get; set; }
        public int NumberOfCores { set; get; }
        public string Architecture { set; get; }


        public Processor()
        {
            Id = Guid.NewGuid();;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Price: {Price}, Power Consumption: {PowerConsumption}, Clock rate: {ClockRate}";
        }
    }
}