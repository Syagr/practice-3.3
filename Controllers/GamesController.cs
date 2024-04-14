using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestWebApp.Models;
using TestWebApp.Reps;

namespace TestWebApp.Controllers
{
    public class GamesController : Controller
    {
        DbRepository _gamesRepository;

        public GamesController(DbRepository gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }

        public ActionResult GameList()
        {
            return View(_gamesRepository.GetAllGames());
        }

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            var game = _gamesRepository.GetGameByid(id);

            return View(game);
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Game game)
        {
            try
            {
                _gamesRepository.AddGame(game);
                return RedirectToAction(nameof(GameList));
            }
            catch
            {
                return RedirectToAction(nameof(GameList));
            }
        }

        [HttpGet("Edit/{id}")]
        public ActionResult Edit(int id)
        {
            var game = _gamesRepository.GetGameByid(id);
            return View(game);
        }

        // POST: BooksController/Edit/5
        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Game game)
        {
            _gamesRepository.EditGame(game);
            
            return Redirect("/");
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            _gamesRepository.DeleteGameByid(id);
            return RedirectToAction(nameof(GameList));
        }
    }
}
