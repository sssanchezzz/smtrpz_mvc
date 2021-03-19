using System;
using System.Collections.Generic;

namespace ComputerShop.Dao
{
    public interface ICaseItemDao<T>: IDAO<T>
    {
        List<T> GetByPriceRange(int a, int b);
        List<T> GetByType(Enum e);
    }
}