using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Models
{
    public class User
    {
        [Key]
        [ForeignKey("Mhs")]
        
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public Staff Staff { get; set; }
        [ForeignKey("Staff")]
        public int StaffId { get; set; }
        public Mhs Mhs { get; set; }
        public int MhsId { get; set; }
    }
}
