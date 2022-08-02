using AutoMapper;
using BookStore.Core.DTOs.Respons;
using BookStore.Core.Models;
using BookStore.Core.Repositories;
using BookStore.Core.Services;
using BookStore.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork, IMapper mapper, ICategoryRepository categoryRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryWithBooksDto> GetCategoryWithBooks(int categoryId)
        {
            var category = await _categoryRepository.GetCategoryWithBooks(categoryId);
            var categoryDto = _mapper.Map<CategoryWithBooksDto>(category);
            return categoryDto;
        }
    }
}
