﻿using BookStore.Core.Models;
using BookStore.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {

        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetCategoryWithBooks(int categoryId)
        {
            return await _context.Categories.Include(x => x.Books).Where(x => x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}

