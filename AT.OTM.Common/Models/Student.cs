using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.OTM.Common.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string EmailId { get; set; }
        public List<Test> RegisteredTests { get; set; } = new List<Test>();
        public List<Test> CompletedTests { get; set; } = new List<Test>();
        public List<Result> Results { get; set; } = new List<Result>();
    }
}
