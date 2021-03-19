using System;
using System.Collections.Generic;
using ComputerShop.Model;

namespace ComputerShop.Dao.DaoImpl
{
    public class MemoryCardDao : DAO<MemoryCard>, ICaseItemDao<MemoryCard>
    {
        public MemoryCardDao(FakeDatabase database)
        {
            Items = database.MemoryCards;
        }

        public List<MemoryCard> GetByPriceRange(int a, int b)
        {
            throw new NotImplementedException();
        }

        public List<MemoryCard> GetByType(Enum e)
        {
            throw new NotImplementedException();
        }
    }
}