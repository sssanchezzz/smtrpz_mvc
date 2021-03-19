using ComputerShop.Model;

namespace ComputerShop.Dao.DaoImpl
{
    public class DaosInit: IDaos
    {
        public ICaseDao CaseDao { get; }
        public ICaseItemDao<MemoryCard> MemoryCardDao { get; }
        public ICaseItemDao<Motherboard> MotherboardDao { get; }
        public IPowerSourceDao PowerSourceDao { get; }
        public ICaseItemDao<Processor> ProcessorDao { get; }
        public FakeDatabase database { get; }

        public DaosInit()
        {
            database = new FakeDatabase();
            CaseDao = new CaseDao(database);
            MemoryCardDao = new MemoryCardDao(database);
            MotherboardDao = new MotherboardDao(database);
            PowerSourceDao = new PowerSourceDao(database);
            ProcessorDao = new ProcessorDao(database);
            database.GenerateData();
        }
    }
}