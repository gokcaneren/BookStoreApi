using AutoMapper;
using BookStore.Api.Filters;
using BookStore.Core.DTOs.Requests;
using BookStore.Core.DTOs.Respons;
using BookStore.Core.Models;
using BookStore.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;
        private readonly IMapper _mapper;
        public BookController(IMapper mapper, IBookService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [ServiceFilter(typeof(NotFoundFilter<Book>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _service.GetByIdAsync(id);
            var bookDto = _mapper.Map<BookResponsDto>(book);
            return Ok(bookDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _service.GetAllAsync();
            var booksDto= _mapper.Map<List<BookResponsDto>>(books.ToList());
            return Ok(booksDto);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> BooksWithCategory()
        {
            return Ok(await _service.GetBooksWithCategory());
        }
        
        [HttpPost]
        public async Task<IActionResult> Save(AddBookRequest request)
        {
            var book = _mapper.Map<Book>(request);
            await _service.AddAsync(book);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateBookRequest request)
        {
            var book= _mapper.Map<Book>(request);
            await _service.UpdateAsync(book);
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var book = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(book);
            return NoContent();
        }
    }
}
