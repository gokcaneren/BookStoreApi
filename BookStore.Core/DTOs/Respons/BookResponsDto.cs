using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs.Respons
{
    public class BookResponsDto:BaseDto
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public string AuthorName { get; set; }
        public int CategoryId { get; set; }
    }
}
