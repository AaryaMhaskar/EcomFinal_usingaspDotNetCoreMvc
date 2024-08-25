﻿using System.ComponentModel.DataAnnotations;

namespace EcomFinal_usingaspDotNetCoreMvc.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string ?Description { get; set; }

        public string? suser { get; set; }
        public string ?Image { get; set; }

        public double Price { get; set; }
        public string ?Category { get; set; }
    }
}
