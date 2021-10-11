using System;

namespace IENUMERABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            // data source
            var student1  = new Student { Id = 1,  Name = "Mridul",   Standard = 1 };
            var student2  = new Student { Id = 2,  Name = "Bijoy",    Standard = 2 };
            var student3  = new Student { Id = 3,  Name = "Upama",    Standard = 4 };
            var student4  = new Student { Id = 4,  Name = "Mubasher", Standard = 3 };
            var student5  = new Student { Id = 5,  Name = "Sakib",    Standard = 5 };
            var student6  = new Student { Id = 6,  Name = "Sultan",   Standard = 6 };
            var student7  = new Student { Id = 7,  Name = "Tanjib",   Standard = 8 };
            var student8  = new Student { Id = 8,  Name = "Tanvir",   Standard = 9 };
            var student9  = new Student { Id = 9,  Name = "Kazi",     Standard = 5 };
            var student10 = new Student { Id = 10, Name = "Sourav",   Standard = 6 };

            School students = new School();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);
            students.Add(student8);
            students.Add(student9);
            students.Add(student10);

            // you have to cast your data in data structure if you write var [foreach (var student in students)], you will get error.
            foreach (Student student in students)
            {
                Console.WriteLine($"id - {student.Id}, name - {student.Name}, class - {student.Standard}");
            }
        }
    }


    /// <summary>
    /// data structure
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
    }
}
