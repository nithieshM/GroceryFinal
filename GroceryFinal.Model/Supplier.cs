using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.Model
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required(ErrorMessage = "Supplier Name Required!")]
        [DisplayName("Supplier Name")]
        public string SupplierName { get; set; }
        [Required(ErrorMessage = "Supplier Address Required!")]
        [DisplayName("Supplier Address")]
        public string SupplierAddress { get; set; }
        [DisplayName("Supplier Secondary Address")]
        public string? SupplierAddress2 { get; set; }
        [Required(ErrorMessage = "Supplier City Required!")]
        [DisplayName("Supplier City")]
        public string SupplierCity { get; set; }
        [Required(ErrorMessage = "Supplier State Required!")]
        [DisplayName("Supplier State")]
        public string SupplierState { get; set; }

        [Required(ErrorMessage = "Supplier Pin Code Required!")]
        [DataType(DataType.PostalCode)]
        [DisplayName("Supplier Pin Code")]
        [RegularExpression(@"^[1-9][0-9]{5}$", ErrorMessage = "Please Enter a valid pin code!")]
        public int SupplierZipCode { get; set; }

        [Required(ErrorMessage = "Supplier Phone Number Required!")]
        [DisplayName("Supplier Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^([0]|\+91)?\d{10}$", ErrorMessage = "Please Enter a valid phone number!")]
        public string SupplierPhone { get; set; }

        [Required(ErrorMessage = "Email Address Required!")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Supplier Email Address")]
        [RegularExpression(@"(?i)\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Please Enter a valid email address!")]
        public string SupplierEmail { get; set; }
    }
}
