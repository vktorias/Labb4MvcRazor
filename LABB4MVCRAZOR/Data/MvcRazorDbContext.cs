using LABB4MVCRAZOR.Models;
using Microsoft.EntityFrameworkCore;

namespace LABB4MVCRAZOR.Data
{
    public class MvcRazorDbContext : DbContext
    {
        public MvcRazorDbContext(DbContextOptions<MvcRazorDbContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Lending> Lendings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            SeedData(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerName = "Viktoria Wallström", Email = "viktoria-wallstrom@hotmail.com", PhoneNumber = "0701234567" },
                new Customer { CustomerId = 2, CustomerName = "Nelly Nordlund", Email = "nellynordlund@gmail.com", PhoneNumber = "0702345678" },
                new Customer { CustomerId = 3, CustomerName = "Kelly Olsson", Email = "kellyolsson@hotmail.com", PhoneNumber = "0703456789" }
                );
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "A day in the country", Author = "Evelyn Larson", PublicationYear = 1996 },
                new Book { BookId = 2, Title = "The Dog's Preference: A Human's Guide", Author = "Lily.P", PublicationYear = 1990 },
                new Book { BookId = 3, Title = "Lovely Life of Ella", Author = "Ella Hermansson", PublicationYear = 2000 },
                new Book { BookId = 4, Title = "Coding Mastery in a Month", Author = "Fredrick Allingås", PublicationYear = 2005 },
                new Book { BookId = 5, Title = "Food History", Author = "Eva Rönnberg", PublicationYear = 2010 },
                new Book { BookId = 6, Title = "Survive In The Forest", Author = "Liv Bergman", PublicationYear = 1967 },
                new Book { BookId = 7, Title = "Fishing Guide", Author = "Gunnar Olsen", PublicationYear = 2015 },
                new Book { BookId = 8, Title = "How to Saving Money", Author = "Malin Gullikson", PublicationYear = 2006 },
                new Book { BookId = 9, Title = "Abrakadabra", Author = "Tobbe Trollkarl", PublicationYear = 2001 }
                );
            modelBuilder.Entity<Lending>().HasData(
            new Lending { LendingId = 1, CustomerId = 1, BookId = 1, LendDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 28), Returned = true },
            new Lending { LendingId = 2, CustomerId = 1, BookId = 2, LendDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 04, 28), Returned = false },
            new Lending { LendingId = 3, CustomerId = 2, BookId = 3, LendDate = new DateTime(2024, 04, 18), ReturnDate = new DateTime(2024, 04, 26), Returned = true },
            new Lending { LendingId = 4, CustomerId = 3, BookId = 4, LendDate = new DateTime(2024, 04, 25), ReturnDate = new DateTime(2024, 05, 02), Returned = false },
            new Lending { LendingId = 5, CustomerId = 4, BookId = 5, LendDate = new DateTime(2024, 05, 07), ReturnDate = new DateTime(2024, 05, 22), Returned = false },
            new Lending { LendingId = 6, CustomerId = 4, BookId = 6, LendDate = new DateTime(2024, 05, 05), ReturnDate = new DateTime(2024, 05, 20), Returned = false },
            new Lending { LendingId = 7, CustomerId = 5, BookId = 7, LendDate = new DateTime(2024, 05, 02), ReturnDate = new DateTime(2024, 05, 19), Returned = false },
            new Lending { LendingId = 8, CustomerId = 5, BookId = 8, LendDate = new DateTime(2024, 04, 20), ReturnDate = new DateTime(2024, 05, 06), Returned = true },
            new Lending { LendingId = 9, CustomerId = 6, BookId = 9, LendDate = new DateTime(2024, 04, 15), ReturnDate = new DateTime(2024, 05, 01), Returned = true }
                );
        }
    }
}
