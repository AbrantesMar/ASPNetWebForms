using System;
using System.ComponentModel.DataAnnotations;

namespace StoreCurso.Model
{
    public class User : Person
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public bool Valid { get; set; }

        public User(int id = 0, string name = "") : base(id, name)
        {
            
        }
    }
}