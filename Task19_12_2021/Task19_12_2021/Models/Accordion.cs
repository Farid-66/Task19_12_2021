using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Task19_12_2021.Models
{ 
    public class Accordion
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string Content { get; set; }
    }
}
