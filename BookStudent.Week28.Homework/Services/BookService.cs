
using System;
using BookStudent.Week28.Homework.Data.Entities;
using BookStudent.Week28.Homework.Data.MyDbContext;
using BookStudent.Week28.Homework.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookStudent.Week28.Homework.Services
{
	public class BookService: IBookService
	{
		private readonly BookStudentDbContext _dB;

        public BookService(BookStudentDbContext dbContext)
        {
            _dB = dbContext;
        }

        public async Task<Book> Create(Book book)
        {
            await _dB.AddAsync(book);
            await _dB.SaveChangesAsync();
            return book;
        }

        public async Task<List<Book>> Get()
        {
            return await _dB.Books.ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            Book? book = await _dB.Books.FirstOrDefaultAsync(b => b.Id == id);
            return book;
        }

        public async Task Delete(int id)
        {
            var book = _dB.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                throw new ArgumentNullException();
            _dB.Books.Remove(book);
            await _dB.SaveChangesAsync();
        }

        public async Task<Book> Update(int id, Book book)
        {
            var existingBook = await _dB.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (existingBook == null)
                throw new ArgumentNullException();
            existingBook = book;
            await _dB.SaveChangesAsync();
            return book;
        }
    }
}

