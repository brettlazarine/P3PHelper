using System;
using System.Collections.Generic;
using System.Text;

namespace P3PHelper.Controls
{
    public class Serialization
    {
        public class RankUpSerializedData
        {
            public int RankNumber { get; set; }
            public bool IsCompleted { get; set; }
        }

        public class SLinkSerializedData
        {
            public List<RankUpSerializedData> MaleRankUps { get; set; }
            public List<RankUpSerializedData> FemaleRankUps { get; set; }
        }
    }
}
