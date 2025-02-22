﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doamin.Entities
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Content {  get; set; }
        public string RightAnswer { get; set; }
        public List<string> Options { get; set; }
    }
}
