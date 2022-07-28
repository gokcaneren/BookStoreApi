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
    public class BookService : Service<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IGenericRepository<Book> repository, IUnitOfWork unitOfWork, IBookRepository bookRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BooksWithCategoryDto>> GetBooksWithCategory()
        {
            var books = await _bookRepository.GetBooksWithCategory();
            var booksDto = _mapper.Map<List<BooksWithCategoryDto>>(books);
            return booksDto;
        }
    }
}
