using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entites
{
    [PrimaryKey("InstructorId", "CoresesId")]
    public class Crsins
    {
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public int CoresesId { get; set; }
        public Coreses coreses { get; set; }

        public int evaluate { get; set; }
    }
}
