using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProj.Entities.Models
{
    public class Questioning
    {
        public int Id { get; set; }
        public int QuestionID { get; set; }
        public List<Question> Questions { get; set; }
        //public List<Answer> Answers { get; set; }
    }
}
