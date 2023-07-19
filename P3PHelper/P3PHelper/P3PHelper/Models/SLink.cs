using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<RankUp> MaleRankUps { get; set; }
        public ObservableCollection<RankUp> FemaleRankUps { get; set; }

        public SLink()
        {
            // Most SLinks will require a Persona, constructor will default to TRUE for convenience
            FemaleRequiresPersona = true;
            MaleRequiresPersona = true;
        }
    }
}
