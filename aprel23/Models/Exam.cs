﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel23.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int ExamDuration { get; set; } 
        public DateTime StartDate { get; private set; }
        public DateTime EndDate => StartDate.AddHours(ExamDuration); 

        public void Start()
        {
            StartDate = DateTime.Now;
        }
    }
}
