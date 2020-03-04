using ExamProj.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProj.Entities
{
    public class UserQuestionHistory
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int QuestioningId { get; set; }
        public Questioning Questioning { get; set; }
    }
}
