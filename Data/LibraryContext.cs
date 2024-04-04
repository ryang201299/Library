using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Data {
    public class LibraryContext : DbContext {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Book> Books { get; set; }
        
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");

            modelBuilder.Entity<Book>()
            .HasOne<Account>() // A book is checked out by one account
            .WithMany() // An account can check out multiple books
            .HasForeignKey(b => b.CheckedOutById) // Define the foreign key property
            .IsRequired(false); // Make the foreign key nullable to allow books to be checked out by no one
        }
    }
}