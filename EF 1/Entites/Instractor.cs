﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entites
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int DeptId { get; set; }
        public Dept Dept { get; set; }

        public ICollection<Crsins> Crsins { get; set; }
    }

}
