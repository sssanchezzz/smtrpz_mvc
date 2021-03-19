using System;
using System.Collections.Generic;
using ComputerShop.Model;

namespace ComputerShop.Dao.DaoImpl
{
    public class ProcessorDao:  DAO<Processor>, ICaseItemDao<Processor>
    {
        public ProcessorDao(FakeDatabase database)
        {
            Items = database.Processors;
        }

        public List<Processor> GetByPriceRange(int a, int b)
        {
            throw new NotImplementedException();
        }

        public List<Processor> GetByType(Enum e)
        {
            throw new NotImplementedException();
        }
    }
}