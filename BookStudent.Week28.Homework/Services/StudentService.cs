using System;
using BookStudent.Week28.Homework.Data.MyDbContext;
using BookStudent.Week28.Homework.Services.Interfaces;

namespace BookStudent.Week28.Homework.Services
{
	public class StudentService: IStudentService
	{
		private readonly BookStudentDbContext _dB;

        public StudentService(BookStudentDbContext dbContext)
        {
            _dB = dbContext;
        }
	}
}

