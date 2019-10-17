using System;

namespace heist2 {
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality { get; set; } = "Hacker";

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"Mr. {Name} is hacking the mainframe (alarm system). Decreased security {SkillLevel} points.");
            if (bank.AlarmScore <= 0) {
                Console.WriteLine($"Mr. {Name} has disabled the alarm system!");
            }
        }
    }

    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality { get; set; } = "Muscle";

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"Mr. {Name} is taking on the security guards. Decreased security {SkillLevel} points.");
            if (bank.SecurityGuardScore <= 0) {
                Console.WriteLine($"Mr. {Name} has defeated the security guards!");
            }
        }
    }

    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public string Speciality {get; set; } = "Lock Pick";

        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"Mr. {Name} is picking the vault lock. Decreased security {SkillLevel} points.");
            if (bank.VaultScore <= 0) {
                Console.WriteLine($"Mr. {Name} has cracked the bank vault!");
            }
        }
    }
}