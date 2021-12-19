using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Task19_12_2021.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Iamge { get; set; }

        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        [MaxLength(250)]
        public string Content { get; set; }

        public int ReviewsID { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
