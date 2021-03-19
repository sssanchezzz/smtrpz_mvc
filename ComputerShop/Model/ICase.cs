using System;

namespace ComputerShop.Model
{
    public interface ICase
    {
        Guid Id { set; get; }
        string Name { set; get; }
        string Model { set; get; }
        int Price { set; get; }
        int Length { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        IPowerSource PowerSource { set; get; }
        
    }
}