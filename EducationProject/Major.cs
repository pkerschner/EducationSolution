using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject {
    
    public class Major {

        private static int NextId { get; set; } = 1;
        
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public Major(string description, int minSAT) {
            Id = NextId;
            NextId++;
            Description = description;
            MinSAT = minSAT;
        }
    }
}
