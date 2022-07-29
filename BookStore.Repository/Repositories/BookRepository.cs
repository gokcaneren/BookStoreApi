using BookStore.Core.Models;
using BookStore.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Book>> GetBooksWithCategory()
        {
            return await _context.Books.Include(x => x.Category).ToListAsync();
        }
    }
}
