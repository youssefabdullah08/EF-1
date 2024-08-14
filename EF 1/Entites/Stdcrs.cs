using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entites
{
    public class Stdcrs
    {
        [Key]
        public int Stdid { get; set; }
        public int Crsid { get; set; }
        public int Grade { get; set; }
    }
}
