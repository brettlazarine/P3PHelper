using System;
using System.Collections.Generic;
using System.Text;

namespace P3PHelper.Models
{
    public class RankUp
    {
        public bool IsCompleted { get; set; }
        public int RankNumber { get; set; }
        public List<(string Question, string Answer)> Questions { get; set; }

        public RankUp()
        {
            IsCompleted = false;
        }
    }
}
