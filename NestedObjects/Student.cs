﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Student
    {
        public Student()
        {
            AssignedAdvisor = new Advisor();
        }

        /// <summary>
        /// The full name of the student
        /// (First MiddleInitial Last)
        /// </summary>
        
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public Advisor AssignedAdvisor { get; set; }
    }
}
