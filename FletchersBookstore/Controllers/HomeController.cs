using FletchersBookStore.Models;
using FletchersBookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FletchersBookStore.Controllers
{
    public class HomeController : Controller
    {
        
        private IBookStoreRepository _repo;
        public HomeController(IBookStoreRepository temp)
        {
           _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {   int pageSize = 5;

            var setup = new BookListViewModel
            {

                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip(pageSize * (pageNum - 1))
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            
            return View(setup);
        }
    }
}
