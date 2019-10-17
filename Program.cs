using System;
using System.Collections.Generic;
using System.Linq;

namespace heist2 {
    class Program {
        static void Main(string[] args)
        {
        List<IRobber> rolodex = new List<IRobber>();

        Hacker neo = new Hacker() {Name = "Neo", SkillLevel = 50, PercentageCut = 33};
        Hacker trinity = new Hacker() {Name = "Trinity", SkillLevel = 60, PercentageCut = 35};
        Muscle therock = new Muscle() {Name = "The Rock", SkillLevel = 40, PercentageCut = 30};
        Muscle arnold = new Muscle() {Name = "Arnold", SkillLevel = 30, PercentageCut = 25};
        LockSpecialist jason = new LockSpecialist() {Name = "Jason", SkillLevel = 45, PercentageCut = 32};
        LockSpecialist brad = new LockSpecialist() {Name = "Brad", SkillLevel = 35, PercentageCut = 28};

        rolodex.Add(neo);
        rolodex.Add(trinity);
        rolodex.Add(therock);
        rolodex.Add(arnold);
        rolodex.Add(jason);
        rolodex.Add(brad);

        Console.WriteLine($"Operatives in Rolodex: {rolodex.Count()}");
        Console.WriteLine("Enter new operative name>");
        string newName = Console.ReadLine();
        
        while (newName != "") {
        
        Console.WriteLine("Choose operative speciality:");
        Console.WriteLine("1: Hacker (Disables alarms)");
        Console.WriteLine("2: Muscle (Disarms guards");
        Console.WriteLine("3: Lock Specialist (Cracks vault)");
        Console.WriteLine("Enter Speciality Number (1-3)>");
        string newSpeciality = Console.ReadLine();
        Console.WriteLine("Enter Skill Level (1-100)>");
        string newSkillLevel = Console.ReadLine();
        Console.WriteLine("Enter percentage cut (1-100)>");
        string newPercentageCut = Console.ReadLine();

        
            if (int.Parse(newSpeciality) == 1) {
                Hacker newOperative = new Hacker() {
                    Name = newName,
                    SkillLevel = int.Parse(newSkillLevel),
                    PercentageCut = int.Parse(newPercentageCut)
                };
                rolodex.Add(newOperative);
            } else if (int.Parse(newSpeciality) == 2) {
                Muscle newOperative = new Muscle() {
                    Name = newName,
                    SkillLevel = int.Parse(newSkillLevel),
                    PercentageCut = int.Parse(newPercentageCut)
                };
                rolodex.Add(newOperative);
            } else {
                LockSpecialist newOperative = new LockSpecialist() {
                    Name = newName,
                    SkillLevel = int.Parse(newSkillLevel),
                    PercentageCut = int.Parse(newPercentageCut)
                };
                rolodex.Add(newOperative);
            }

            Console.WriteLine("Enter new operative name>");
            newName = Console.ReadLine();
        }

        Random generator = new Random();
        int alarmValue = generator.Next(0, 101);
        int vaultValue = generator.Next(0, 101);
        int guardValue = generator.Next(0, 101);
        int cashValue = generator.Next(50_000, 1_000_001);

        Bank gothamCentral = new Bank()
        {
            AlarmScore = alarmValue,
            VaultScore = vaultValue,
            SecurityGuardScore = guardValue,
            CashOnHand = cashValue
        };

        List<int> systems = new List<int>();
        systems.Add(gothamCentral.AlarmScore);
        systems.Add(gothamCentral.VaultScore);
        systems.Add(gothamCentral.SecurityGuardScore);

        Console.WriteLine("Recon Report");
        Console.WriteLine("-------------");
        Console.WriteLine($"Most Secure: {systems.Max()}");
        Console.WriteLine($"Least Secure: {systems.Min()}");        

        Console.WriteLine("Rolodex Report");
        Console.WriteLine("--------------");
        foreach (var operative in rolodex)
        {
            Console.WriteLine($"Name: {operative.Name}");
            Console.WriteLine($"Specialty: {operative.Speciality}");
            Console.WriteLine($"Skill Level: {operative.SkillLevel}");
            Console.WriteLine($"Cut of Take: {operative.PercentageCut}%");
            Console.WriteLine("--------------");
        }

        }



        }
    }
