using System;
namespace BookStudent.Week28.Homework.Data.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set;}
        public string Surname { get; set; }
		public string? Address { get; set; }

        public Student()
		{
		}
	}
}

