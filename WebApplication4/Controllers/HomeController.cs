using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{

    public class HomeController : Controller
    {
        BookContext db = new BookContext();

        private BookContext _context = new BookContext();
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Popular()
        {
            var books = db.Book.OrderByDescending(b => b.rate);
            ViewBag.Book = books;
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult SortByPopularity()
        {
            List<Books> sortedBooks = _context.Book.OrderByDescending(b => b.rate).ToList();
            return View("Goods", sortedBooks);
        }

        public ActionResult SortByPrice()
        {
            List<Books> sortedBooks = _context.Book.OrderByDescending(b => b.price).ToList();
            return View("Goods", sortedBooks);
        }

        public ActionResult SortByYear()
        {
            List<Books> sortedBooks = _context.Book.OrderByDescending(b => b.year).ToList();
            return View("Goods", sortedBooks);
        }

        public ActionResult Goods(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                List<Books> searchResults = db.Book.Where(b => b.name.Contains(query)).ToList();
                if (searchResults == null)
                {
                    List<Books> sortedBooks = _context.Book.OrderByDescending(b => b.rate).ToList();
                    ViewBag.SearchResults = searchResults;
                    return View();
                }
                ViewBag.SearchResults = searchResults;
                return View();
            }
            else
            {
                List<Books> sortedBooks = _context.Book.OrderByDescending(b => b.rate).ToList();
                ViewBag.SearchResults = sortedBooks;
                return View();
            }
        }
        
        public ActionResult BookDetails(int id)
        {
            Books book = _context.Book.FirstOrDefault(b => b.id == id);


            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }

    }
}