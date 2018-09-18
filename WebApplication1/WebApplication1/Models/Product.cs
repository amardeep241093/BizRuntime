using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("tblProducts")]
    public class Product
    {   
        [Key]
        public int ProductId { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }

        public Category category { get; set; }
    }
}