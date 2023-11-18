using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VegaITELEC1C.Models;

namespace VegaITELEC1C.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Alena",
                    LastName = "Varona",
                    IsRegular = IsRegular.Regular,
                    AdmissionDate = DateTime.Now,
                    Course = Course.BSIT,
                    Email = "alena.varona.cics@ust.edu.ph"
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Carlos",
                    LastName = "Vega",
                    IsRegular = IsRegular.Regular,
                    AdmissionDate = DateTime.Now,
                    Course = Course.BSCS,
                    Email = "carlosvincent.vega.cics@ust.edu.ph"
                },
                new Student
                {
                    Id = 3,
                    FirstName = "LLoyd",
                    LastName = "Chavez",
                    IsRegular = IsRegular.Debarred,
                    AdmissionDate = DateTime.Now,
                    Course = Course.BSIS,
                    Email = "jopay.onat.cics@ust.edu.ph"
                }
                );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    Id = 1,
                    FirstName = "Carlos",
                    LastName = "Vega",
                    isTenured = true,
                    Rank = Rank.AssociateProfessor,
                    HiringDate = DateTime.Parse("06/6/2020").Date,
                    EmailAddress = "a@gmail.com",
                    PhoneNumber = "03-321-7645"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Alena",
                    LastName = "Varona",
                    isTenured = true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("04/20/2021").Date,
                    EmailAddress = "amv@yahoo.com",
                    PhoneNumber = "03-420-6969"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "KING",
                    LastName = "KONG",
                    isTenured = false,
                    Rank = Rank.AssistantProfessor,
                    HiringDate = DateTime.Parse("09/11/2023").Date,
                    EmailAddress = "gg@gmail.com",
                    PhoneNumber = "01-091-5555"
                },
                new Instructor
                {
                    Id = 4,
                    FirstName = "John",
                    LastName = "LLoyd",
                    isTenured = false,
                    Rank = Rank.Instructor,
                    HiringDate = DateTime.Parse("09/12/2023").Date,
                    EmailAddress = "haha@gmail.com",
                    PhoneNumber = "02-666-1111"
                }
                );
        }
   


    }
}
