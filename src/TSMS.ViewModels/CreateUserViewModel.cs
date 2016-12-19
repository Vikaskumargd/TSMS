using System.ComponentModel.DataAnnotations;

public class CreateUserViewModel
{
    [Required]
    [Display(Name ="Customer Name")]
    public string Name { get; set; }

  [Required]
    [Display(Name ="Customer Name")]
    public string Address { get; set; }

    [DataType(DataType.MultilineText)]
    
    public string Note { get; set; }

    [Phone]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }

    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string EmailAddress { get; set; }
}