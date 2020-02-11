using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Students {
        public int Sid;
        public string Name;
        public double Gpa;
        public int? Sat;
        public int? MajorId { get; set; }
        public Major? Major { get; set; }

        public Students(int id, string name, double gpa, int? sat, Major major) {
            Sid = id;
            Name = name;
            Gpa = gpa;
            Sat = sat;
            Major = major;
        }

        public void Print() {
            Console.WriteLine($"Id {Sid}, Name {Name}, GPA {Gpa}, SAT {Sat}, Major {Major}");
        }
    }

    
}
