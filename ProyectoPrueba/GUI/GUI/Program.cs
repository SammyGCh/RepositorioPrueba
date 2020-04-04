using System;
using BusinessContext;
using DataAccess;

namespace GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("1234", "Juan", "Lopez");
            Student s2 = new Student("1235", "Maria", "Gomez");

            StudentDaoImp handleStudents = new StudentDaoImp();

            handleStudents.SaveStudent(s1);
            handleStudents.SaveStudent(s2);

            Console.WriteLine(handleStudents.GetStudentByName("Maria").Matricula);
        }
    }
}
