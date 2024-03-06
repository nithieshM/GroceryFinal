using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace GroceryApp.Models
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Customer Name Required!")]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Customer Address Required!")]
        [DisplayName("Customer Address")]
        public string CustomerAddress { get; set; }
        [DisplayName("Customer Secondary Address")]
        public string? CustomerAddress2 { get; set; }
        [Required(ErrorMessage = "Customer City Required!")]
        [DisplayName("Customer City")]
        public string CustomerCity { get; set; }
        [Required(ErrorMessage = "Customer State Required!")]
        [DisplayName("Customer State")]
        public string CustomerState { get; set; }

        [Required(ErrorMessage = "Customer Pin Code Required!")]
        [DataType(DataType.PostalCode)]
        [DisplayName("Customer Pin Code")]
        [RegularExpression(@"^[1-9][0-9]{5}$", ErrorMessage = "Please Enter a valid pin code!")]
        public int CustomerZipCode { get; set; }

        [Required(ErrorMessage = "Customer Phone Number Required!")]
        [DisplayName("Customer Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0]|\+91)?\d{10}$", ErrorMessage = "Please Enter a valid phone number!")]
        public string CustomerPhone { get; set; }

        [Required(ErrorMessage = "Email Address Required!")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Customer Email Address")]
        [RegularExpression(@"(?i)\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please Enter a valid email address!")]
        public string CustomerEmail { get; set; }

    }
}