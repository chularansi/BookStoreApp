using BookStore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.UI.Services
{
    public interface IBookRepository : IBaseRepository<BookModel>
    {
    }
}
