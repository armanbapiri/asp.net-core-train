using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using System.Diagnostics;
using WebApplication5.Context;
using WebApplication5.Entity;
using WebApplication5.Interfaces;
using WebApplication5.Models;
using WebApplication5.Services;

namespace WebApplication5.Controllers
{
    public class HomeController(IUnitOfWork uow) : Controller
    {

        public IActionResult Index(int id)
        {

            var books = uow.Books.Read();
            //if (id > 0)
            //{
            //    books = books.Where(b => b.BookId == id);
            //}
            return View(books.ToList());
        }

        //private List<string> getCategories(IQueryable<List<BookCategoryRelationBook>> categories)
        //{
        //    List<string> result = new List<string>();
        //    foreach (var item in categories)
        //    {
        //        foreach (var item1 in item)
        //        {
        //            result.Add(item1.BookCategory.Title);
        //        }
        //    }
        //    return result;
        //}
        public class Course_Teacher
        {
            public string? CourseName { get; set; }
            public string? TeacherName { get; set; }
            public int MyProperty { get; set; }
        }
        public IActionResult Categories()
        {

            var categories = uow.Books.Read().Include(b => b.Categories).ThenInclude(c => c.BookCategory).SelectMany(c => c.Categories).Select(c => c.BookCategory.Title).Distinct().ToList();
            var categoryRelations = uow.bookCategoryRelations.Read().Select(c => c.CategoryBookId).ToList();
            categories = uow.BookCategories.Read().Select(c => c.Title).ToList();
            return View(categories);
        }

        public IActionResult Course()
        {


            return View(uow.Courses.Read().ToList());
        }
        public IActionResult Teacher()
        {
            var teacher = uow.Teachers.Read().ToList();
            return View(teacher);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
