using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    public class Major {
        public int? Mid { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public Major(int? mid, string description, int minsat) {
            Mid = mid;
            Description = description;
            MinSAT = minsat;
        }
    }
}
