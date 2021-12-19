using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task19_12_2021.Models
{
    public class Our_team
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(150)]
        public string Fullname { get; set; }

        [MaxLength(250)]
        public string About { get; set; }

        [ForeignKey("Specialty")]
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
