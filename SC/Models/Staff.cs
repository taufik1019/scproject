using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Models
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public int Nik { get; set; }
        public string Name { get; set; }
    }
}
