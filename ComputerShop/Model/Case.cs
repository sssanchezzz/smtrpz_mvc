using System;
using System.Collections.Generic;

namespace ComputerShop.Model
{
    public class Case: ICase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IPowerSource PowerSource { get; set; }

        public List<Enums.MotherboardTypes> MotherboardTypesSupported { get; }
        public Motherboard Motherboard { get; set; }

        public Case()
        {
            MotherboardTypesSupported = new List<Enums.MotherboardTypes>();
            Id = Guid.NewGuid();

        }
        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, Price: {Price}";
        }
    }
}