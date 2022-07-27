using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsnyc();
        void Commit();
    }
}
