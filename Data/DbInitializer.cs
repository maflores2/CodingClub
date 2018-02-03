using codingclub.Models;
using System;
using System.Linq;

namespace codingclub.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClubContext context)
        {
            context.Database.EnsureCreated();

            // Look for any members.
            if (context.Members.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Member[]
            {
            new Member{FirstName="Max",LastName="Flores",Phone="806-228-6176",Email="maflores2@buffs.wtamu.edu",EnrollmentDate=DateTime.Parse("2018-01-31")},
            new Member{FirstName="Tyler",LastName="Massey",Phone="806-877-4586",Email="thebest455@hotmail.com",EnrollmentDate=DateTime.Parse("2017-09-01")},
            new Member{FirstName="George",LastName="Romero",Phone="806-458-8799",Email="thelegend27@curry.com",EnrollmentDate=DateTime.Parse("2017-12-06")}
            };
            foreach (Member s in students)
            {
                context.Members.Add(s);
            }
            context.SaveChanges();

            var courses = new Project[]
            {
            new Project{ProjectID=1,Name="Banking app",Description="Banking app for the banking clan",StartDate=DateTime.Parse("2017-01-06"),CompletionDate=DateTime.Parse("2017-02-04")},

            };
            foreach (Project c in courses)
            {
                context.Projects.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{MemberID=1,ProjectID=1},
            new Enrollment{MemberID=2,ProjectID=1},
            new Enrollment{MemberID=3,ProjectID=1}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}