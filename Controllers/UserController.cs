using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{   //User/Index
    public class UserController : Controller
    {
        LibraryDb libraryDb;

        public UserController()
        {
            //libraryDb = LibraryDb.Instance;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View(libraryDb.Users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            var user = libraryDb.Users.FirstOrDefault(x => x.Id == id);

            return View(user);
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            var user = libraryDb.Users.FirstOrDefault(x => x.Id == id);

            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User editedUser)
        {
            var user = libraryDb.Users.FirstOrDefault(x => x.Id == id);

            user.Email = editedUser.Email;
            user.Name = editedUser.Name;

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
