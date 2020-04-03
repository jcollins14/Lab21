using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class User
    {
        public string UserName { get; set; }
        [Required(ErrorMessage = "A username is required.")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "A password is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "An email is required.")]
        [RegularExpression("^([a - zA - Z0 - 9_\\-\\.]+)@([a - zA - Z0 - 9_\\-\\.]+)\\.([a - zA - Z]{2,5})$", ErrorMessage = "Please input a valid number")]
        public string PhoneNum { get; set; }
        [Required]
        [RegularExpression("^(\\(?\\+?[0-9]*\\)?)?[0-9_\\- \\(\\)]*$", ErrorMessage = "Please input a valid number")]
    }
}
