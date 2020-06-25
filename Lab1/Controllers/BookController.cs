using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public string HelloTeacher(string university)
        {
            return "Hello Nguyen Dinh Anh " + university;
        }

        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5 & CSS3 The Complete Manual - Author Name Book 1");
            books.Add("HTML5 & CSS3 Responsive Web Design cookbook - Author Name Book 2");
            books.Add("Profressional ASP .NET MVC5 - Author Name Book 3");
            ViewBag.Books = books;
            return View();
        }

        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The Complete Manual", "Author Name Book 1", "/Content/Images/book1cover.jpg"));
            books.Add(new Book(1, "HTML5 & CSS3 Responsive Web Design cookbook", "Author Name Book 2", "/Content/Images/book2cover.jpg"));
            books.Add(new Book(1, "Profressional ASP .NET MVC5", "Author Name Book 3", "/Content/Images/book3cover.jpg"));

            return View(books);
        }
    }
}