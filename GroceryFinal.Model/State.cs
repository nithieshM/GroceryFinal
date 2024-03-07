using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryFinal.Model
{
    public class State
    {
        [Key]
        [DisplayName("State Id")]
        public int StateId { get; set; }
        [Required(ErrorMessage = "State Name Required!")]
        [DisplayName("State Name")]
        public string StateName { get; set; }
    }
}
