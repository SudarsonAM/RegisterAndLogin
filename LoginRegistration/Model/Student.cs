using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginRegistration.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }

        public string Course { get; set;}

        public string Gender { get; set; }

        public int Age { get; set; }
    }
}