using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Entites
{
    [PrimaryKey("Studentid", "Coreseid")]
    public class Stdcrs
    {
        public int Studentid { get; set; }
        public Student Student { get; set; }
        public int Coreseid { get; set; }
        public Coreses Corese { get; set; }
        public int Grade { get; set; }
    }
}
