using System.ComponentModel.DataAnnotations;

namespace TSMS.ViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Optional Note")]
        public string Note { get; set; }

        [Phone]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email Id")]
        public string EmailAddress { get; set; }
    }
}