using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
   public class Kitchen
    {
        [ForeignKey("Id")]
        [Key]
        public Guid Id { get; set; }
        public string Menu { get; set; }
        public string FoodItem { get; set; }
        public int Amount { get; set; }
    }
}
