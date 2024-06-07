using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExampleGridProduct.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Product_Type { get; set; }
        public string Glass_Type { get; set; }
        public string Thickness { get; set; }
        public string Color { get; set; }
        public string PartNo { get; set; }
        public bool IsSurface { get; set; }
    }
}