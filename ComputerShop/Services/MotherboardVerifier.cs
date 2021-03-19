using ComputerShop.Model;
using ComputerShop.Model.Enums;

namespace ComputerShop.Services
{
    public class MotherboardVerifier
    {
        private Motherboard Motherboard;

        public MotherboardVerifier(Motherboard motherboard)
        {
            Motherboard = motherboard;
        }
        
        
        
        public bool ProcessorsFitsMotherboard(Processor processor)
        {
            return Motherboard.ProcessorTypesSupported.Contains((ProcessorTypes)processor.Type);
        }

        
        public bool MemoryCardFitsMotherBoard(MemoryCard card)
        {
            return Motherboard.MemoryCardTypesSupported.Contains((MemoryCardTypes) card.Type);
        }
    }
}