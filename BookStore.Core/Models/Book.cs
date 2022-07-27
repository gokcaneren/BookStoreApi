using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Models
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public string AuthorName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
