using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name Required!")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "UOM Required!")]
        [DisplayName("UOM")]
        [DataType(DataType.Currency)]
        public string UOM { get; set; }
        [Required(ErrorMessage = "Purchase Rate Required")]
        [DisplayName("Purchase Rate")]
        [DataType(DataType.Currency)]
        public double PurchaseRate { get; set; }
        [Required(ErrorMessage = "Selling Rate Required")]
        [DisplayName("Selling Rate")]
        [DataType(DataType.Currency)]
        public double SellingRate { get; set; }
        [Required(ErrorMessage = "Stock Required")]
        [DisplayName("Stock")]
        public double Stock { get; set; }
        [Required(ErrorMessage = "Purchase Stock Required")]
        [DisplayName("Purchase Stock")]
        [DataType(DataType.Currency)]
        public double PurchaseStock { get; set; }
        [Required(ErrorMessage = "Selling Stock Required")]
        [DisplayName("Selling Stock")]
        [DataType(DataType.Currency)]
        public double SellingStock { get; set; }
        [Required(ErrorMessage = "Reorder Level Required")]
        [DisplayName("Reorder Level")]
        public double ReorderLevel { get; set; }
        [Required(ErrorMessage = "Quantity Required")]
        [DisplayName("Quantity")]
        public double Quantity { get; set; }
    }
}
