using System;
using System.Collections.Generic;
using System.Text;

namespace P3PHelper.Models
{
    public class SLink : ISLink
    {
        public string Arcana { get; set; }
        public string FemName { get; set; }
        public string MaleName { get; set; }
        public string FemUnlockDate { get; set; }
        public string MaleUnlockDate { get; set; }
        public string FemHowToUnlock { get; set; }
        public string MaleHowToUnlock { get; set; }
        public string FemAvailability { get; set; }
        public string MaleAvailability { get; set; }
        public bool FemRequiresPersona { get; set; }
        public bool MaleRequiresPersona { get; set; }
        public List<RankUp> FemRankUps { get; set; }
        public List<RankUp> MaleRankUps { get; set; }

        public SLink()
        {
            FemRequiresPersona = true;
            MaleRequiresPersona = true;
        }
    }
}
