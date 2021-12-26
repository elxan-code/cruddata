using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Fullname { get; set; }
        [MaxLength(20)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext")]
        public string Yourmessage { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
