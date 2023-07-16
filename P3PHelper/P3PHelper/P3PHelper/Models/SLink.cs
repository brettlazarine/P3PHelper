using System;
using System.Collections.Generic;
using System.Text;

namespace P3PHelper.Models
{
    public class SLink : ISLink
    {
        public string Arcana { get; set; }
        public string FemaleName { get; set; }
        public string MaleName { get; set; }
        public string FemaleUnlockDate { get; set; }
        public string MaleUnlockDate { get; set; }
        public string FemaleHowToUnlock { get; set; }
        public string MaleHowToUnlock { get; set; }
        public string FemaleAvailability { get; set; }
        public string MaleAvailability { get; set; }
        public bool FemaleRequiresPersona { get; set; }
        public bool MaleRequiresPersona { get; set; }
        public List<RankUp> FemaleRankUps { get; set; }
        public List<RankUp> MaleRankUps { get; set; }

        public SLink()
        {
            FemaleRequiresPersona = true;
            MaleRequiresPersona = true;
        }
    }
}
