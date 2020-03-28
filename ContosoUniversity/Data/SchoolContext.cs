using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ContosoUniversity.Models;
//using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
            /*  modelBuilder.Entity<Course>().HasData(
                 new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
                  new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3 },
              new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3 },
              new Course { CourseID = 1045, Title = "Calculus", Credits = 4 },
              new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4 },
              new Course { CourseID = 2021, Title = "Composition", Credits = 3 },
              new Course { CourseID = 2042, Title = "Literature", Credits = 4 }

                             );

              modelBuilder.Entity<Enrollment>().HasData(

                   new Enrollment { EnrollmentID=101, StudentID = 1, CourseID = 1050, Grade = Grade.A },
                   new Enrollment { EnrollmentID = 102,StudentID = 1, CourseID = 1050, Grade = Grade.A },
              new Enrollment { EnrollmentID = 103,StudentID = 1, CourseID = 4022, Grade = Grade.C },
              new Enrollment { EnrollmentID = 104,StudentID = 1, CourseID = 4041, Grade = Grade.B },
              new Enrollment { EnrollmentID = 105,StudentID = 2, CourseID = 1045, Grade = Grade.B },
              new Enrollment { EnrollmentID = 106,StudentID = 2, CourseID = 3141, Grade = Grade.F },
              new Enrollment { EnrollmentID = 107,StudentID = 2, CourseID = 2021, Grade = Grade.F },
              new Enrollment { EnrollmentID = 108,StudentID = 3, CourseID = 1050 },
              new Enrollment { EnrollmentID = 109, StudentID = 4, CourseID = 1050 },
              new Enrollment { EnrollmentID = 110,StudentID = 4, CourseID = 4022, Grade = Grade.F },
              new Enrollment { EnrollmentID = 111,StudentID = 5, CourseID = 4041, Grade = Grade.C },
              new Enrollment { EnrollmentID = 112,StudentID = 6, CourseID = 1045 },
              new Enrollment { EnrollmentID = 113,StudentID = 7, CourseID = 3141, Grade = Grade.A }





                  );

              modelBuilder.Entity<Student>().HasData(



                  new Student { ID=1,FirstMidName = "Nisha", LastName = "Sethi", EnrollmentDate = DateTime.Parse("2005-09-01") },
                  new Student { ID=2,FirstMidName = "John", LastName = "Smith", EnrollmentDate = DateTime.Parse("2002-09-01") },
              new Student { ID=3,FirstMidName = "Sally", LastName = "Jones", EnrollmentDate = DateTime.Parse("2003-09-01") },
              new Student { ID=4,FirstMidName = "Gytis", LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") },
              new Student { ID=5,FirstMidName = "Yan", LastName = "Li", EnrollmentDate = DateTime.Parse("2002-09-01") },
              new Student { ID=6,FirstMidName = "Peggy", LastName = "Justice", EnrollmentDate = DateTime.Parse("2001-09-01") },
              new Student { ID=7,FirstMidName = "Laura", LastName = "Norman", EnrollmentDate = DateTime.Parse("2003-09-01") },
              new Student { ID=8,FirstMidName = "Nino", LastName = "Olivetto", EnrollmentDate = DateTime.Parse("2005-09-01") }

                  );
          }*/
        }
    }
}