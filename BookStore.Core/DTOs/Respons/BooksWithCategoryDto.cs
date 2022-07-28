using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.DTOs.Respons
{
    public class BooksWithCategoryDto:BookResponsDto
    {
        public CategoryResponsDto CategoryRespons { get; set; }
    }
}
