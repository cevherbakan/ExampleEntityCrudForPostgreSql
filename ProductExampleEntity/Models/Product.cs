using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductExampleEntity.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Explanation { get; set; }
    }
}
