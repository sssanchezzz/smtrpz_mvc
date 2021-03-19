using System;
using ComputerShop.Dao;
using ComputerShop.Dao.DaoImpl;
using ComputerShop.Model;
using ComputerShop.Model.Enums;
using ComputerShop.Services;

namespace ComputerShop
{
    public class ModelImpl
    {
        public IDaos f { get; }
        private ICaseDao Cases;
        private ICaseItemDao<Motherboard> Motherboards;
        private ICaseItemDao<Processor> Processors;
        private ICaseItemDao<MemoryCard> MemoryCards;
        private IPowerSourceDao PowerSources;
        public Configurator configurator { get; }

        public ModelImpl()
        {
            f = new DaosInit();
            Cases = f.CaseDao;
            Motherboards = f.MotherboardDao;
            Processors = f.ProcessorDao;
            MemoryCards = f.MemoryCardDao;
            PowerSources = f.PowerSourceDao;
            configurator = new Configurator();
        }

        public void ChooseItem(Items item, Case unit)
        {
            CaseVerifier verifier = new CaseVerifier(unit);
            MotherboardVerifier motherboardVerifier = new MotherboardVerifier(unit.Motherboard);
            switch (item)
            {
                case Items.MOTHERBOARD:
                    CheckFunction<Motherboard> checkMoth = verifier.MotherboardFitsCase;
                    configurator.Choose(Motherboards.FindAll(), Items.MOTHERBOARD, unit, checkMoth);
                    break;
                case Items.POWER_SOURCE:
                    CheckFunction<PowerSource> checkPow = verifier.PowerSourceFitsCase;
                    configurator.Choose(PowerSources.FindAll(), Items.POWER_SOURCE, unit, checkPow);
                    break;
                case Items.PROCESSOR:
                    CheckFunction<Processor> checkProc =
                        motherboardVerifier.ProcessorsFitsMotherboard;
                    configurator.Choose(Processors.FindAll(), Items.PROCESSOR, unit, checkProc);
                    break;
                case Items.MEMORY_CARD:
                    CheckFunction<MemoryCard> checkMemory =
                        motherboardVerifier.MemoryCardFitsMotherBoard;
                    configurator.ChooseMultiple(unit, unit.Motherboard.MemoryCardsAdded, MemoryCards.FindAll(),
                        Items.MEMORY_CARD,
                        checkMemory);
                    break;
            }
        }
    }
}