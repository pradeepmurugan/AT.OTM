using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.OTM.Common.Models
{
    public class Result
    {
        public Student Student { get; set; } = new Student();
        public Test Test { get; set; } = new Test();
        public List<Question> CorrectQuestions { get; set; } =  new List<Question>();
        public bool HasPassed => (CorrectQuestions.Count >= 2);                      
       
    }
}
