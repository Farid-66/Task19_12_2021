using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task19_12_2021.Models
{
    public class About
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(250)]
        public string Our_bg_image { get; set; }

        [Column(TypeName ="ntext")]
        public string Our_bg_Content { get; set; }
    }
}
