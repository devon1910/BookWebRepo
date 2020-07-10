using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MybookWeb.Entities;
using MybookWeb.Enums;
using MybookWeb.Interface;
using MybookWeb.Models;

namespace MybookWeb.Controllers
{
    public class BookController : BaseController
    {
        private IBook _book;
        private IAuthor _author;
        private IGenre _genre;

        
        private readonly UserManager<ApplicationUser> _userManager;
        public BookController(IBook book, IAuthor author, IGenre genre, UserManager<ApplicationUser> userManager)
        {
            _book = book;
            _author = author;
            _userManager = userManager;
            _genre = genre;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _book.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book b)
        {
            b.CreatedBy =  _userManager.GetUserName(User);
         
            b.DateCreated = DateTime.Now;
            
            var createBook = await _book.AddAsync(b);
            if (createBook)
            {
                Alert("Book Created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var author = await _author.GetAll();
            var authorList = author.Select(a => new SelectListItem()
            {
                Value = a.Id.ToString(),
                Text = a.Title + " " + a.Name
            });
            var genre = await _genre.GetAll();
            var genreList = genre.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Name
            });
            
            ViewBag.author = authorList;
            ViewBag.genre = genreList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book b)
        {
            b.CreatedBy = _userManager.GetUserName(User);
          //  b.GenreId = 1;
            b.DateCreated = DateTime.Now;
            var editBook = await _book.Update(b);
            if (editBook && ModelState.IsValid)
            {
                Alert("Book Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editAuthor = await _book.GetById(id);

            if (editAuthor == null)
            {
                return RedirectToAction("Index");
            }
            var author = await _author.GetAll();
            var authorList = author.Select(a => new SelectListItem()
            {
                Value = a.Id.ToString(),
                Text = a.Title + " " + a.Name
            });
            var genre = await _genre.GetAll();
            var genreList = genre.Select(g => new SelectListItem()
            {
                Value = g.Id.ToString(),
                Text = g.Name
            });

            ViewBag.author = authorList;
            ViewBag.genre = genreList;
            //return View();
            return View(editAuthor);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteBook = await _book.Delete(id);
            if (deleteBook)
            {
                Alert("Book Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not Deleted!", NotificationType.error);
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
