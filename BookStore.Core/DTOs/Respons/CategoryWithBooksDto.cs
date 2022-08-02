using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs.Respons
{
    public class CategoryWithBooksDto:CategoryResponsDto
    {
        public List<BookResponsDto> Books { get; set; }
    }
}
