using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entites
{
    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Insid { get; set; }
        public string Hiredate { get; set; }
        [ForeignKey(nameof(Id))]
        public Instructor Instructor { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

    }
}
