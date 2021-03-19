using System;

namespace ComputerShop.Model
{
    public interface ICaseItem
    {
        Guid Id { set; get; }
        string Name { set; get; }
        string Model { set; get; }
        bool IsUnique { set; get; }
        int Price { set; get; }
        Enum Type { set; get; }
        int PowerConsumption { set; get; }
    }
}