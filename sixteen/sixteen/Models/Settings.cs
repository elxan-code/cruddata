using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string About { get; set; }
        [MaxLength(250)]
        public string AboutImage { get; set; }
        [MaxLength(100)]
        public string Copyright { get; set; }
    }
}
