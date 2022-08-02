using BookStore.Core.DTOs.Respons;
using BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        public Task<CategoryWithBooksDto> GetCategoryWithBooks(int categoryId);
    }
}
