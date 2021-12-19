using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task19_12_2021.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName ="ntext")]
        public string About_office { get; set; }
    }
}
