﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doamin.Entities
{
    public class QuizResult
    {
        public int Id { get; set; }
        public int QuizAttemptId { get; set; }
        public QuizAttempt QuizAttempt { get; set; }
        public string Comment { get; set; }
        public double Score { get; set; }
    }
}
