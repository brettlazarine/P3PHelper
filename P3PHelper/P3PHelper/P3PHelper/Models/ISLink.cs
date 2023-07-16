using System;
using System.Collections.Generic;
using System.Text;

namespace P3PHelper.Models
{
    public interface ISLink
    {
        string Arcana { get; set; }
        string FemaleName { get; set; }
        string MaleName { get; set; }
        string FemaleUnlockDate { get; set; }
        string MaleUnlockDate { get; set; }
        string FemaleHowToUnlock { get; set; }
        string MaleHowToUnlock { get; set; }
        string FemaleAvailability { get; set; }
        string MaleAvailability { get; set; }
        bool FemaleRequiresPersona { get; set; }
        bool MaleRequiresPersona { get; set; }
        List<RankUp> FemaleRankUps { get; set; }
        List<RankUp> MaleRankUps { get; set; }
    }
}
