using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookProject.Models;

namespace BookProject.Data
{
    public class BookProjectContext : DbContext
    {
        public BookProjectContext (DbContextOptions<BookProjectContext> options)
            : base(options)
        {
        }

        public DbSet<BookProject.Models.Book> Book { get; set; } = default!;
        public DbSet<BookProject.Models.Customer> Customer { get; set; } = default!;
        public DbSet<BookProject.Models.Rental> Rental { get; set; } = default!;
    }
}
