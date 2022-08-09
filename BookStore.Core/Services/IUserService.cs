using BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Services
{
    public interface IUserService:IService<User>
    {
        User ValidateUser(string username, string password);
    }
}
