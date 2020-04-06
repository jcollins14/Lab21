using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class User
    {
        [Required(ErrorMessage = "A username is required.")]
        [StringLength(30)]
        [MinLength(4)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "A password is required.")]
        [MinLength(5,ErrorMessage = "Passwords require 5 or more characters.")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "An email is required.")]
        [RegularExpression("^([a - zA - Z0 - 9_\\-\\.]+)@([a - zA - Z0 - 9_\\-\\.]+)\\.([a - zA - Z]{2,5})$", ErrorMessage = "Please input a valid email")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^(\\(?\\+?[0-9]*\\)?)?[0-9_\\- \\(\\)]*$", ErrorMessage = "Please input a valid number")]
        public string PhoneNum { get; set; }
        public List<string> Genre = new List<string>();
        public string BirthdayMonth { get; set; }
        public string KeyboardPref { get; set; }

    }
}
