using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entites
{
    public class Coreses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public int Credits { get; set; }

        public Topic Topic { get; set; }

        public ICollection<Crsins> Crsins { get; set; }

        public List<Stdcrs> Stdcrs { get; set; }
    }
}
