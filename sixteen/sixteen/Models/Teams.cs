using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Models
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Info { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Specality")]
        public int SpecalityId { get; set; }
        public Specality Specality { get; set; }
      

    }
}
