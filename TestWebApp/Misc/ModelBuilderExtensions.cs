using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Misc
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student
                {
                    Id = 1,
                    Name = "Bob",
                    GroupId = 1
                },
                new Student
                {
                    Id = 2,
                    Name = "Bub",
                    GroupId = 1
                },
                new Student
                {
                    Id = 3,
                    Name = "Beb",
                    GroupId = 2
                }
            );

            modelBuilder.Entity<Group>().HasData(new Group
                {
                    Id = 1,
                    Name = "100"
                },
                new Group
                {
                    Id = 2,
                    Name = "200"
                }
            );
        }
    }
}
