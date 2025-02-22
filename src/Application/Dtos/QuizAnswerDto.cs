using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class QuizAnswerDto
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int QuizAttemptId { get; set; }
        public QuizQuestionDto Question { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
    }
}
