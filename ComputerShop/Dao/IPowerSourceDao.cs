using System.Collections.Generic;
using ComputerShop.Model;

namespace ComputerShop.Dao
{
    public interface IPowerSourceDao: IDAO<PowerSource>
    {
        List<PowerSource> GetByPriceRange(int a, int b);
        List<PowerSource> GetBySize(int x, int y, int z);
    }
}