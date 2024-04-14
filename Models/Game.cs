using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApp.Models
{
    public class Game
    {
        public int Id { get; set; }
        [ForeignKey("TitleKey")]
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
