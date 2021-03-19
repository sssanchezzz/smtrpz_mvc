using System.Linq;
using ComputerShop.Model;
using ComputerShop.Model.Enums;

namespace ComputerShop.Services
{
    public class CaseVerifier 
    {
        private Case Case { set; get; }


        public CaseVerifier(Case c)
        {
            Case = c;
        }
        
        public bool MotherboardFitsCase(Motherboard motherboard)
        {
            return (Case.MotherboardTypesSupported.Contains((MotherboardTypes) motherboard.Type));
        }

        public bool Verify()
        {
            MotherboardVerifier verifier = new MotherboardVerifier(Case.Motherboard);
            bool res = Case.Motherboard.MemoryCardsAdded.Any(c => !verifier.MemoryCardFitsMotherBoard(c));
            return (MotherboardFitsCase(Case.Motherboard)
                    && PowerSourceFitsCase(Case.PowerSource)
                    && verifier.ProcessorsFitsMotherboard(Case.Motherboard.Processor) && !res);
        }
        
        public bool PowerSourceFitsCase(IPowerSource source)
        {
            if (source.Width <= Case.Width
                && source.Length <= Case.Length
                && source.Height <= Case.Height)
            {
                return true;
            }

            return false;
        }

        public bool CheckPowerConsumption()
        {
            if (Case.Motherboard != null && Case.Motherboard.Processor != null && Case.PowerSource != null &&
                Case.Motherboard.MemoryCardsAdded != null && Case.Motherboard.MemoryCardsAdded.Count != 0)
            {
                int sum = 0;
                foreach (var c in Case.Motherboard.MemoryCardsAdded)
                {
                    sum += c.PowerConsumption;
                }

                sum += Case.Motherboard.PowerConsumption + Case.Motherboard.Processor.PowerConsumption;

                return (sum <= Case.PowerSource.Power);
            }
            else
            {
                return false;
            }
        }
    }
}