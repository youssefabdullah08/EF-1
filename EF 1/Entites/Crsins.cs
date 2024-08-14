using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entites
{

    public class Crsins
    {
        [Key]
        public int insid { get; set; }
        public int Crsid { get; set; }
        public int evaluate { get; set; }
    }
}
