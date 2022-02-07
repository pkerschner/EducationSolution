﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject {
    public class Student {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int SAT { get; set; }
        public decimal GPA { get; set; }
        public Major Major { get; set; }

        public Major GetMajorByDescription(string description,
                                            List<Major> majors) {
            foreach(Major major in majors) {
                if(description == major.Description) {
                    return major;
                }
            }
            return null;
        }

        public Student(string firstname, string lastname,
                        int sat, decimal gpa) {
            Firstname = firstname;
            Lastname = lastname;
            SAT = sat;
            GPA = gpa;
            Major = null;
        }
    }
}
