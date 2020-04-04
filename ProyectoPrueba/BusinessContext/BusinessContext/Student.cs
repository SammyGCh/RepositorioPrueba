using System;

namespace BusinessContext
{
    public class Student
    {
        private String matricula;
        private String name;
        private String lastName;

        public Student(String matricula, String name, String lastName)
        {
            this.matricula = matricula;
            this.name = name;
            this.lastName = lastName;
        }

        public String Matricula
        {
            get
            {
                return this.matricula;
            }

            set
            {
                this.matricula = value;
            }
        }

        public String Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public String LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

    }
}
