using ComputerShop.Model;

namespace ComputerShop.Dao
{
    public interface IDaos
    {
        ICaseDao CaseDao { get; }
        ICaseItemDao<MemoryCard> MemoryCardDao { get; }
        ICaseItemDao<Motherboard> MotherboardDao { get; }
        IPowerSourceDao PowerSourceDao { get; }
        ICaseItemDao<Processor> ProcessorDao { get; }
    }
}