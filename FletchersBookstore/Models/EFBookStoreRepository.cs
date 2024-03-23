using FletchersBookStore.Models;

namespace FletchersBookStore.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private FletchersBookStoreContext _context;

        public EFBookStoreRepository(FletchersBookStoreContext temp) {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
