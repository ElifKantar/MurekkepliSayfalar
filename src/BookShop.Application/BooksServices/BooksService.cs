using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BookShop.Application.BooksServices.Dto;
using BookShop.Core.Book;
using BookShop.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Application.BooksServices
{
    public class BooksService : IBookService
    {
        private ApplicationUserDbContext _context;
        public BooksService(ApplicationUserDbContext context)
        {
            _context = context;
        }

        public async Task<Books> Get(int id)
        {
            var item = await _context.Books.FindAsync(id);
            return item;
        }

        public async Task<List<Books>> GetAll()
        {
            var list = await _context.Books
                .ToListAsync();
            return list;
        }

        public async Task<Books> Create(CreateBook input)
        {
            Books newBook = Books.Create(input.Name, input.Author, input.Description, input.CreatorUserId);
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return newBook;
        }

        public Task<Books> Update(UpdateBook input)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
