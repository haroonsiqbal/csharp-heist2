using System;

namespace heist2 {
    public interface IRobber {
        string Name {get; set;}
        string Speciality {get; set;}
        int SkillLevel {get; set;}
        int PercentageCut {get; set;}
        void PerformSkill(Bank bank);
    }
}