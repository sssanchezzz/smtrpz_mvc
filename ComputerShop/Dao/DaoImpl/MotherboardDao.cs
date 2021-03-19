using System;
using System.Collections.Generic;
using ComputerShop.Model;

namespace ComputerShop.Dao.DaoImpl
{
    public class MotherboardDao: DAO<Motherboard>, ICaseItemDao<Motherboard>
    {
        public MotherboardDao(FakeDatabase database)
        {
            Items = database.Motherboards;
        }

        public List<Motherboard> GetByPriceRange(int a, int b)
        {
            throw new NotImplementedException();
        }

        public List<Motherboard> GetByType(Enum e)
        {
            throw new NotImplementedException();
        }
    }
}