using BookStore.Core.Models;
using BookStore.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public User ValidateUser(string username, string password)
        {
            return _context.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }
    }
}
