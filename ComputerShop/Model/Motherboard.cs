using System;
using System.Collections.Generic;

namespace ComputerShop.Model
{
    public class Motherboard : ICaseItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public bool IsUnique { get; set; }
        public int Price { get; set; }
        public Enum Type { get; set; }
        public int PowerConsumption { get; set; }

        public List<Enums.ProcessorTypes> ProcessorTypesSupported { get; }
        public List<Enums.MemoryCardTypes> MemoryCardTypesSupported { get; }
        public Processor Processor { get; set; }
        public List<MemoryCard> MemoryCardsAdded { get; }

        public Motherboard()
        {
            Id = Guid.NewGuid();
            ProcessorTypesSupported = new List<Enums.ProcessorTypes>();
            MemoryCardTypesSupported = new List<Enums.MemoryCardTypes>();
            MemoryCardsAdded = new List<MemoryCard>();
        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Price: {Price}, Type: {Type.ToString()}";
        }
    }
}