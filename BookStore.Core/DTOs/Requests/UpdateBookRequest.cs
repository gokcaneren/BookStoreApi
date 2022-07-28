using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs.Requests
{
    public class UpdateBookRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string AuthorName { get; set; }
        public int CategoryId { get; set; }
    }
}
