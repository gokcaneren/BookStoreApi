using AutoMapper;
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
        private readonly IService<Book> _service;
        private readonly IMapper _mapper;
        public BookController(IService<Book> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

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
    }
}
