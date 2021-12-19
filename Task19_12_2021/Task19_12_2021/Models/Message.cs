using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task19_12_2021.Models
{
    public class Message
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Fullname { get; set; }

        [MaxLength(50)]
        public string E_mail { get; set; }

        [MaxLength(10)]
        public string Subject { get; set; }

        [Column(TypeName ="ntext")]
        public string Message_ { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
