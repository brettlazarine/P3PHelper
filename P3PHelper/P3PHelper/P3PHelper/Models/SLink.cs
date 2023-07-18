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

        // Female rank-ups collection
        public ObservableCollection<RankUp> FemaleRankUps { get; set; }

        public SLink()
        {
            FemaleRequiresPersona = true;
            MaleRequiresPersona = true;
        }

        public void CopyFrom(SLink other)
        {
            if (other != null)
            {
                // Copy relevant properties from 'other' to 'this'
                this.Arcana = other.Arcana;
                this.MaleName = other.MaleName;
                this.MaleUnlockDate = other.MaleUnlockDate;
                this.MaleHowToUnlock = other.MaleHowToUnlock;
                this.MaleAvailability = other.MaleAvailability;
                this.MaleRequiresPersona = other.MaleRequiresPersona;
                this.FemaleName = other.FemaleName;
                this.FemaleUnlockDate = other.FemaleUnlockDate;
                this.FemaleHowToUnlock = other.FemaleHowToUnlock;
                this.FemaleAvailability = other.FemaleAvailability;
                this.FemaleRequiresPersona = other.FemaleRequiresPersona;

                // Copy MaleRankUps
                this.MaleRankUps.Clear();
                foreach (var rankUp in other.MaleRankUps)
                {
                    var newRankUp = new RankUp
                    {
                        RankNumber = rankUp.RankNumber,
                        IsCompleted = rankUp.IsCompleted
                    };
                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        newRankUp.Questions.Add((question, answer));
                    }
                    this.MaleRankUps.Add(newRankUp);
                }

                // Copy FemaleRankUps
                this.FemaleRankUps.Clear();
                foreach (var rankUp in other.FemaleRankUps)
                {
                    var newRankUp = new RankUp
                    {
                        RankNumber = rankUp.RankNumber,
                        IsCompleted = rankUp.IsCompleted
                    };
                    foreach (var (question, answer) in rankUp.Questions)
                    {
                        newRankUp.Questions.Add((question, answer));
                    }
                    this.FemaleRankUps.Add(newRankUp);
                }
            }
        }
    }
}
