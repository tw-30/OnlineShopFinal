﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        // EF will instruct the database to automatically generate this value
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public int CategoryID { get; set; }  // foreign key property

        public Category Category { get; set; }

        [Required(ErrorMessage = "Please enter a product code.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter a product name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a product price.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Slug
        {
            get
            {
                if (Name == null)
                    return "";
                else
                    return Name.Replace(' ', '-');
            }
        }
    }
}