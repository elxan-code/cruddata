using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Models
{
    public class Options
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [Column(TypeName = "ntext")]
        public string Info { get; set; }
    }
}
