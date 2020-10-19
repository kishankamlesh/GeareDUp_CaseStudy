using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BookFinder.Domain.Models
{
    public class Book
    {
        [Key]
        public string isbn { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public float cost { get; set; }
        public string descriptuon { get; set; }
    }
}
