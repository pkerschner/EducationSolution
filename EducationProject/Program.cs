using System;
using System.Collections.Generic;

namespace EducationProject {
    class Program {
        static void Main(string[] args) {

            List<Major> majors = new List<Major>();

            Major business = new Major("Business", 1000);
            majors.Add(business);
            Major nursing = new Major("Nursing", 1200);
            majors.Add(nursing);
            Major theater = new Major("Theater", 1100);
            majors.Add(theater);

            foreach(Major major in majors) {
                Console.WriteLine($"{major.Id}|{major.Description}|{major.MinSAT}");
            }

            List<Student> students = new List<Student>();

            Student alex = new Student("Alex", "Alex", 1350, 3.4m);
            alex.Major = alex.GetMajorByDescription("Business", majors);
            Student drew = new Student("Drew", "Drew", 1350, 3.45m);
            drew.Major = drew.GetMajorByDescription("Business", majors);
            Student steven = new Student("Steven", "Steven", 1350, 3.4m);

            students.Add(alex);
            students.Add(drew);
            students.Add(steven);

            foreach(Student student in students) {
                string MajorDescription = student.Major == null
                    ? "Undecided" : student.Major.Description;
                Console.WriteLine($"{student.Firstname} {student.Lastname} " +
                                $"Major: {MajorDescription}");
            }
        }
    }
}
