using System;
using System.Collections.Generic;
using ComputerShop.Model;
using ComputerShop.Model.Enums;

namespace ComputerShop.Services
{
    public class Configurator
    {
        public Case unit = new Case();
        
        public void Choose<T>(List<T> list, Items choice, 
            Case unitCase = null, CheckFunction<T> function = null)
        {
            Console.WriteLine($"\nPlease choose {choice}:\n");
            foreach (var s in list)
            {
                if (function == null || unitCase == null)
                {
                    Console.WriteLine($"{(list.IndexOf(s) + 1)} - {s}");
                }
                else
                {
                    Console.WriteLine(function(s)
                        ? $"{(list.IndexOf(s) + 1)} - {s} - fits"
                        : $"{list.IndexOf(s) + 1} - {s} - does not fit");
                }
            }

            Console.WriteLine("\nPlease enter your option:");
            bool repeat = true;
            while (repeat)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    if (input > 0 && input <= list.Count)
                    {
                        SetProp(choice, list[input - 1], unitCase);
                        Console.WriteLine($"You`ve chosen {list[input - 1]}\n");
                        Console.WriteLine("Choose: " + unitCase);

                        repeat = false;
                    }
                    else
                    {
                        Console.WriteLine("Number out of range, please try again!");
                        repeat = true;
                    }
                }
                else
                {
                    Console.WriteLine("Not a number, please try again!");
                }
            }
        }

        private void SetProp(Items prop, object obj, Case unitCase = null)
        {
            switch (prop)
            {
                case Items.MOTHERBOARD:
                    if (unitCase != null) unitCase.Motherboard = (Motherboard) obj;
                    break;
                case Items.POWER_SOURCE:
                    if (unitCase != null) unitCase.PowerSource = (PowerSource) obj;
                    break;
                case Items.PROCESSOR:
                    if (unitCase != null) unitCase.Motherboard.Processor = (Processor) obj;
                    break;
                case Items.MEMORY_CARD:
                    if (unitCase != null) unitCase.Motherboard.MemoryCardsAdded.Add((MemoryCard) obj);
                    break;
                case Items.CASE:
                    unit = (Case) obj;
                    break;
                default:
                    break;
            }

        }

        public void ChooseMultiple<T>(Case unitCase, List<T> listToClear, List<T> list, Items choice,
            CheckFunction<T> function)
        {
            listToClear.Clear();
            Console.WriteLine($"\nPlease choose {choice}:\n");

            foreach (var s in list)
            {
                Console.WriteLine(function(s)
                    ? $"{(list.IndexOf(s) + 1)} - {s} - fits"
                    : $"{(list.IndexOf(s) + 1)} - {s} - does not fit");
            }

            Console.WriteLine("Please enter your options, to exit enter 'exit':\n");
            bool exit = false;
            while (!exit)
            {
                var inputString = Console.ReadLine();
                if (inputString != null)
                {
                    if (int.TryParse(inputString, out int input))
                    {
                        if (input > 0 && input <= list.Count)
                        {
                            SetProp(Items.MEMORY_CARD, list[input - 1], unitCase);
                            Console.WriteLine($"You`ve chosen {list[input - 1]}");
                        }
                        else
                        {
                            Console.WriteLine("Wrong number, please try again!\n");
                            exit = false;
                        }
                    }
                    else if (inputString.Equals("exit"))
                    {
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Not a number, try again");
                    }
                }
            }
        }
        
    }
}