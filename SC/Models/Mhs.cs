using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SC.Models
{
    public class Mhs
    {
        [Key]
        public int Id { get; set; }
        public int Npm { get; set; }
        public string Name { get; set; }
        public string Jurusan { get; set; }
        public int Age { get; set; }
        public string Alamat { get; set; }
        public string Image { get; set; }
        
    }
}
