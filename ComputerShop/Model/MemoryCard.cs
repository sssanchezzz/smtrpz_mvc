using System;

namespace ComputerShop.Model
{
    public class MemoryCard: ICaseItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public bool IsUnique { get; set; }
        public int Price { get; set; }
        public Enum Type { get; set; }
        public int PowerConsumption { get; set; }

        public int MemoryCapacity { get; set; }

        public MemoryCard()
        {
            Id = Guid.NewGuid();;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Price: {Price}, Type: {Type.ToString()}, Memory capacity: {MemoryCapacity}";
        }
    }
}