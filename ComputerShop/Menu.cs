using System;
using ComputerShop.Model;
using ComputerShop.Model.Enums;
using ComputerShop.Services;

namespace ComputerShop

{
    public delegate bool CheckFunction<T>(T t);


    public class Menu
    {
        private ControllerTerminal _controllerTerminal;
        private ModelImpl _model;
        private Case _unit;

        public void Init(ControllerTerminal controllerTerminal, ModelImpl model)
        {
            _controllerTerminal = controllerTerminal;
            _model = model;
            _unit = _model.configurator.unit;

            // Console.WriteLine("Please, choose a system unit case");
            ChooseItem(Items.CASE);


            bool loopmenu = true;
            while (loopmenu)
            {
                Console.WriteLine("Press:\n" +
                                  "1 - to choose motherboard\n" +
                                  "2 - to choose power supply\n" +
                                  "3 - to choose processor\n" +
                                  "4 - to choose memory card\n" +
                                  "C - to get conclusion");


                var inputKey = Console.ReadKey().Key;
                CaseVerifier verifier = new CaseVerifier(_unit);
                MotherboardVerifier motherboardVerifier = new MotherboardVerifier(_unit.Motherboard);
                loopmenu = _controllerTerminal.Switcher(inputKey);
               
            }
        }

        public void ChooseItem(Items item, string itemToChoose)
        {
            Console.WriteLine($"Please, choose {itemToChoose}");
            _model.configurator.Choose(_model.f.CaseDao.FindAll(), item);
            _unit = _model.configurator.unit;
        }


        private void Conclusion(Case unit)
        {
            CaseVerifier v = new CaseVerifier(unit);
            MotherboardVerifier mv = new MotherboardVerifier(unit.Motherboard);

            Console.WriteLine($"\nYour set:\n" +
                              $"System unit case: {unit};\n" +
                              $"PowerSupply: {unit.PowerSource}, it {CheckString(v.PowerSourceFitsCase(unit.PowerSource))} the unit case;\n" +
                              $"Motherboard: {unit.Motherboard}, it {CheckString(unit.MotherboardTypesSupported.Contains((MotherboardTypes) unit.Motherboard.Type))} the motherboard;\n" +
                              $"Processor: {unit.Motherboard.Processor}, it {CheckString(mv.ProcessorsFitsMotherboard(unit.Motherboard.Processor))} the motherboard;\n");

            Console.WriteLine($"Memory card{(unit.Motherboard.MemoryCardsAdded.Count == 1 ? "" : "s")}:");
            foreach (var s in unit.Motherboard.MemoryCardsAdded)
            {
                Console.WriteLine(
                    $"{s} - {CheckString(unit.Motherboard.MemoryCardTypesSupported.Contains((MemoryCardTypes) s.Type))}");
            }


            bool power = v.CheckPowerConsumption();
            Console.WriteLine($"battery is {(power ? "" : "not")} enough to power all the elements");
            CaseVerifier ver = new CaseVerifier(unit);
            Console.WriteLine($"\nYou can{(ver.Verify() ? "" : " not")} form a set out of these items");
            int cardsPrice = 0;
            foreach (var c in unit.Motherboard.MemoryCardsAdded)
            {
                cardsPrice += c.Price;
            }

            Console.WriteLine(
                $"Total price: {(unit.Price + unit.PowerSource.Price + unit.Motherboard.Price + unit.Motherboard.Processor.Price + cardsPrice)}");
        }
        //
        // private bool CanGetConclusion(Case unitCase)
        // {
        //     if (unitCase == null)
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         if (unitCase.Motherboard == null)
        //         {
        //             Console.WriteLine("\nChoose motherboard!");
        //         }
        //         else
        //         {
        //             if (unitCase.Motherboard.Processor == null)
        //             {
        //                 Console.WriteLine("\nChoose processor!");
        //                 return false;
        //             }
        //
        //             if (unitCase.Motherboard.MemoryCardsAdded == null ||
        //                 unitCase.Motherboard.MemoryCardsAdded.Count == 0)
        //             {
        //                 Console.WriteLine("\nChoose memory card!");
        //                 return false;
        //             }
        //         }
        //
        //         if (unitCase.PowerSource == null)
        //         {
        //             Console.WriteLine("\nChoose power supply!");
        //             return false;
        //         }
        //         else
        //         {
        //             return true;
        //         }
        //     }
        // }

        private string CheckString(bool b)
        {
            if (b)
            {
                return "fits";
            }
            else
            {
                return "does not fit";
            }
        }
    }
}