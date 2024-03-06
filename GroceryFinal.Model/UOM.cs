using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.Model
{
    public class UOM
    {
        [Key]
        public int UOMId { get; set; }
        [Required(ErrorMessage = "UOM Name Required!")]
        [DisplayName("UOM Description")]
        public string UOMName { get; set; }
    }
}
