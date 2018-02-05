using System;
using System.Collections.Generic;

namespace codingclub.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone {get; set;}
        public string Email {get; set;}
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}