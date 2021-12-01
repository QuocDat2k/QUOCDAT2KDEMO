using System;
using System.ComponentModel.DataAnnotations;

namespace dotnet.Models
{
    public class Product
    {
        [Key]
        public string?  ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? UnitPrice { get; set; }
        public string? Quantity { get; set; }

    }
}