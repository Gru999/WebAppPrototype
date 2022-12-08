using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebAppPrototype.Models {
    public class User {
        //might need to make UserId auto-increment
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter your Name"), DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter your Phone nr."), DisplayName("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Enter your Email"), DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
