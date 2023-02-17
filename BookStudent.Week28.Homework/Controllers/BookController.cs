using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStudent.Week28.Homework.Data.Entities;
using BookStudent.Week28.Homework.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStudent.Week28.Homework.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var books = await _bookService.Get();
            return Ok(books);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var book = await _bookService.Get(id);
            if (book == null)
                return NotFound("No book was found");
            return Ok(book);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (book == null)
                return BadRequest();
            var createdBook = await _bookService.Create(book);
            return Ok(createdBook);
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<IActionResult> Update(int id, Book book)
        {
            await _bookService.Update(id, book);
            return Ok(book);
        }

        // DELETE api/values/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _bookService.Delete(id);
            return Ok();
        }
    }
}

