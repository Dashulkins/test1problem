using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{ 
    public class FireFighter{

        [Required]
        public int idFireFighter { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
}
