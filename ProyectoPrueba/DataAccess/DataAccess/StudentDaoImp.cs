using System;
using System.Collections.Generic;
using BusinessContext;

namespace DataAccess
{
    public class StudentDaoImp : StudentDao
    {
        private List<Student> students;
        private Student student;
        public StudentDaoImp()
        {
            students = new List<Student>();
            student = null;
        }

        public Boolean SaveStudent(Student student)
        {
            students.Add(student);
            return true;
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Student GetStudentByName(String name)
        {
            foreach(Student s in students)
            {
                if (s.Name.Equals(name))
                {
                    student = new Student(s.Matricula, s.Name, s.LastName);
                    break;
                }
            }

            return student;
        }
        public Boolean DeleteStudent(Student student)
        {
            students.Remove(student);
            return true;
        }

    }
}
