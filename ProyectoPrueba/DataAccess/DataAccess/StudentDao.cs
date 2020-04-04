using System;
using System.Collections.Generic;
using System.Text;
using BusinessContext;

namespace DataAccess
{
    interface StudentDao
    {
        Boolean SaveStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentByName(String name);
        Boolean DeleteStudent(Student student);
    }
}
