using book.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace book.Database.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}
