﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class QuizResultDto
    {
        public int Id { get; set; }
        public int QuizAttemptId { get; set; }
        public QuizAttemptDto QuizAttempt { get; set; }
        public string Comment { get; set; }
        public double Score { get; set; }
    }
}
