using FletchersBookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FletchersBookStore.Models
{
    public class FletchersBookStoreContext : DbContext
    {
        public FletchersBookStoreContext (DbContextOptions<FletchersBookStoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
