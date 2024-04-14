using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Reps
{
    public class DbRepository
    {
        LibraryDb _db;
        public DbRepository(LibraryDb db)
        {
            _db = db;
        }

        public void AddGame(Game game)
        {
            _db.Games.Add(game);
            _db.SaveChanges();
        }

        public void EditGame(Game game)
        {
            var existingGame = _db.Games.FirstOrDefault(x => x.Id == game.Id);

            existingGame.Name = game.Name;
            existingGame.Genre = game.Genre;           

            _db.SaveChanges();
        }
        public Game GetGameByid(int id)
        {
            var game = _db.Games.FirstOrDefault(x => x.Id == id);

            return game;
        }

        public void DeleteGameByid(int id)
        {
            var gameToRemove = _db.Games.FirstOrDefault(x => x.Id == id);         

            _db.Games.Remove(gameToRemove);

            _db.SaveChanges();
        }

        public List<Game> GetAllGames()
        {
           return _db.Games.ToList();
        }


        public void SEED()
        {
            for (int i = 0; i < 100; i++)
            {
               _db.Games.Add(new Game() { Genre = $"Genre {i}", Name = $"Name {i}" });
               _db.SaveChanges();
            }
        }
    }
}
