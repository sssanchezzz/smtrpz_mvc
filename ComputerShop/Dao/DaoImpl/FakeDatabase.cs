using System;
using System.Collections.Generic;
using ComputerShop.Model;
using ComputerShop.Model.Enums;

namespace ComputerShop.Dao.DaoImpl
{
    public class FakeDatabase
    {
        public Dictionary<Guid, PowerSource> PowerSources { get; }
        public Dictionary<Guid, Case> Cases { get; }
        public Dictionary<Guid, Processor> Processors { get; }
        public Dictionary<Guid, Motherboard> Motherboards { get; }
        public Dictionary<Guid, MemoryCard> MemoryCards { get; }

        public FakeDatabase()
        {
            PowerSources = new Dictionary<Guid, PowerSource>();
            Cases = new Dictionary<Guid, Case>();
            Processors = new Dictionary<Guid, Processor>();
            Motherboards = new Dictionary<Guid, Motherboard>();
            MemoryCards = new Dictionary<Guid, MemoryCard>();
        }

        public void GenerateData()
        {
            Case u1 = new Case()
            {
                Model = "SysUniCa2000",
                Name = "SystemUnitCase",
                Price = 2000,
                Length = 200,
                Width = 100,
                Height = 50,
            };
            Case u2 = new Case()
            {
                Model = "SysUniCa150",
                Name = "SystemUnitCase",
                Price = 1500,
                Length = 120,
                Width = 120,
                Height = 50,
            };
            Case u3 = new Case()
            {
                Model = "SysUniCa3000",
                Name = "SystemUnitCase",
                Price = 1000,
                Length = 100,
                Width = 80,
                Height = 30,
            };

            u1.MotherboardTypesSupported.Add(MotherboardTypes.MBT100);
            u1.MotherboardTypesSupported.Add(MotherboardTypes.MBT200);
            u1.MotherboardTypesSupported.Add(MotherboardTypes.MBT300);
            u1.MotherboardTypesSupported.Add(MotherboardTypes.MBT500);

            u2.MotherboardTypesSupported.Add(MotherboardTypes.MBT400);
            u2.MotherboardTypesSupported.Add(MotherboardTypes.MBT500);
            u2.MotherboardTypesSupported.Add(MotherboardTypes.MBT600);

            u3.MotherboardTypesSupported.Add(MotherboardTypes.MBT700);
            u3.MotherboardTypesSupported.Add(MotherboardTypes.MBT400);
            u3.MotherboardTypesSupported.Add(MotherboardTypes.MBT300);
            u3.MotherboardTypesSupported.Add(MotherboardTypes.MBT600);

            Cases.Add(u1.Id, u1);
            Cases.Add(u2.Id, u2);
            Cases.Add(u3.Id, u3);

            Motherboard m1 = new Motherboard()
            { Type = MotherboardTypes.MBT100, Model = "M1", Name = "Motherboard M1", Price = 600 };
            Motherboard m2 = new Motherboard()
            { Type = MotherboardTypes.MBT200, Model = "M2", Name = "Motherboard M2", Price = 500 };
            Motherboard m3 = new Motherboard()
            { Type = MotherboardTypes.MBT300, Model = "M3", Name = "Motherboard M3", Price = 300 };
            Motherboard m4 = new Motherboard()
            { Type = MotherboardTypes.MBT500, Model = "M4", Name = "Motherboard M4", Price = 1000 };
            Motherboard m5 = new Motherboard()
            { Type = MotherboardTypes.MBT700, Model = "M5", Name = "Motherboard M5", Price = 1400 };

            m1.ProcessorTypesSupported.Add(ProcessorTypes.PT1);
            m1.ProcessorTypesSupported.Add(ProcessorTypes.PT2);
            m1.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT1);
            m1.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT2);
            m1.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT5);


            m2.ProcessorTypesSupported.Add(ProcessorTypes.PT3);
            m2.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT4);

            m3.ProcessorTypesSupported.Add(ProcessorTypes.PT4);
            m3.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT1);
            m3.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT3);


            m4.ProcessorTypesSupported.Add(ProcessorTypes.PT4);
            m4.ProcessorTypesSupported.Add(ProcessorTypes.PT5);
            m4.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT5);
            m4.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT5);


            m5.ProcessorTypesSupported.Add(ProcessorTypes.PT2);
            m5.ProcessorTypesSupported.Add(ProcessorTypes.PT3);
            m5.ProcessorTypesSupported.Add(ProcessorTypes.PT4);
            m5.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT2);
            m5.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT3);
            m5.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT4);
            m5.MemoryCardTypesSupported.Add(MemoryCardTypes.MCT5);

            Motherboards.Add(m1.Id, m1);
            Motherboards.Add(m2.Id, m2);
            Motherboards.Add(m3.Id, m3);
            Motherboards.Add(m4.Id, m4);
            Motherboards.Add(m5.Id, m5);

            Processor p1 = new Processor()
            {
                Type = ProcessorTypes.PT1,
                NumberOfCores = 4,
                Name = "Processor PT1 4 cores",
                Model = "P1",
                Price = 300,
                Architecture = "A1",
                ClockRate = 4,
                PowerConsumption = 400
            };
            Processor p2 = new Processor()
            {
                Type = ProcessorTypes.PT1,
                NumberOfCores = 8,
                Name = "Processor PT1 8 cores",
                Model = "P2",
                Price = 400,
                Architecture = "A1",
                ClockRate = 3,
                PowerConsumption = 500
            };
            Processor p3 = new Processor()
            {
                Type = ProcessorTypes.PT2,
                NumberOfCores = 4,
                Name = "Processor PT2 4 cores",
                Model = "P3",
                Price = 2000,
                Architecture = "A2",
                ClockRate = 5,
                PowerConsumption = 600
            };
            Processor p4 = new Processor()
            {
                Type = ProcessorTypes.PT3,
                NumberOfCores = 16,
                Name = "Processor PT3 16 cores",
                Model = "P4",
                Price = 5000,
                Architecture = "A3",
                ClockRate = 8,
                PowerConsumption = 700
            };

            Processors.Add(p1.Id, p1);
            Processors.Add(p2.Id, p2);
            Processors.Add(p3.Id, p3);
            Processors.Add(p4.Id, p4);

            MemoryCard c1 = new MemoryCard()
            {
                Type = MemoryCardTypes.MCT1,
                Name = "Memory Card MCT1",
                Model = "MC 1 1024",
                Price = 2000,
                MemoryCapacity = 1024
            };
            MemoryCard c2 = new MemoryCard()
            {
                Type = MemoryCardTypes.MCT4,
                Name = "Memory Card MCT4",
                Model = "MC 2 2048",
                Price = 3200,
                MemoryCapacity = 2048
            };
            MemoryCard c3 = new MemoryCard()
            {
                Type = MemoryCardTypes.MCT5,
                Name = "Memory Card MCT5",
                Model = "MC 3 1024",
                Price = 1200,
                MemoryCapacity = 1024
            };
            MemoryCard c4 = new MemoryCard()
            {
                Type = MemoryCardTypes.MCT3,
                Name = "Memory Card MCT3",
                Model = "MC 3 512",
                Price = 700,
                MemoryCapacity = 512
            };
            MemoryCard c5 = new MemoryCard()
            {
                Type = MemoryCardTypes.MCT1,
                Name = "Memory Card MCT1",
                Model = "MC 1 1024",
                Price = 1700,
                MemoryCapacity = 1024
            };

            MemoryCards.Add(c1.Id, c1);
            MemoryCards.Add(c2.Id, c2);
            MemoryCards.Add(c3.Id, c3);
            MemoryCards.Add(c4.Id, c4);
            MemoryCards.Add(c5.Id, c5);

            PowerSource s1 = new PowerSource()
            {
                Name = "PS1000",
                Length = 120,
                Width = 100,
                Height = 10,
                Power = 4500,
                Price = 500,
                Model = "SPS 4500",
                VoltageDropsProtection = true
            };
            PowerSource s2 = new PowerSource()
            {
                Name = "PS1000",
                Length = 80,
                Width = 80,
                Height = 20,
                Power = 4200,
                Price = 700,
                Model = "SPS 4200",
                VoltageDropsProtection = true
            };
            PowerSource s3 = new PowerSource()
            {
                Name = "PS1000",
                Length = 100,
                Width = 90,
                Height = 10,
                Power = 5000,
                Price = 500,
                Model = "SPS 5000",
                VoltageDropsProtection = false
            };
            PowerSource s4 = new PowerSource()
            {
                Name = "PS1000",
                Length = 120,
                Width = 120,
                Height = 15,
                Power = 4500,
                Price = 400,
                Model = "SPS 4500",
                VoltageDropsProtection = false
            };

            PowerSources.Add(s1.Id, s1);
            PowerSources.Add(s2.Id, s2);
            PowerSources.Add(s3.Id, s3);
            PowerSources.Add(s4.Id, s4);
        }
    }
}