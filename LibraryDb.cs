using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp
{

    public class LibraryDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }

        public LibraryDb(DbContextOptions<LibraryDb> options)
            : base(options)
        {
             
        }
    }

    //public class LibraryDb  
    //{
    //    private static LibraryDb instance;

    //    public List<Book> Books { get; set; }
    //    public List<User> Users { get; set; }


    //    private LibraryDb()
    //    {
    //        Books = new List<Book>();
    //        Users = new List<User>();

    //        for (int i = 0; i < 100; i++)
    //        {
    //            Users.Add(new User() { Id = i, Email = $"Email {i}", Name = $"Name {i}" });
    //        }

    //        for (int i = 0; i < 100; i++)
    //        {
    //            Books.Add(new Book() { Id = i, Description = $"Description {i}", Title = $"Title {i}" });
    //        }
    //    }

    //    public static LibraryDb Instance
    //    {
    //        get
    //        {
    //            if (instance == null)
    //            {
    //                instance = new LibraryDb();
    //            }
    //            return instance;
    //        }
    //    }
    //}
}
