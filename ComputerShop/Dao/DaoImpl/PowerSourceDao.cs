using System;
using System.Collections.Generic;
using ComputerShop.Model;

namespace ComputerShop.Dao.DaoImpl
{
    public class PowerSourceDao :  DAO<PowerSource>, IPowerSourceDao
    {
        public PowerSourceDao(FakeDatabase database)
        {
            Items = database.PowerSources;
        }

        public List<PowerSource> GetByPriceRange(int a, int b)
        {
            throw new NotImplementedException();
        }

        public List<PowerSource> GetBySize(int x, int y, int z)
        {
            throw new NotImplementedException();
        }
    }
}