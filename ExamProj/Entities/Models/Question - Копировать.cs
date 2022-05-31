using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProj.Entities.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QText { get; set; }
        public int RealAnswerId { get; set; }  
        public Answer Answer { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
