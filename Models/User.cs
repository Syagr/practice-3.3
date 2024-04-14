using System.ComponentModel.DataAnnotations;

namespace TestWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, Length(5,12)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
