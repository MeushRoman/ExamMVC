using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProj.Entities.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string AText { get; set; }
        public Question Question { get; set; } 
    }
}
