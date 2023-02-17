using System;
using BookStudent.Week28.Homework.Data.Entities;

namespace BookStudent.Week28.Homework.Services.Interfaces
{
	public interface IBookService
	{
        public Task<List<Book>> Get();
        public Task<Book> Get(int id);
        public Task<Book> Create(Book book);
        public Task Delete(int id);
        public Task<Book> Update(int id, Book book);
    }
}

