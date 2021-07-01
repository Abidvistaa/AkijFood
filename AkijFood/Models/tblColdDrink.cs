using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Models
{
    public class tblColdDrink
    {
        [Key]
        public int ColdDrinksId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string ColdDrinksName { get; set; }
        [Required]
        [Column(TypeName = "decimal(4)")]
        public int Quantity { get; set; }
        [Required]
        [Column(TypeName = "decimal(3)")]
        public int UnitPrice { get; set; }
      
    }
}
