using System;
using BookStudent.Week28.Homework.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStudent.Week28.Homework.Data.MyDbContext
{
	public class BookStudentDbContext: DbContext
	{
		public BookStudentDbContext(DbContextOptions options)
			:base(options)
		{

		}

		public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}

