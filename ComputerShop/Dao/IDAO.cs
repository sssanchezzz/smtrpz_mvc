using System;
using System.Collections.Generic;

namespace ComputerShop.Dao
{
    public interface IDAO<T>
    {
        T Get(Guid id);
        List<T> FindAll();
        void Insert(Guid id, T t);
        void Update(Guid id, T t);
        void Delete(Guid id);
    }
}