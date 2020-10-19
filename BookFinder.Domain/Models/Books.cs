using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Domain.Models
{
    public class Books
    {
        public string isbn { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public float cost { get; set; }
        public string descriptuon { get; set; }
    }
}
