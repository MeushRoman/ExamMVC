using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProj.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserQuestionHistoryId { get; set; }
        public List<UserQuestionHistory> UserQuestionHistory { get; set; }
    }
}
