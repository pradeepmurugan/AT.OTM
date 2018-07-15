using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT.OTM.Common.Models
{
    public class Test
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public List<Result> Results { get; set; } = new List<Result>();
        public List<Question> QuestionOrder { get; set; } = new List<Question>();
        public Dictionary<Question, List<Choice>> QuestionChoices { get; set; } = new Dictionary<Question, List<Choice>>();
        public List<Student> RegisteredStudents { get; set; } = new List<Student>();
        public DateTimeOffset Date { get; set; }
    }
}
