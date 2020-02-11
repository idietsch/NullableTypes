using System;

namespace NullableTypes {
    class Program {
        static void Main(string[] args) {
            var majors = new Major[] {
                new Major(1, "Film Production", 1000),
                new Major(2, "Plumbing", 550),
                new Major(null, "Show Biz", 1200)
            };

            var students = new Students[] {
                new Students(1, "Billy Bob", 2.2, null, null),
                new Students(2, "Rebecca Black", 1.8, 1000, null),
                new Students(3, "Mario Mario", 4.0, null, majors[0])
            };


            foreach(var student in students) {
                student.Print();
            };
        }
    }
}
