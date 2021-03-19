using System;

namespace ComputerShop.Model
{
    public interface IPowerSource
    {
        Guid Id { set; get; }
        string Name { set; get; }
        string Model { set; get; }
        int Price { set; get; }
        int Length { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        bool VoltageDropsProtection { set; get; }
        int Power { get; set; }
    }
}