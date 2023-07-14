using System;
using System.Collections.Generic;
using System.Text;

namespace P3PHelper.Models
{
    public interface ISLink
    {
        string Arcana { get; set; }
        string FemName { get; set; }
        string MaleName { get; set; }
        string FemUnlockDate { get; set; }
        string MaleUnlockDate { get; set; }
        string FemHowToUnlock { get; set; }
        string MaleHowToUnlock { get; set; }
        string FemAvailability { get; set; }
        string MaleAvailability { get; set; }
        bool FemRequiresPersona { get; set; }
        bool MaleRequiresPersona { get; set; }
        List<RankUp> FemRankUps { get; set; }
        List<RankUp> MaleRankUps { get; set; }
    }
}
