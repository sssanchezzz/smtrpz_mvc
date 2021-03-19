using System;
using ComputerShop.Model;
using ComputerShop.Model.Enums;
using ComputerShop.Services;

namespace ComputerShop
{
    public class ControllerTerminal
    {
        private ModelImpl _model;
        private Configurator _configurator;
        public ControllerTerminal(ModelImpl model)
        {
            if (model == null)
                throw new ArgumentNullException(
                    "model");
            _model = model;
            _configurator = _model.configurator;
        }

        public void ShowView()
        {
            
        }

        public bool Switcher(ConsoleKey inputKey)
        {
            bool loopmenu = true;
                switch (inputKey)
                {
                    case ConsoleKey.D1:
                        _model.ChooseItem(Items.MOTHERBOARD, _configurator.unit);
                        // CheckFunction<Motherboard> checkMoth = verifier.MotherboardFitsCase;
                        // configurator.Choose(Motherboards.FindAll(), "motherboard", unit, checkMoth);
                        break;
                    case ConsoleKey.D2:
                        _model.ChooseItem(Items.POWER_SOURCE, _configurator.unit);
                       
                        break;
                    case ConsoleKey.D3:
                        if (_configurator.unit.Motherboard != null)
                        {
                            _model.ChooseItem(Items.PROCESSOR, _configurator.unit);
                        }
                        else
                        {
                            Console.WriteLine("You should choose motherboard!");
                        }

                        break;

                    case ConsoleKey.D4:
                        if (_configurator.unit.Motherboard != null)
                        {
                            _model.ChooseItem(Items.MEMORY_CARD, _configurator.unit);
                        }
                        else
                        {
                            Console.WriteLine("You should choose motherboard!");
                        }
                        break;

                    case ConsoleKey.C:
                        if (CanGetConclusion(_configurator.unit))
                        {
                            loopmenu = false;
                        }
                        else
                        {
                            Console.WriteLine("You should finish choosing!");
                            loopmenu = true;
                        }
                        break;
                    default:
                        loopmenu = true;
                        break;
                }
                return loopmenu;
        }
        
        private bool CanGetConclusion(Case unitCase)
        {
            if (unitCase == null)
            {
                return false;
            }
            else
            {
                if (unitCase.Motherboard == null)
                {
                    Console.WriteLine("\nChoose motherboard!");
                }
                else
                {
                    if (unitCase.Motherboard.Processor == null)
                    {
                        Console.WriteLine("\nChoose processor!");
                        return false;
                    }

                    if (unitCase.Motherboard.MemoryCardsAdded == null ||
                        unitCase.Motherboard.MemoryCardsAdded.Count == 0)
                    {
                        Console.WriteLine("\nChoose memory card!");
                        return false;
                    }
                }

                if (unitCase.PowerSource == null)
                {
                    Console.WriteLine("\nChoose power supply!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}