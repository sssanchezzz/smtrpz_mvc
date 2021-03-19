using System;

namespace ComputerShop.Model
{
    public class PowerSource: IPowerSource
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool VoltageDropsProtection { get; set; }
        public int Power { get; set; }

        public PowerSource()
        {
            Id = Guid.NewGuid();;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Price: {Price}, Voltage Drops Protection: {VoltageDropsProtection}";
        }
    }
}