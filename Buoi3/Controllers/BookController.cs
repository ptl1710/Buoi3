using Buoi3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Buoi3.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            BookManagerContext context = new BookManagerContext();
            var listBook = context.Book.ToList();
            return View(listBook);
        }

        [Authorize]

        public ActionResult Buy(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book book = context.Book.SingleOrDefault(p => p.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        public ActionResult CreateBook()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult CreateBook(Book book)
        {
            BookManagerContext context = new BookManagerContext();
            context.Book.AddOrUpdate(book);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }

        public ActionResult EditBook(int id)
        {
            BookManagerContext context = new BookManagerContext();
            
            Book db = context.Book.SingleOrDefault(p => p.ID == id);
            if(db == null )
            {
                return HttpNotFound();
            }
            
            return View(db);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditBook(Book books)
        {
            BookManagerContext context = new BookManagerContext();
            Book dbUpdate = context.Book.SingleOrDefault(p => p.ID == books.ID);
            if(dbUpdate != null)
            {
                context.Book.AddOrUpdate(books);
                context.SaveChanges();
                
            }

            return RedirectToAction("ListBook");
        }

        public ActionResult DeleteBook(int id)
        {
            BookManagerContext context = new BookManagerContext();
            Book db = context.Book.SingleOrDefault(p => p.ID == id);
            if (db == null)
            {
                return HttpNotFound();
            }
            return View(db);
        }

        [Authorize]
        [HttpPost]
        public ActionResult DeleteBook(Book book)
        {
            BookManagerContext context = new BookManagerContext();
            Book db = context.Book.SingleOrDefault(p => p.ID == book.ID);
            if(db !=null)
            {
                context.Book.Remove(db);
                context.SaveChanges();
            }

            return RedirectToAction("ListBook");
        }
    }
}